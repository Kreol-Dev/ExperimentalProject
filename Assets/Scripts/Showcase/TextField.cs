using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextField : MonoBehaviour
{
	Text text;

	public LayoutElement Layout { get; internal set; }

	string label;
	string lastText;

	public string Label {
		get { return label; }
		set
		{
			label = value + ": ";
			Show (lastText);
		}
	}

	static FontHolder Holder;

	void Awake ()
	{
		if (Holder == null)
			Holder = Resources.Load<FontHolder> ("ArialFontHolder");
		GameObject textSubObject = new GameObject ("text");
		textSubObject.transform.SetParent (this.transform);
		text = textSubObject.AddComponent<Text> ();
		text.font = Holder.Font;
		Layout = textSubObject.AddComponent<LayoutElement> ();
	}

	public void Show (string txt)
	{
		lastText = txt;
		text.text = Label + txt;
	}
}

