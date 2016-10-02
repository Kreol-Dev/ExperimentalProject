using UnityEngine;
using System.Collections;

public class TaleNodes : MonoBehaviour
{
	public Transform Nodes;

	void Awake ()
	{
		FindObjectOfType<BasicLoader> ().EFunctions.Add (new BasicLoader.ExternalFunctions (this, "TalesUiEnlist", "Stringify"));
	}

	public void TalesUiEnlist (GameObject go)
	{
		go.transform.SetParent (Nodes);
	}

	public string Stringify (GameObject go)
	{
		return go.name;
	}
}

