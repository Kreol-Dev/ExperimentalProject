using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	UiObject uiObject;
	public bool Movable;

	public GameObject ShowedObject { get { return uiObject.ShowedObject; } set { uiObject.ShowedObject = value; } }

	public RectTransform ReturnToParent;
	RectTransform transform;
	public CardsHolder currentHolder;

	void Awake ()
	{
		uiObject = gameObject.GetComponent<UiObject> ();
		transform = gameObject.GetComponent<RectTransform> ();
	}

	void Start ()
	{
		if (currentHolder == null)
			currentHolder = transform.parent.GetComponentInParent<CardsHolder> ();
	}

	bool dragged = false;
	Vector2 preDragPivot;

	public void OnBeginDrag (PointerEventData eventData)
	{
		if (!Movable)
			return;
		dragged = true;
		ReturnToParent = transform.parent.GetComponent<RectTransform> ();

		Debug.LogFormat ("{0} parent is now {1}, where holder is {2} and it's dragoverzone is {3}", this, transform.parent, currentHolder, currentHolder.DragOverZone);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
		if (rotValue == 0)
			preDragPivot = transform.pivot;
		Vector2 dragPivot;
		if (!RectTransformUtility.ScreenPointToLocalPointInRectangle (
			    transform, eventData.position, eventData.pressEventCamera, out dragPivot))
			return;
		float tallK = transform.rect.height / transform.rect.width;
		maxRot = tallK * maxRotK;
		decayRotSpeed = tallK * decayRotSpeedK;
		rotSpeed = tallK * rotSpeedK;
		dragPivot.x = dragPivot.x / transform.rect.width;
		dragPivot.y = dragPivot.y / transform.rect.height;
		transform.pivot = dragPivot;
		transform.SetParent (currentHolder.DragOverZone);
//		Vector2 dragPos = eventData.position;
//		if (!RectTransformUtility.ScreenPointToLocalPointInRectangle (
//			    ReturnToParent, eventData.position, eventData.pressEventCamera, out dragPos))
//			return;
//		transform.position = new Vector3 (dragPos.x, dragPos.y, transform.localPosition.z);
	}

	float decayRotSpeed;
	float rotSpeedK = 1;
	float decayRotSpeedK = 2;
	float rotSpeed;
	float rotValue = 0;
	float maxRotK = 5;
	float maxRot;
	bool lastMoved = false;

	public void OnDrag (PointerEventData eventData)
	{
		if (!Movable)
			return;
		float dx = eventData.delta.x;
		if (dx > 0)
			rotValue -= 1;
		else if (!Mathf.Approximately (dx, 0f))
			rotValue += 1;
		if (rotValue > 15)
			rotValue = 15;
		else if (rotValue < -15)
			rotValue = -15;
		lastMoved = !Mathf.Approximately (eventData.delta.sqrMagnitude, 0f);
		Vector2 dragPos = eventData.position;
		if (!RectTransformUtility.ScreenPointToLocalPointInRectangle (
			    currentHolder.DragOverZone, eventData.position, eventData.pressEventCamera, out dragPos))
			return;
		transform.localPosition = dragPos;
		//transform.position = eventData.position;
		//transform.position += (Vector3)eventData.delta;
	}

	public void OnEndDrag (PointerEventData eventData)
	{
		if (!Movable)
			return;
		dragged = false;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		transform.SetParent (ReturnToParent);
	}

	public void CancelDrag ()
	{
		Debug.Log ("Canceled");
		transform.SetParent (ReturnToParent);
	}

	public void AcceptDrag (CardsHolder cardsHolder)
	{
		Debug.Log ("Accepted");
		currentHolder.CardRemove (this);
		currentHolder = cardsHolder;
		transform.SetParent (cardsHolder.gameObject.transform);
		ReturnToParent = transform.parent.GetComponent<RectTransform> ();
	}

	void Update ()
	{
		if (!lastMoved)
		if (rotValue > 0)
			rotValue -= 0.3f * rotSpeed * Mathf.InverseLerp (0, maxRot, rotValue);
		else if (!Mathf.Approximately (rotValue, 0f))
			rotValue += 0.3f * rotSpeed * Mathf.InverseLerp (0, -maxRot, rotValue);
		
		if (!dragged)
		{
			if (rotValue > 0)
				rotValue -= decayRotSpeed;
			else if (!Mathf.Approximately (rotValue, 0f))
				rotValue += decayRotSpeed;
			if (rotValue < decayRotSpeed)
			{
				rotValue = 0;

				transform.pivot = preDragPivot;
				return;
			}
		}
		transform.localRotation = Quaternion.Euler (new Vector3 (0, 0, rotValue));
		lastMoved = false;
	}
}