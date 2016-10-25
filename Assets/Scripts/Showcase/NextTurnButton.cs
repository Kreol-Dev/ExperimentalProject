using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NextTurnButton : MonoBehaviour
{
	NextTurn turn;
	Button button;

	void Awake ()
	{
		button = GetComponent<Button> ();
		turn = FindObjectOfType<NextTurn> ();
	}

	public void NextTurn ()
	{
		button.interactable = false;
		turn.StartNewTurn (OnTurnProcessingFinished);
	}

	public void OnTurnProcessingFinished ()
	{
		button.interactable = true;
	}
}

