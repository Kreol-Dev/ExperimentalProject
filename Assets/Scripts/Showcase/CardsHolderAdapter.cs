using UnityEngine;
using System.Collections;

public abstract class CardsHolderAdapter<T> : MonoBehaviour
{
	CardsHolder holder;
	public T Container;

	void Awake ()
	{
		holder = GetComponent<CardsHolder> ();
		holder.CardDropped = OnCardDropped;
		holder.CardRemoved += OnCardRemoved;

	}

	protected abstract bool OnCardDropped (Card card);

	protected abstract void OnCardRemoved (Card card);
}

