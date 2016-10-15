using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Named : MonoBehaviour
{
	static StringBuilder nameBuilder = new StringBuilder ();
	string cachedName = null;

	public string FullName {
		get
		{
			//should localise here
			if (changed || cachedName == null)
			{
				nameBuilder.Length = 0;
				var sortedNames = from pair in Names
				                  orderby pair.Value.Priority ascending
				                  select pair.Value.Part;
				foreach (var sortedName in sortedNames)
					nameBuilder.Append (sortedName).Append (' ');
				cachedName = nameBuilder.ToString ();
				changed = false;
			} 
			return cachedName;
		}
	}

	public struct NamePart
	{
		public string Part;
		public float Priority;
	}

	public event VoidDelegate Updated;

	public void OnUpdate (VoidDelegate updateDelegate)
	{
		Updated += updateDelegate;
	}

	bool changed = false;

	public Dictionary<string, NamePart> Names { get; set; }

	void Awake ()
	{
		Names = new Dictionary<string, NamePart> ();
	}

	public void Set (string nameTag, float priority, string name)
	{
		changed = true;
		if (Names.ContainsKey (nameTag))
			Names [nameTag] = new NamePart (){ Part = name, Priority = priority };
		else
			Names.Add (nameTag, new NamePart (){ Part = name, Priority = priority });
		if (Updated != null)
			Updated ();
	}

	public void Switch (string nameTag, string name)
	{
		float priority = 0;
		NamePart part;
		if (Names.TryGetValue (nameTag, out part))
			priority = part.Priority;
		Set (nameTag, priority, name);
	}

	public void Remove (string nameTag)
	{
		changed = true;
		if (Names.ContainsKey (nameTag))
			Names.Remove (nameTag);
		if (Updated != null)
			Updated ();
	}

	public string Get (string nameTag)
	{
		changed = true;
		if (Names.ContainsKey (nameTag))
			return Names [nameTag].Part;
		else
			return "";
		if (Updated != null)
			Updated ();
	}

}

