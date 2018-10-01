using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDestroy : MonoBehaviour {
	
	public int time;

	void Start () {
		StartCoroutine (destroyMe ());
	}

	private IEnumerator destroyMe()
	{
		yield return new WaitForSecondsRealtime (time);
		Destroy (this.gameObject);
	}
}
