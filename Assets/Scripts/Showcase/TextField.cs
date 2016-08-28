using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextField : MonoBehaviour
{
	Text text;
	static FontHolder Holder;

	void Awake ()
	{
		if (Holder == null)
			Holder = Resources.Load<FontHolder> ("ArialFontHolder");
		GameObject textSubObject = new GameObject ("text");
		textSubObject.transform.SetParent (this.transform);
		text = textSubObject.AddComponent<Text> ();
		text.font = Holder.Font;
	}

	public void Set (string txt)
	{
		text.text = txt;
	}
}

