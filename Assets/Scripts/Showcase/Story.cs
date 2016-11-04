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

    void Awake()
    {
        FindObjectOfType<BasicLoader>().EFunctions.Add(new BasicLoader.ExternalFunctions(this, "Intensity"));
    }
    bool generating = false;
    void Start()
    {
        generating = false;
        gens = FindObjectOfType<Generators>();
    }
    void Update()
    {
        if(gens.Loaded && !generating)
        {
            generating = true;
            StartCoroutine(GenerationCoroutine());
        }
    }
    
    
    IEnumerator GenerationCoroutine()
    {
        Debug.Log("Started generation");
        int index = 0;
        while(CurrentStep < StepsCount)
        {
            float startTime = Time.realtimeSinceStartup - Time.time;//time since this iteration started
            Debug.Log("Step number: " + CurrentStep);
            while (CurrentStep < StepsCount && actors.Count > 0 && Time.realtimeSinceStartup - Time.time - startTime < 5f)
            {
                while(actors.Count > 0)
                {
                    if (index >= actors.Count)
                    {
                        Debug.Log(actors.Count);
                        CurrentStep++;
                        index = 0;
                        break;
                    }
                    GameObject actor = actors[index];
                    if(actor == null || !actor.activeInHierarchy)
                    {
                        actors.RemoveAt(index);
                        break;
                    }
                    Debug.Log(index, this);
                    var a = actor.GetComponent<Actor>();
                    a.IsActive = false;
                    gens.Generate(actor, 0.1f);
                    a.IsActive = true;
                    gens.GenerateMostUseful(actor, 0.1f);
                    index++;
                } 
            }
            yield return null;
        }
    }
    

    
}

