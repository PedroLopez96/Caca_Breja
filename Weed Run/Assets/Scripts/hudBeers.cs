using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hudBeers : MonoBehaviour {

    public int qtyBeers;
    public GameObject[] allBeers;

    public void addBeer()
    {
        qtyBeers++;
        playerScript.beerQty++;

        allBeers[qtyBeers - 1].SetActive(true);
        
        if(qtyBeers == 3)
            allBeers[0].GetComponent<startAnimBeer>().drinkIt();

    }

    public void clearBeers()
    {
        for (int i = 0; i <= allBeers.Length; i++)
            allBeers[i].SetActive(false);
    }
	
}
