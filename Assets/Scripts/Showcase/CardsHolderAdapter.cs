using UnityEngine;
using System.Collections;

public abstract class CardsHolderAdapter<T> : MonoBehaviour
{
	CardsHolder holder;
	public T Container;

	void Start ()
	{
		holder = GetComponent<CardsHolder> ();
		holder.CardDropped = OnCardDropped;
		holder.CardRemoved += OnCardRemoved;
		Init ();
	}

	protected virtual void Init ()
	{
	}


	protected abstract bool OnCardDropped (Card card);

	protected abstract void OnCardRemoved (Card card);
}

