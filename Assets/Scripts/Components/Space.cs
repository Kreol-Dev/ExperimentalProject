using UnityEngine;
using System.Collections;

public class Space : MonoBehaviour
{
	static Vector3 OutPosition = new Vector3 (0, -10000, 0);
	Transform cachedTransform;
	static System.Random random = new System.Random (0);
	public Vector2 Size;

	void Awake ()
	{
		cachedTransform = transform;
	}

	public void Place (GameObject go)
	{
		var goTransform = go.GetComponent<Transform> ();
		var goCircle = go.GetComponent<CircleCollider2D> ();

		//goBody.Swee
		goTransform.position = OutPosition;
		StartCoroutine (FindPlaceCoroutine (goCircle.radius, goTransform));
		//Physics.BoxCastNonAlloc()
	}

	Collider2D[] colliders = new Collider2D[1];

	public IEnumerator FindPlaceCoroutine (float radius, Transform goTransform)
	{

		Debug.Log ("Finding place");
		float sizeX = Size.x;
		float sizeY = Size.y;
		bool found = false;
		Vector3 position = OutPosition;
		for (float x = -sizeX / 2; x < sizeX / 2; x += radius)
		{
			for (float y = -sizeY / 2; y < sizeY / 2; y += radius)
			{

				var pos = (Vector2)cachedTransform.position + new Vector2 (x, y);
				int count = Physics2D.OverlapCircleNonAlloc (pos, radius, colliders);
				if (count == 0)
				{
					if (!found)
					{

						position = pos;
						found = true;
					} else
					{
						if (random.Next (0, 2) > 0)
							position = pos;
						if (random.Next (0, 5) > 0)
							break;
					}
				}
			}
			yield return null;
		}
		if (found)
		{
			goTransform.position = position;
			Debug.Log ("Place has been found");
		} else
		{
			Debug.Log ("Place hasn't been found");
		}
	}

	void OnDrawGizmos ()
	{
		if (!Application.isPlaying)
		{
			Vector3 point1 = transform.TransformPoint (new Vector3 (Size.x, Size.y));

			Vector3 point2 = transform.TransformPoint (new Vector3 (-Size.x, Size.y));

			Vector3 point3 = transform.TransformPoint (new Vector3 (-Size.x, -Size.y));

			Vector3 point4 = transform.TransformPoint (new Vector3 (Size.x, -Size.y));
			Gizmos.DrawLine (point1, point2);
			Gizmos.DrawLine (point2, point3);
			Gizmos.DrawLine (point3, point4);
			Gizmos.DrawLine (point4, point1);
		} else
		{
			Vector3 point1 = cachedTransform.TransformPoint (new Vector3 (Size.x, Size.y));

			Vector3 point2 = cachedTransform.TransformPoint (new Vector3 (-Size.x, Size.y));

			Vector3 point3 = cachedTransform.TransformPoint (new Vector3 (-Size.x, -Size.y));

			Vector3 point4 = cachedTransform.TransformPoint (new Vector3 (Size.x, -Size.y));
			Gizmos.DrawLine (point1, point2);
			Gizmos.DrawLine (point2, point3);
			Gizmos.DrawLine (point3, point4);
			Gizmos.DrawLine (point4, point1);
		}


	}
}
