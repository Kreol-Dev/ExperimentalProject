using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public delegate void PortraitDelegate (Portrait portrait) ;
public class Portrait : MonoBehaviour
{
	public event PortraitDelegate PortraitChanged;

	public struct SpriteData
	{
		public Sprite Sprite;
		public int Priority;

		public SpriteData (int priority, Sprite sprite)
		{
			Sprite = sprite;
			Priority = priority;
		}
	}

	public Dictionary<string, SpriteData> Sprites = new Dictionary<string, SpriteData> (3);

	public void SetSprite (int priority, SpriteImage sprite)
	{
		if (Sprites.ContainsKey (sprite.ID))
			Sprites [sprite.ID] = new SpriteData (priority, sprite.Sprite);
		else
			Sprites.Add (sprite.ID, new SpriteData (priority, sprite.Sprite));
		if (PortraitChanged != null)
			PortraitChanged (this);
	}

	public void RemoveSprite (SpriteImage sprite)
	{
		if (Sprites.ContainsKey (sprite.ID))
			Sprites.Remove (sprite.ID);
		if (PortraitChanged != null)
			PortraitChanged (this);
	}


}

