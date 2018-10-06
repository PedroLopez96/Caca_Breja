using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hudBeers : MonoBehaviour {

    public int qtyBeers;
    public GameObject[] allBeers;
    public Sprite beer;

    public void addBeer()
    {
        qtyBeers++;
        playerScript.beerQty++;
        
        allBeers[qtyBeers - 1].SetActive(true);

        if (qtyBeers == 3) // SE 3 BREJAS
            allBeers[0].GetComponent<startAnimBeer>().drinkIt(); // COMEÇA A BEBER O PRIMEIRO COPO

    }

    public void clearBeers()
    {
        qtyBeers = 0;

         for(int i = 0; i < allBeers.Length; i++)
        {
            allBeers[i].SetActive(false);
            allBeers[i].GetComponent<Animator>().Rebind();
            allBeers[i].GetComponent<SpriteRenderer>().sprite = beer;
        }
        
      
    }
	
}
