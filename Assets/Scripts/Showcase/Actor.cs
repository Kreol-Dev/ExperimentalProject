using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour
{
    static Story Story;
    public bool IsActive { get; internal set; }
    void Awake()
    {
        if (Story == null)
            Story = FindObjectOfType<Story>();
        Story.Actors.Add(this.gameObject);
    }
        
}
