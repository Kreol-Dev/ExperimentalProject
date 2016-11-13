using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text;
using System.Collections.Generic;

public class EncounterUi : MonoBehaviour
{

    static GameObject ReactionPrefab;
	static Generators gens;
	public RectTransform ReactionsList;
	public Text NameText;
	public PortraitUI EventPortraitUI;
	public Text DescriptionText;
    public UiObject AdditionalData;
    Encounter encounter;
	public GameObject ShowedObject { get { return encounter.gameObject; } set { encounter = value.GetComponent<Encounter>(); AdditionalData.ShowedObject = value; } }

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
        ShowedObject.GetComponent<Entity>().Destroy();
        
        Destroy(gameObject);
    }

    void Start ()
	{
        if(ReactionPrefab == null)
        {
            ReactionPrefab = Resources.Load<GameObject>("UIPrefabs/ReactionButton");
        }
		if (gens == null)
			gens = FindObjectOfType<Generators> ();
		gens.Generate (gameObject);
		encounter.NewReaction += Encounter_NewReaction;
		foreach (var reaction in encounter.reactProtos)
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

        var ename = encounter.GetComponent<Named>();
        Name = ename.FullName;
        ename.Updated += () => Name = ename.FullName;
	}

	void Encounter_NewReaction (GameObject reaction)
	{
        GameObject uiGO = GameObject.Instantiate(ReactionPrefab);
        if (reaction != null)
            uiGO.name = reaction.name + "_ui_reaction";
        else
            uiGO.name = "deafult_ui_reaction";

        if(reaction != null)
        {
            var uiObject = uiGO.AddComponent<UiObject>();
            uiObject.ShowedObject = reaction;
        }
		else
        {
            var textField = uiGO.AddComponent<TextField>();
            textField.text.alignment = TextAnchor.MiddleCenter;
            textField.Show("OK");
        }

		var reactButton = uiGO.GetComponent<ReactionButton> ();
		reactButton.Proto = reaction;

		uiGO.transform.SetParent (ReactionsList);
		gens.Generate (uiGO);
	}
}

