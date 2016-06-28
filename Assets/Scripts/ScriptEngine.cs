﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System;
using System.CodeDom.Compiler;

public class ScriptEngine
{
	
	List<Type> allTypes = new List<Type> ();

	public IEnumerable<Assembly> Addons { get; internal set; }

	Dictionary<Type, ScriptEnginePlugin> plugins = new Dictionary<Type, ScriptEnginePlugin> ();

	public ScriptEngine (IEnumerable<Assembly> addons)
	{
		this.Addons = addons;
		foreach (var plugin in addons)
		{
			AppDomain.CurrentDomain.Load (plugin.GetName ());
			var pluginTypes = plugin.GetTypes ();
			for (int i = 0; i < pluginTypes.Length; i++)
				allTypes.Add (pluginTypes [i]);
		}
		var coreTypes = Assembly.GetExecutingAssembly ().GetTypes ();
		for (int i = 0; i < coreTypes.Length; i++)
			allTypes.Add (coreTypes [i]);

		var enginePlugins = FindTypesCastableTo<ScriptEnginePlugin> ();
		for (int i = 0; i < enginePlugins.Count; i++)
		{
			var pluginInstance = Activator.CreateInstance (enginePlugins [i]) as ScriptEnginePlugin;
			pluginInstance.Init (this);
			plugins.Add (enginePlugins [i], pluginInstance);
		}
	}

	public T GetPlugin<T> () where T : ScriptEnginePlugin
	{
		ScriptEnginePlugin plugin = null;
		plugins.TryGetValue (typeof(T), out plugin);
		return plugin as T;
	}



	public struct TypeAttributePair<T> where T : Attribute
	{
		public Type Type;
		public T Attribute;

		public TypeAttributePair (Type t, T a)
		{
			Type = t;
			Attribute = a;
		}
	}

	public List<TypeAttributePair<T>> FindTypesWithAttribute<T> () where T : Attribute
	{
		Type attrType = typeof(T);
		List<TypeAttributePair<T>> pairs = new List<TypeAttributePair<T>> ();
		for (int i = 0; i < allTypes.Count; i++)
		{
			Type curType = allTypes [i];
			var attrs = curType.GetCustomAttributes (attrType, false);
			if (attrs.Length == 1)
				pairs.Add (new TypeAttributePair<T> (curType, attrs [0] as T));
		}
		return pairs;
	}

	public List<Type> FindTypesCastableTo<T> ()
	{
		Type castTo = typeof(T);
		var types = new List<Type> ();
		for (int i = 0; i < allTypes.Count; i++)
		{
			Type curType = allTypes [i];
			if (castTo.IsAssignableFrom (curType) && curType != castTo && !curType.IsAbstract && !curType.IsGenericType)
				types.Add (curType);
		}
		return types;
	}
}

public abstract class ScriptEnginePlugin
{
	public abstract void Init (ScriptEngine engine);
}

public class ScriptCompiler : ScriptEnginePlugin
{
	List<string> csharpSources = new List<string> ();
	ScriptEngine engine;

	public override void Init (ScriptEngine engine)
	{
		this.engine = engine;
	}

	public void AddSource (string source)
	{
		csharpSources.Add (source);
	}

	public void Compile ()
	{
		CompilerParameters cParams = new CompilerParameters ();
		foreach (var plugin in engine.Addons)
			cParams.ReferencedAssemblies.Add (plugin.Location);
		var compiler = new CSharpCompiler.CodeCompiler ();
		var result = compiler.CompileAssemblyFromSourceBatch (cParams, csharpSources.ToArray ());
		if (result.Errors.Count == 0)
		{
		} else
		{
			for (int i = 0; i < result.Errors.Count; i++)
				Debug.Log (result.Errors [i]);
		}
	}
}