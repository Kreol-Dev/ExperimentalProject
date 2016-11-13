using UnityEngine;
using System.Collections;

public class WinLoseManager : MonoBehaviour
{

    public void Win(string why)
    {
        var e = new GameObject("win");
        e.AddComponent<WinEvent>().Why = why;
        e.AddComponent<Encounter>();
        e.AddComponent<Markers>();
        e.AddComponent<Entity>();
        e.AddComponent<Named>().Set("main_name", 0, "You won");
        FindObjectOfType<Generators>().Generate(e);
    }

    public void Lose(string why)
    {
        var e = new GameObject("lost");
        e.AddComponent<LostEvent>().Why = why;
        e.AddComponent<Encounter>();
        e.AddComponent<Markers>();
        e.AddComponent<Entity>();
        e.AddComponent<Named>().Set("main_name", 0, "You lost");
        FindObjectOfType<Generators>().Generate(e);
    }

    public void Notify(string ofWhat)
    {
        var e = new GameObject("notification");
        e.AddComponent<NotifyEvent>().OfWhat = ofWhat;
        e.AddComponent<Encounter>();
        e.AddComponent<Markers>();
        e.AddComponent<Entity>();
        e.AddComponent<Named>().Set("main_name", 0, "You've got mail!");
        FindObjectOfType<Generators>().Generate(e);
    }

    void Awake()
    {
        FindObjectOfType<BasicLoader>().EFunctions.Add(new BasicLoader.ExternalFunctions(this, "Win", "Lose"));
    }
}


public class WinEvent : MonoBehaviour
{
    public string Why { get; set; }
}

public class LostEvent : MonoBehaviour
{
    public string Why { get; set; }
}

public class NotifyEvent : MonoBehaviour
{
    public string OfWhat { get; set; }
}