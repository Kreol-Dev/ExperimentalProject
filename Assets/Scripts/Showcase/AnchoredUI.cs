using UnityEngine;
using System.Collections;

public class AnchoredUI : MonoBehaviour
{

	[SerializeField]
	Transform anchorT;
	SpriteRenderer targetRenderer;
	static RectTransform CanvasRect;

	public GameObject Anchor {
		get { return anchorT.gameObject; }
		set
		{
			if (anchorT != null)
				Destroy (anchorT.gameObject.GetComponent<SpriteRenderer> ());
			anchorT = value.transform;
			targetRenderer = value.AddComponent<SpriteRenderer> ();
			targetRenderer.color = Color.white;
		}
	}

	void Awake ()
	{

		scale = transform.localScale;
	}

	void Start ()
	{
		if (CanvasRect == null)
			CanvasRect = GameObject.Find ("Canvas").GetComponent<RectTransform> ();
	}

	Vector3 scale;

	void Update ()
	{
		
		if (targetRenderer.isVisible)
		{
			//targetRenderer.
			transform.localScale = scale;
			Vector2 viewportPos = Camera.main.WorldToViewportPoint (anchorT.position);
			Vector2 canvasPos = new Vector2 (CanvasRect.sizeDelta.x * viewportPos.x,// + CanvasRect.sizeDelta.x * 0.5f,
			                                 CanvasRect.sizeDelta.y * viewportPos.y);// + CanvasRect.sizeDelta.y * 0.5f);
			transform.position = canvasPos;
		} else
		{
			transform.localScale = Vector3.zero;
		}


	}
}

