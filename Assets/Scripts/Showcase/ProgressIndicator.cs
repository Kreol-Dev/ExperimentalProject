using UnityEngine;
using System.Collections;

public struct ProgressIndicator
{

	int maxProgress;
	int curProgress;

	public int CurProgress {
		get { return curProgress; }
		set
		{
			curProgress = value;
			if (CurProgressUpdated != null)
				CurProgressUpdated (curProgress);
		}
	}

	public int MaxProgress {
		get { return maxProgress; }
		set
		{
			maxProgress = value;
			if (MaxProgressResolved != null)
				MaxProgressResolved (maxProgress);
		}
	}

	public delegate void IntDelegate (int value);

	public event IntDelegate MaxProgressResolved;
	public event IntDelegate CurProgressUpdated;
}

