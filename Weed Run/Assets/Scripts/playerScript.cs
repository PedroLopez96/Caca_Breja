using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {

	public static int coins, coinsEver, playerLevel, beerQty;
	public static float distanceWalked, distanceEver, highScore;
	public static bool isDead, highMode;
	public GameObject smokeSprite, highParticle;
	
	void Start()
	{
		playerData.Load ();
		isDead = false;
        highMode = false;
        coins = 0;
		distanceWalked = 0;
        beerQty = 0;
	}

	void Update()
	{

        if (beerQty == 3)
        {
            StartCoroutine(highModeTime());
        }
    }
		


	private IEnumerator highModeTime()
	{
		GameObject[] beers = GameObject.FindGameObjectsWithTag ("Beer");
		for (int i = 0; i < beers.Length; i++)
			Destroy (beers [i]);
		
		highMode = true;
		beerQty = 0;
		GetComponent<AudioSource> ().enabled = false;
        GameObject.Find("drunkMode_TEXT").GetComponent<Animator>().SetBool("gotDrunk", true);
		yield return new WaitForSecondsRealtime(7.5f);
		highMode = false;
		GameObject.Find("drunkMode_TEXT").GetComponent<Animator>().SetBool("gotDrunk", false);
        GameObject.Find("Canvas").GetComponentInChildren<Animator>().Rebind();
		smokeSprite.SetActive (false);
		highParticle.SetActive (false);
	}


}
