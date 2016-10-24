using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PortraitUI : MonoBehaviour
{

	Portrait targetPortrait;
	static GameObject SpritePrefab;
	List<Image> images = new List<Image> ();

	public Portrait TargetPortrait {
		get { return targetPortrait; }
		set
		{
			targetPortrait = value;
			targetPortrait.Updated -= OnUpdate;
			targetPortrait.Updated += OnUpdate;
			OnUpdate ();
		}
	}

	void Start ()
	{
		if (SpritePrefab == null)
			SpritePrefab = GameObject.Find ("SpritePrefab");
	}

	void OnDestory ()
	{
		targetPortrait.Updated -= OnUpdate;	
	}

	void OnUpdate ()
	{
		var sprites = targetPortrait.SpritesList;
		for (int i = 0; i < sprites.Count; i++)
		{
			if (images.Count > i)
				images [i].sprite = sprites [i];
			else
			{
				var goImage = GameObject.Instantiate (SpritePrefab).GetComponent<Image> ();
				goImage.sprite = sprites [i];
				images.Add (goImage);
				goImage.transform.SetParent (transform);
			}
		}

		while (images.Count > sprites.Count)
		{
			Destroy (images [images.Count - 1]);
			images.RemoveAt (images.Count - 1);
		}
	}
}

