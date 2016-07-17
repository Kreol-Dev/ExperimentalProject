using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Portrait : MonoBehaviour
{
	public List<Sprite> Sprites { get; internal set; }

	void Awake ()
	{
		Sprites = new List<Sprite> ();
	}

	public void SetSprites (List<string> names)
	{
		Sprites.Clear ();
		foreach (var name in names)
		{
			Debug.Log (name);
//			Sprite sprite = Resources.Load<Sprite> (name);
//			Sprites.Add (sprite);
		}
	}

}

public class PersonFitTest : MonoBehaviour
{
	public int Value { get; set; }

	public int SomeValue ()
	{
		return 0;
	}

}

public class Person : MonoBehaviour
{
	public int Age { get; set; }

	public string Name { get; set; }

	public Person Father { get; set; }

	public Person Mother { get; set; }
}

public class Camp : MonoBehaviour
{
	public List<Person> People { get; set; }

	public int Size { get; set; }

	void Awake ()
	{
		People = new List<Person> ();
	}
}

public class Entity : MonoBehaviour
{
	public bool Dead { get; internal set; }

	public void Destroy ()
	{
		Dead = true;
		Destroy (gameObject);
	}
}