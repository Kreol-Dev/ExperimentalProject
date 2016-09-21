using UnityEngine;
using System.Collections;

public class UiObject : MonoBehaviour
{
	[SerializeField]
	GameObject showedObject;


	public GameObject ShowedObject { get { return showedObject; } set { showedObject = value; } }


}

