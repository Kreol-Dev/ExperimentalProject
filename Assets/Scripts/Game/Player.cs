using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public bool Updated { get; internal set; }

	float army = 50;

	public float Army {
		get { return army; }
		set
		{
			army = value;
			Updated = true;
		}
	}

	float church = 50;

	public float Church {
		get { return church; }
		set
		{
			church = value;
			Updated = true;
		}
	}

	float people = 50;

	public float People {
		get { return people; }
		set
		{
			people = value;
			Updated = true;
		}
	}

	float money = 50;

	public float Money {
		get { return money; }
		set
		{
			money = value;
			Updated = true;
		}
	}

	void Awake ()
	{
		Updated = false;
	}

	void FixedUpdate ()
	{
		Updated = false;
	}

}
