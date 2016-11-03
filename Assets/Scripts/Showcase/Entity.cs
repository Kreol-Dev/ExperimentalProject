using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public delegate void GODelegate (GameObject entity);
public class Entity : MonoBehaviour
{
    static Entity DeathHandler;
	public Vector3 Position { get { return transform.position; } set { transform.position = value; } }

	public event VoidDelegate ComponentAddedEvent;

	void Awake ()
	{
        if (DeathHandler == null)
            DeathHandler = GameObject.Find("DeathHandler").GetComponent<Entity>();
	}

	public bool Dead { get { return !gameObject.activeInHierarchy;  } }

	public void Destroy ()
	{
        gameObject.SetActive(false);
		DeathHandler.StartCoroutine (DeathCoroutine ());
	}

    static ObjectPool<List<Transform>> pool = new ObjectPool<List<Transform>>();
    public void ClearSiblings()
    {
        var list = pool.Get();
        list.Clear();
        var childrenCount = transform.childCount;
        for ( int i = 0; i < childrenCount; i++)
        {
            var child = transform.GetChild(i);
            child.GetComponentsInChildren<Transform>(list);
            foreach (var t in list)
            {
                t.DetachChildren();
            }
            foreach (var t in list)
            {
                var e = t.GetComponent<Entity>();
                if (e == null)
                    Destroy(t.gameObject);
                else
                    e.Destroy();
            }
            list.Clear();
        }
        transform.DetachChildren();
        pool.Return(list);
    }
	public event GODelegate Destoryed;

	IEnumerator DeathCoroutine ()
	{
		yield return null;
		Debug.Log ("Death " + gameObject, gameObject);
		Event<EntityDeathEvent>.Invoke (gameObject);
		if (Destoryed != null)
			Destoryed (gameObject);
        ClearSiblings();
        yield return null;
		Destroy (gameObject);
	}

	public void ComponentAdded ()
	{
		if (ComponentAddedEvent != null)
			ComponentAddedEvent ();
	}
}


public class EntityDeathEvent : MonoBehaviour
{
	
}

