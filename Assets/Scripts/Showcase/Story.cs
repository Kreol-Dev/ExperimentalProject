using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Story : MonoBehaviour
{
    [SerializeField]
    List<GameObject> actors = new List<GameObject>();
    public Generators gens;
	public AnimationCurve IntensityCurve;
	public int StepsCount;
	public int CurrentStep;

    public List<GameObject> Actors {  get { return actors; } }

	public float Intensity ()
	{
		return IntensityCurve.Evaluate ((float)CurrentStep / (float)StepsCount);
	}


    public List<GameObject> AllActors { get { return actors; } }
    public int CurrentDate()
    {
        return CurrentStep;
    }
    void Awake()
    {
        FindObjectOfType<BasicLoader>().EFunctions.Add(new BasicLoader.ExternalFunctions(this, "Intensity", "AllActors", "CurrentDate"));
    }
    bool generating = false;
    void Start()
    {
        generating = false;
        gens = FindObjectOfType<Generators>();
        FindObjectOfType<NextTurn>().NewTurnListener(NewTurn);
    }
   

    public void ReactionToEvent(GameObject eventObject)
    {

    }

    VoidDelegate onFinishTurn;
    public void NewTurn(VoidDelegate onFinishTurn)
    {
        this.onFinishTurn = onFinishTurn;
        StartCoroutine(GenerationCoroutine());
    }
    IEnumerator GenerationCoroutine()
    {
        CurrentStep++;
        for ( int i = 0; i < actors.Count; i++)
        {
            GameObject actor = actors[i];
            if (actor == null || !actor.activeInHierarchy)
            {
                actors.RemoveAt(i);
                i--;
                break;
            }
            //Debug.Log(index, this);
            var a = actor.GetComponent<Actor>();
            a.IsActive = false;
            gens.Generate(actor, 0.1f);
            a.IsActive = true;
            //if(actor.GetComponent<Actor>().CurrentAction == null)
            gens.GenerateMostUseful(actor, 0.1f);
            yield return null;
        }
        onFinishTurn();
    }
    
    

    
}

