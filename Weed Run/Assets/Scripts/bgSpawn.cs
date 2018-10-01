using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class bgSpawn : MonoBehaviour {

	public GameObject bg, deadText;
	public static float yCurrent;
	public float velocity = 0.09f;
	public float timeElapsed, multiplier, speedUpTime;
	public Text coinsNumber, score, highscore;

	void Start () {
		yCurrent = 0;
		multiplier = 1;

	}

	void Update () {

		coinsNumber.GetComponent<Text> ().text =  playerScript.coins.ToString();
		speedUpTime -= Time.deltaTime * 100;

			// MOVIMENTAÇÃO DA CÂMERA E DISTANCIA PERCORRIDA 
		if (speedUpTime <= 0 && multiplier <= 1.8f) {
			multiplier *= 1.05f;
			this.transform.Translate (new Vector2 (0, velocity * multiplier));
			playerScript.distanceWalked += velocity;
			speedUpTime = 500;
		} else {
			this.transform.Translate (new Vector2 (0, velocity * multiplier));
			playerScript.distanceWalked += velocity;
		}
			


		//	INSTANCIAÇÃO DE BACKGROUND
		Vector3 rayOrigin = Camera.main.ViewportToWorldPoint (new Vector3 (0.3f,0,0.3f));
		RaycastHit hit;

		if (Physics.Raycast (rayOrigin, Camera.main.transform.forward, out hit, 100)) {
			yCurrent += 24;
			Instantiate (bg, new Vector2(0, yCurrent) , Quaternion.identity);
			hit.transform.GetComponent<BoxCollider> ().enabled = false;

		}

	}

	public void gameOver()
	{		
		highscore.GetComponent<Text> ().text = "Recorde: " + playerScript.highScore.ToString("F1");	
		score.GetComponent<Text> ().text = "Metros: " + playerScript.distanceWalked.ToString("F1");
		velocity = 0;
		deadText.SetActive (true);
	}

	public void resetGame()
	{
		Destroy(GameObject.Find ("Morreu"));
		SceneManager.LoadScene ("runner");
	}

}
