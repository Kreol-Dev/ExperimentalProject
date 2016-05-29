using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestScope
{

	public bool Done { get; internal set; }

	public List<object> ScopedObjects {
		get
		{
			if (!Done)
				Find ();
			return cachedList;
		}
	}

	List<object> cachedList = new List<object> ();
	List<object> switchList = new List<object> ();
	List<ScopeFilter> filters = new List<ScopeFilter> ();
	ScopeGenerator gen;

	void Find ()
	{
		cachedList.Clear ();
		switchList.Clear ();
		gen.Get (cachedList);
		if (filters.Count > 0)
		{
			List<object> temp = null;
			for (int i = 0; i < filters.Count; i++)
			{
				filters [i].Filter (cachedList, switchList);
				cachedList.Clear ();
				temp = switchList;
				switchList = cachedList;
				cachedList = temp;
			}
			temp = switchList;
			switchList = cachedList;
			cachedList = temp;
		}
	}
}

public abstract class ScopeGenerator
{
	public abstract void Get (List<object> toList);
}

public abstract class ScopeFilter
{
	public abstract void Filter (List<object> fromList, List<object> toList);
}

