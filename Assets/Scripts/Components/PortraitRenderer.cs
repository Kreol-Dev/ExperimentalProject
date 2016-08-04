using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using UnityEngine.UI;

public class PortraitRenderer : MonoBehaviour
{
	OrderedDictionary spritesDictionary = new OrderedDictionary ();
	Dictionary<RectTransform, List<Image>> imagesByPanel = new Dictionary<RectTransform, List<Image>> ();
	Dictionary<Portrait, HashSet<RectTransform>> panelsByPortrait = new Dictionary<Portrait, HashSet<RectTransform>> ();

	Stack<GameObject> freeImages = new Stack<GameObject> ();

	public void Render (Portrait portrait, RectTransform panel, HashSet<string> excludeLayers)
	{
		
		spritesDictionary.Clear ();
	

		List<Image> images = null;
		if (!imagesByPanel.TryGetValue (panel, out images))
		{
			images = new List<Image> ();
			HashSet<RectTransform> panels = null;
			if (!panelsByPortrait.TryGetValue (portrait, out panels))
			{
				panels = new HashSet<RectTransform> ();
				panelsByPortrait.Add (portrait, panels);
			}
			panels.Add (panel);
		}
			



		foreach (var sprite in portrait.Sprites)
		{
			if (excludeLayers != null && !excludeLayers.Contains (sprite.Key))
				continue;
			var spriteData = sprite.Value;
			spritesDictionary.Add (spriteData.Priority, spriteData.Sprite);
		}

		for (int i = 0; i < spritesDictionary.Count; i++)
		{
			if (images.Count > i)
				images [i].sprite = spritesDictionary [i] as Sprite;
			else
			{
				GameObject spriteObject = null;
				Image image = null;
				if (freeImages.Count > 0)
					spriteObject = freeImages.Pop ();
				else
				{
					spriteObject = new GameObject ();
					image = spriteObject.AddComponent<Image> ();
				}
					
				var rect = spriteObject.GetComponent<RectTransform> ();
				image.sprite = spritesDictionary [i] as Sprite;
				rect.anchorMin = Vector2.zero;
				rect.anchorMax = Vector2.one;
				rect.sizeDelta = Vector2.zero;
				images.Add (image);
			}
		}

		if (images.Count > spritesDictionary.Count)
		{
			for (int i = 0; i < images.Count - spritesDictionary.Count; i++)
			{	
				freeImages.Push (images [images.Count - 1].gameObject);
				images.RemoveAt (images.Count - 1);
			}
		}



	}

	public void OnClear (RectTransform panel)
	{
		
	}
}

