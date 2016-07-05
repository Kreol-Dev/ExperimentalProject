using UnityEngine;
using System.Collections;

public class File : MonoBehaviour {

	public int Something;
	public GameObject Loader;
	// Use this for initialization
	void Start () {
		Loader = FindObjectOfType<BasicLoader>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
