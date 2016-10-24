using UnityEngine;
using System.Collections;

public class AnchoredUI : MonoBehaviour
{

	[SerializeField]
	Transform anchorT;
	static RectTransform CanvasRect;

	public GameObject Anchor { get { return anchorT.gameObject; } set { anchorT = value.transform; } }

	void Start ()
	{
		if (CanvasRect == null)
			CanvasRect = FindObjectOfType<Canvas> ().GetComponent<RectTransform> ();
	}

	void Update ()
	{
		Vector2 viewportPos = Camera.main.WorldToViewportPoint (anchorT.position);
		Vector2 canvasPos = new Vector2 (CanvasRect.sizeDelta.x * viewportPos.x - CanvasRect.sizeDelta.x * 0.5f,
		                                 CanvasRect.sizeDelta.y * viewportPos.y - CanvasRect.sizeDelta.y * 0.5f);
		transform.position = canvasPos;

	}
}

