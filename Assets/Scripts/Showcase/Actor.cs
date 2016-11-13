using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour
{
    static Story Story;
    public bool IsActive { get; internal set; }
    public bool Generated { get; internal set; }
    void Awake()
    {
        Generated = false;
        if (Story == null)
            Story = FindObjectOfType<Story>();
        Story.Actors.Add(this.gameObject);
        var e = GetComponent<Entity>();
        if(e != null)
        {
            e.Destoryed += go => Story.Actors.Remove(gameObject);
        }
    }

    void Start()
    {
        Generated = true;
    }
    //public GameObject CurrentAction { get; set; }
        
}
