using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Portrait : MonoBehaviour
{
	List<Sprite> cachedList = null;
	//bool changed = true;
	public List<Sprite> SpritesList {
		get
		{
			if (changed || cachedList == null)
			{
				cachedList = new List<Sprite> ();
				var sortedSprites = from pair in Sprites
				                    orderby pair.Value.Priority ascending
				                    select pair.Value.Part;
				foreach (var sortedSprite in sortedSprites)
					cachedList.Add (sortedSprite);
				changed = false;
			} 

			return cachedList;
		}
	}

	public struct SpritePart
	{
		public Sprite Part;
		public float Priority;
	}

	public event VoidDelegate Updated;

	public void OnUpdate (VoidDelegate updateDelegate)
	{
		Updated += updateDelegate;
	}

	bool changed = false;

	public Dictionary<string, SpritePart> Sprites { get; set; }

	void Awake ()
	{
		Sprites = new Dictionary<string, SpritePart> (2);
	}

	public void Set (string nameTag, float priority, Sprite sprite)
	{
		changed = true;
		if (Sprites.ContainsKey (nameTag))
			Sprites [nameTag] = new SpritePart (){ Part = sprite, Priority = priority };
		else
			Sprites.Add (nameTag, new SpritePart (){ Part = sprite, Priority = priority });
		if (Updated != null)
			Updated ();
	}

	public void Switch (string nameTag, Sprite sprite)
	{
		float priority = 0;
		SpritePart part;
		if (Sprites.TryGetValue (nameTag, out part))
			priority = part.Priority;
		Set (nameTag, priority, sprite);
	}

	public void Remove (string nameTag)
	{
		changed = true;
		if (Sprites.ContainsKey (nameTag))
			Sprites.Remove (nameTag);
		if (Updated != null)
			Updated ();
	}

	public Sprite Get (string nameTag)
	{
		changed = true;
		if (Sprites.ContainsKey (nameTag))
			return Sprites [nameTag].Part;
		else
			return null;
		if (Updated != null)
			Updated ();
	}
}

