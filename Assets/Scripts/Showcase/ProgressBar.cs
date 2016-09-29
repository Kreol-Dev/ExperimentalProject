using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
	Image barImage;
	Image backImage;
	RectTransform parentTransform;
	GameObject go;
	int maxValue = 0;

	public int MaxValue {
		get { return maxValue; }
		set
		{
			maxValue = value; 
		}
	}

	int curValue = 0;

	public int CurValue {
		get { return curValue; }
		set
		{
			curValue = value;
		}
	}

	void Awake ()
	{
		go = gameObject;
		barImage = GetComponent<Image> ();
		parentTransform = transform.parent.GetComponent<RectTransform> ();
		barImage.rectTransform.pivot = Vector2.zero;
		barImage.rectTransform.anchorMin = new Vector2 (0, 0);
		barImage.rectTransform.anchorMax = new Vector2 (1, 1);
		barImage.rectTransform.sizeDelta = Vector2.zero;
		barImage.rectTransform.localScale = new Vector3 (0f, 1f, 1f);
		backImage = parentTransform.gameObject.GetComponent<Image> ();
		backImage.enabled = false;
		OnValueUpdate ();
	}

	void OnValueUpdate ()
	{
		
		if (maxValue != 0)
		{
			backImage.enabled = true;
			float percent = (float)curValue / (float)maxValue;
			barImage.rectTransform.localScale = new Vector3 (percent, 1f, 1f);
		}
	}

	public event GODelegate OnBarExpired;

	public void Expire ()
	{
		
		if (OnBarExpired != null)
			OnBarExpired (go);
	}

	void Update ()
	{
		
		OnValueUpdate ();
	}
}

