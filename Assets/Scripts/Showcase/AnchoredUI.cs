using UnityEngine;
using System.Collections;

public class AnchoredUI : MonoBehaviour
{

	[SerializeField]
	Transform anchorT;
	Renderer targetRenderer;
	static RectTransform CanvasRect;

	public GameObject Anchor {
		get { return anchorT.gameObject; }
		set
		{
			if (anchorT != null)
				Destroy (anchorT.gameObject.GetComponent<SpriteRenderer> ());
			anchorT = value.transform;
			targetRenderer = value.AddComponent<SpriteRenderer> ();
		}
	}

	void Start ()
	{
		if (CanvasRect == null)
			CanvasRect = FindObjectOfType<Canvas> ().GetComponent<RectTransform> ();
	}

	void Update ()
	{
		
		if (targetRenderer.isVisible)
		{
			//targetRenderer.
			transform.localScale = Vector3.one;
			Vector2 viewportPos = Camera.main.WorldToViewportPoint (anchorT.position);
			Vector2 canvasPos = new Vector2 (CanvasRect.sizeDelta.x * viewportPos.x,//- CanvasRect.sizeDelta.x * 0.5f,
			                                 CanvasRect.sizeDelta.y * viewportPos.y);//- CanvasRect.sizeDelta.y * 0.5f);
			transform.position = canvasPos;
		} else
		{
			transform.localScale = Vector3.zero;
		}


	}
}

