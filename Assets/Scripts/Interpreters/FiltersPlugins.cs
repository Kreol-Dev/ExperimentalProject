using UnityEngine;
using System.Collections;
using System;
using InternalDSL;
using System.CodeDom;
using System.Collections.Generic;


public class FiltersPlugin : ScriptEnginePlugin
{
	Dictionary<string, FilterPartInterpreter> filters = new Dictionary<string, FilterPartInterpreter> ();

	public override void Init ()
	{

	}

	public void AddFilter (FilterPartInterpreter filter, string name)
	{
		filter.Engine = Engine;
		filters.Add (name, filter);
	}


	public FilterPartInterpreter GetFilter (string filterName)
	{
		FilterPartInterpreter filter = null;
		filters.TryGetValue (filterName, out filter);
		return filter;
	}


}

public class ComponentsFiltersPlugin : ScriptEnginePlugin
{
	public override void Init ()
	{
		FiltersPlugin filtersPlugin = Engine.GetPlugin<FiltersPlugin> ();

		var components = Engine.FindTypesCastableTo<MonoBehaviour> ();
		foreach (var cmp in components)
		{
			var cmpName = NameTranslator.ScriptNameFromCSharp (cmp.Name);
			var opName = "has_" + cmpName;
			HasComponentFilter filter = new HasComponentFilter (cmp);
			filtersPlugin.AddFilter (filter, opName);
		}
	}
}

public class FilterPartInterpreterAttribute : Attribute
{
	public string Name { get; set; }

	public FilterPartInterpreterAttribute (string name)
	{
		Name = name;
	}
}


public abstract class FilterPartInterpreter
{
	public ScriptEngine Engine;

	public abstract void Interpret (Expression[] args, CodeMemberMethod filterFunction);
}

public class HasComponentFilter : FilterPartInterpreter
{
	Type cmpType;
	string checkString;

	public HasComponentFilter (Type cmpType)
	{

		this.cmpType = cmpType;
		checkString = String.Format ("if(go.GetComponent<{0}>() == null) return false;", cmpType);
	}

	public override void Interpret (Expression[] args, CodeMemberMethod filterFunction)
	{
		if (args != null)
			Debug.Log ("Somehow has component filter has arguments");
		filterFunction.Statements.Add (new CodeSnippetStatement (checkString));
	}
}