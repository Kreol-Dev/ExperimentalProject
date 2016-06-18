using UnityEngine;
using System.Collections;
using InternalDSL;
using System.IO;
using System.CodeDom;
using System.Text;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System;
using Microsoft.CSharp;

public class BasicLoader : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		var openedFile = File.OpenText ("Mods/test.def");

		DefTokenizer tokenizer = new DefTokenizer (openedFile);
		var node = tokenizer.Next ();
		//		while (node != null)
		//		{
		//			Debug.Log (node);
		//			node = tokenizer.Next ();
		//		}
		openedFile.Close ();
		openedFile = File.OpenText ("Mods/test.def");
		DefParser parser = new DefParser (openedFile);
		var parseNode = parser.Parse ();
		openedFile.Close ();
		Root root = new Root (parseNode);
		root.Show ();

		var cUnit = new CodeCompileUnit ();
		CodeNamespace opNamespace = new CodeNamespace ("Operators");
		cUnit.Namespaces.Add (opNamespace);
		Dictionary<string, CodeNamespace> namespaces = new Dictionary<string, CodeNamespace> ();
		StringBuilder builder = new StringBuilder ();
		for (int i = 0; i < root.Operators.Count; i++)
		{
			var opTable = root.Operators [i];
			CodeTypeDeclaration opClass = new CodeTypeDeclaration (opTable.Identifier as string);
			opNamespace.Types.Add (opClass);
		}
		CSharpCodeProvider codeProvider = new CSharpCodeProvider ();
		StringWriter writer = new StringWriter ();
		CodeGeneratorOptions opt = new CodeGeneratorOptions ();
		codeProvider.GenerateCodeFromCompileUnit (cUnit, writer, opt);
		CompilerParameters cParams = new CompilerParameters ();
//			var results = codeProvider.CompileAssemblyFromDom (cParams, cUnit);
//			codeProvider.GenerateCodeFromCompileUnit (cUnit, writer, opt);
		var text = FindObjectOfType<UnityEngine.UI.Text> ();
//			text.text = writer.ToString ();
//		CodeCompiler compiler = new CodeCompiler ();
//		compiler.CompileFromDom ();

		var compiler = new CSharpCompiler.CodeCompiler ();
		var results = compiler.CompileAssemblyFromSource (cParams, writer.ToString ());
		foreach (var type in results.CompiledAssembly.GetTypes ())
		{
			text.text += type;
			text.text += Environment.NewLine;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
