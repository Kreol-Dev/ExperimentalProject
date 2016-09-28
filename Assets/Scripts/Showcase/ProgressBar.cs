using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
	[SerializeField]
	Image barImage;

	[SerializeField]
	RectTransform parentTransform;


	int maxValue = 0;

	public int MaxValue { get { return maxValue; } set { maxValue = value; } }

	int curValue = 0;

	int CurValue { get { return curValue; } set { curValue = value; } }

	void Awake ()
	{
		barImage.rectTransform.anchorMin = new Vector2 (0, 0);
		barImage.rectTransform.anchorMax = new Vector2 (1, 1);
		OnValueUpdate ();
	}

	void OnValueUpdate ()
	{
		
		if (maxValue != 0)
		{
			float percent = (float)curValue / (float)maxValue;
			barImage.rectTransform.offsetMax = new Vector2 (percent, 1f);
		}
	}

	void Update ()
	{
		
	}
}

