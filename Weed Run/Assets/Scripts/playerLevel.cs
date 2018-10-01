using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerLevel : MonoBehaviour {

	public float constant = 0.2f;
	public GameObject bronze, silver, gold, platinum;

	public void getLevel(){
		float xp = playerScript.distanceEver;
		float lvl;

		lvl = constant * Mathf.Sqrt (xp);
		playerScript.playerLevel = (int)lvl;

		if (SceneManager.GetActiveScene ().name == "menu")
			setRank ();

	}

	public void setRank(){
		int lvl = playerScript.playerLevel;

		if (lvl >= 0 && lvl < 10) {
			bronze.SetActive (true);
		} else if (lvl >= 10 && lvl < 25) {
			silver.SetActive (true);
		} else if (lvl >= 25 && lvl < 40) {
			gold.SetActive (true);
		} else if (lvl >= 40) {
			platinum.SetActive (true);
		}
	}

}
