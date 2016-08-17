using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{

	public Text Church;
	public Text People;
	public Text Army;
	public Text Money;
	public Player Player;

	void Start ()
	{
		Church.text = Player.Church.ToString ();
		People.text = Player.People.ToString ();
		Army.text = Player.Army.ToString ();
		Money.text = Player.Money.ToString ();
	}

	void Update ()
	{
		if (Player.Updated)
		{
			Church.text = Player.Church.ToString ();
			People.text = Player.People.ToString ();
			Army.text = Player.Army.ToString ();
			Money.text = Player.Money.ToString ();
		}
	}
}

