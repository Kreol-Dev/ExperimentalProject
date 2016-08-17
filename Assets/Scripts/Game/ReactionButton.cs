using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReactionButton : MonoBehaviour
{
	public VoidDelegate OnClick;
	public string Text;
	[SerializeField]
	Text UIText;

	void Start ()
	{
		GetComponent<Button> ().onClick.AddListener (Click);
		UIText.text = Text;
	}

	void Click ()
	{
		OnClick ();
	}



}

