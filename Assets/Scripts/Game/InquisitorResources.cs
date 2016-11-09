using UnityEngine;
using System.Collections;

public class InquisitorResources : MonoBehaviour
{
    [SerializeField]
    int gold = 0;
    public int Gold {  get { return gold; } set { gold = value; if (gold < 0) gold = 0; } }
    [SerializeField]
    int influence = 0;
    public int Influence { get { return influence; } set { influence = value; if (influence < 0) influence = 0; } }
    [SerializeField]
    int sanity = 0;
    public int Sanity { get { return sanity; } set { sanity = value; if (sanity < 0) sanity = 0; } }

    void Awake()
    {
        FindObjectOfType<BasicLoader>().EFunctions.Add(new BasicLoader.ExternalFunctions(this, "Gold", "Influence", "Sanity"));
    }
}
