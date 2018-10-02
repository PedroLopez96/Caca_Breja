using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionEnter : MonoBehaviour {

	public GameObject beer, cop;
	public AudioClip itemPick, coinPick, hitSound;
	public bgSpawn myBgSpawn;
    public hudBeers _hudBeers;

    public void Start()
    {
        _hudBeers = GameObject.Find("Screen").GetComponentInChildren<hudBeers>();
    }

    void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Enemy") 
		{
            if (playerScript.highMode)
                collision.GetComponent<carGoDown>().goDown = false;
            else
            {
                if (playerScript.distanceWalked > playerScript.highScore)
                    playerScript.highScore = playerScript.distanceWalked;
                playerData.Save();
                playerScript.isDead = true;
                myBgSpawn.gameOver();
                GetComponent<Animator>().SetTrigger("isDead");
                GetComponent<AudioSource>().PlayOneShot(hitSound);
                GetComponent<BoxCollider2D>().enabled = false;
                cop.GetComponent<Animator>().SetTrigger("isIdle");

                GameObject[] streets = new GameObject[10];
                streets = GameObject.FindGameObjectsWithTag("street");

                for (int i = 0; i < streets.Length; i++)
                {
                    streets[i].GetComponent<autoDestroy>().enabled = false;
                }
            }
	
		}


		if (collision.gameObject.tag == "Coin") 
		{
			if (!playerScript.highMode) 
				playerScript.coins += 1;
			else
				playerScript.coins += 2;

			Destroy (collision.gameObject);
			GetComponent<AudioSource> ().PlayOneShot (coinPick);
		}


		if (collision.gameObject.tag == "Beer") 
		{
			GetComponent<AudioSource> ().PlayOneShot (itemPick);
			Destroy (collision.gameObject);
            _hudBeers.addBeer();
		}
  
	}

}
