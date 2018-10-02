using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuPlayerStats : MonoBehaviour {

	public Text name, score, coins, highscore, level;

	void Awake(){
		playerData.Load ();
	}

	void LateUpdate () {
		coins.text = playerScript.coinsEver.ToString ();
		score.text = playerScript.distanceEver.ToString ("F1");
		//name.GetComponent<Text> ().text = playerScript.name;
		highscore.text = playerScript.highScore.ToString ("F1");
		level.text = "Level: " + playerScript.playerLevel.ToString ("F0");
	}
	

}
