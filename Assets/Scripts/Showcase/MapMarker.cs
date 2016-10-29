using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MapMarker : MonoBehaviour
{
	[SerializeField]
	PortraitUI TargetPortrait;
	[SerializeField]
	Text TargetText;
	[SerializeField]
	RectTransform TextImageTransform;
    
	public string Text {
		get { return TargetText.text; }
		set
		{
			TargetText.text = value;
		}
	}

	public Portrait Portrait { get { return TargetPortrait.TargetPortrait; } set { TargetPortrait.TargetPortrait = value; } }
    
}

