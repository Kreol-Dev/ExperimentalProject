﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class Story : MonoBehaviour
{

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
        
        int index = 0;
        while(CurrentStep < StepsCount)
        {
            float startTime = Time.realtimeSinceStartup - Time.time;//time since this iteration started
            while (actors.Count > 0 && Time.realtimeSinceStartup - Time.time - startTime < 5f)
            {
                while(actors.Count > 0)
                {
                    if (index >= actors.Count)
                    {
                        index = 0;
                        break;
                    }
                    GameObject actor = actors[index];
                    if(actor == null || !actor.activeInHierarchy)
                    {
                        actors.RemoveAt(index);
                        break;
                    }
                    gens.GenerateMostUseful(actor, 0.1f);
                    index++;
                } 
            }
            CurrentStep++;
            yield return null;
        }
    }
    

    
}

