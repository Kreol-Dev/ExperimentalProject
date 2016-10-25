using UnityEngine;
using System.Collections;

public class NextTurn : MonoBehaviour
{
	public delegate void OnNewTurn (VoidDelegate onFinished);

	public void StartNewTurn (VoidDelegate turnFinished)
	{
		Debug.Log ("New turn");
		this.turnFinished = turnFinished;
		turnProcessed = 0;
		if (NewTurn != null)
			NewTurn (OnTurnFinishedByListener);
		else
			turnFinished ();
	}

	void OnTurnFinishedByListener ()
	{
		turnProcessed++;
		if (turnProcessed == listenersCount)
		{
			turnFinished ();
			Debug.Log ("Turn finished");
		}
	}

	VoidDelegate turnFinished;
	int turnProcessed = 0;
	int listenersCount = 0;

	event OnNewTurn NewTurn;

	public void NewTurnListener (OnNewTurn turnCallback)
	{
		listenersCount++;
		NewTurn += turnCallback;
	}

	public void RemoveNewTurnListener (OnNewTurn turnCallback)
	{
		listenersCount--;
		NewTurn -= turnCallback;
	}
}

