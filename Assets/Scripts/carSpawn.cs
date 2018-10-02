using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawn : MonoBehaviour {

	public GameObject[] car;
	private float lane1, lane2;

	void Start()
	{
		lane1 = -1.7f;
		lane2 = 1.47f;
		StartCoroutine(spawnCar());
	}

	private IEnumerator spawnCar()
	{
		int randNum = Random.Range (0, 2), carNum = Random.Range(0, 1);
		if(randNum == 0)
			Instantiate (car[carNum], new Vector3 (lane1, this.transform.position.y + 8, -1.5f), Quaternion.identity);
		else if (randNum == 1)
			Instantiate (car[carNum], new Vector3 (lane2, this.transform.position.y + 8, -1.5f), Quaternion.identity);

		yield return new WaitForSecondsRealtime(0);

	}




}
