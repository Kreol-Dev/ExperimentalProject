using UnityEngine;
using System.Collections;

public class Space : MonoBehaviour, ILoadable
{
	public event VoidDelegate Loaded;

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
		bool stop = false;
		int times = (int)(sizeX / radius) * (int)(sizeY / radius);
		for (float x = -(sizeX + radius / 2); x < (sizeX - radius / 2) && !stop; x += radius)
		{
			for (float y = -(sizeY + radius / 2); y < (sizeY - radius / 2) && !stop; y += radius)
			{

				var pos = (Vector2)cachedTransform.position + new Vector2 (x, y);
				int count = Physics2D.OverlapCircleNonAlloc (pos, radius, colliders);
				if (count == 0)
				{
					if (!found)
					{
						goTransform.position = pos;
						found = true;
					} else
					{
						if (random.Next (0, 2) > 0)
							goTransform.position = pos;
						stop |= random.Next (0, times) == 0;
					}
				}
			}
			yield return null;
		}
		if (found)
		{
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
