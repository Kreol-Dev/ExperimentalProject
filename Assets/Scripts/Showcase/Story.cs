using UnityEngine;
using System.Collections;

public class Story : MonoBehaviour
{

	public AnimationCurve IntensityCurve;
	public int StepsCount;
	public int CurrentStep;
	AgentsActions aActions;

	public float Intensity ()
	{
		return IntensityCurve.Evaluate ((float)CurrentStep / (float)StepsCount);
	}

	void Start ()
	{
		aActions = GetComponent<AgentsActions> ();
		KickstartGeneration ();
	}

	public void KickstartGeneration ()
	{
		StartCoroutine (WairCoroutine ());
	}

	IEnumerator WairCoroutine ()
	{
		yield return null;
		StartCoroutine (GenerationCoroutine ());
	}

	IEnumerator GenerationCoroutine ()
	{

		WaitForSeconds seconds = new WaitForSeconds (1f);
		while (CurrentStep < StepsCount)
		{
			//Do generation
			aActions.Tick ();

			CurrentStep++;
			yield return seconds;
		}
		var saver = FindObjectOfType<SavingLoading> ();
		saver.SaveFilePath = "TestSave.json";
		saver.Save ();
	}
}

