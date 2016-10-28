using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text;
using System.Collections.Generic;

public class EncounterUI : MonoBehaviour
{
	static Generators gens;
	public RectTransform ReactionsList;
	public Text NameText;
	public PortraitUI EventPortraitUI;
	public Text DescriptionText;
    public UiObject AdditionalData;
    Encounter encounter;
	public Encounter Encounter { get { return encounter; } set { encounter = value; AdditionalData.ShowedObject = encounter.gameObject; } }

    static StringBuilder builder = new StringBuilder();
    List<string> descs = new List<string>();
    public string Description
    {
        get { builder.Length = 0; foreach (var str in descs) builder.Append(str); return builder.ToString(); }
        set { descs.Add(value); }
    }

    public string Name {  get { return NameText.text;  } set { NameText.text = value; } }
    internal void Reacted()
    {
        Encounter.GetComponent<Entity>().Destroy();
        
        Destroy(gameObject);
    }

    void Start ()
	{
		if (gens == null)
			gens = FindObjectOfType<Generators> ();
		gens.Generate (gameObject);
		Encounter.NewReaction += Encounter_NewReaction;
		foreach (var reaction in Encounter.reactProtos)
			Encounter_NewReaction (reaction);       
        if(AdditionalData.transform.childCount == 0)
        {
            Destroy(AdditionalData);
        }

        if(ReactionsList.childCount == 0)
        {
            Encounter_NewReaction(null);
        }

        DescriptionText.text = Description;
	}

	void Encounter_NewReaction (GameObject reaction)
	{
		GameObject uiGO = new GameObject (reaction.name + "ui_reaction");

		var uiObject = uiGO.AddComponent<UiObject> ();
		uiObject.ShowedObject = reaction;

		var reactButton = uiGO.AddComponent<ReactionButton> ();
		reactButton.Proto = reaction;

		uiGO.transform.SetParent (ReactionsList);
		gens.Generate (uiGO);
	}
}

