using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ProgressBarSet : MonoBehaviour
{
	public int Height = 0;
    [SerializeField]
	int barsCount = 0;
	public Font Font;

	public ProgressBar CreateBar (Color color, string name)
	{

		barsCount++;
		gameObject.SetActive (true);

		GameObject go = new GameObject ("progress bar " + name);
		var rect = go.AddComponent<RectTransform> ();
		rect.SetParent (transform);
		var layout = go.AddComponent<LayoutElement> ();
		layout.minHeight = Height;


		GameObject backGO = new GameObject ("full bar background");
		var backRect = backGO.AddComponent<RectTransform> ();
		backRect.anchorMin = Vector2.zero;
		backRect.anchorMax = Vector2.one;
		backRect.SetParent (rect);
		backRect.sizeDelta = Vector2.zero;
		var backImage = backGO.AddComponent<Image> ();
		backImage.color = new Color (color.r, color.g, color.b, 0.5f);

		GameObject imageGO = new GameObject ("progress indicator");
		imageGO.AddComponent<RectTransform> ().SetParent (backGO.transform);
		var image = imageGO.AddComponent<Image> ();
		var bar = imageGO.AddComponent<ProgressBar> ();
		bar.OnBarExpired += Bar_OnBarExpired; 
		image.color = color;

		parentOfBars.Add (bar.gameObject, go);
		return bar;
	}

	Dictionary<GameObject, GameObject> parentOfBars = new Dictionary<GameObject, GameObject> ();
	Stack<GameObject> entitiesToDestroy = new Stack<GameObject> ();

	void Bar_OnBarExpired (GameObject entity)
	{
		lock (entitiesToDestroy)
		{
			entitiesToDestroy.Push (entity);
        }
	}

	void Update ()
	{
		lock (entitiesToDestroy)
		{
           /* var stack = new Stack<GameObject>();
            while (entitiesToDestroy.Count > 0)
            {
                var e = entitiesToDestroy.Pop();
                stack.Push(e);
                var parent = parentOfBars[e];
                Debug.LogWarning(parent.name + " expires");
            }
            entitiesToDestroy = stack;*/
                while (entitiesToDestroy.Count > 0)
            {
                var e = entitiesToDestroy.Pop();
                GameObject parent;
                parentOfBars.TryGetValue(e, out parent);
                if(parent != null)
                {
                    barsCount--;
                    parentOfBars.Remove(e);
                    Destroy(parent);
                }
                
            }
		}
		if (barsCount == 0)
			gameObject.SetActive (false);
	}



}

