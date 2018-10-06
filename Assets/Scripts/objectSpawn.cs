using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawn : MonoBehaviour {

	public GameObject[] coinPrefab = new GameObject[3];
    public GameObject paper;
	private float[] positions = new float[2];
	int offset;

	void Start () {
		positions [0] = -1.7f;
		positions [1] = 1.47f;

		StartCoroutine (spawnCoin ());
		StartCoroutine (spawnItem ());	
	}

	private IEnumerator spawnCoin()
	{
		int coinNum = Random.Range (0, 3);			// PROBABILIDADE DE PREFAB DE COINS SER SPAWNED

		Instantiate (coinPrefab [coinNum], new Vector3 (coinPrefab [coinNum].transform.position.x, this.transform.position.y + 4, -1), Quaternion.identity); 
		yield return null;
	}

	private IEnumerator spawnItem()
	{

        offset = Random.Range(0, 4);
		if (playerScript.highMode == false) {
			
			int itemProb = Random.Range (0, 1); 		// PROBABILIDADE DE ALGUM ITEM SPAWN

			if (itemProb == 0) { 
					
			Instantiate (paper, new Vector3 (positions [Random.Range (0, 2)], this.transform.position.y + offset, -1), Quaternion.identity);
	
			yield return new WaitForSecondsRealtime (0);
			}
		}
	}
}