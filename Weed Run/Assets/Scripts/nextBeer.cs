using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextBeer : MonoBehaviour {

    hudBeers _hudBeers;

    private void Start()
    {
        _hudBeers = GameObject.Find("Screen").GetComponent<hudBeers>();
    }

    public void next()
    {
        if (transform.name == "hudBeer1")
            GameObject.Find("hudBeer2").GetComponent<startAnimBeer>().drinkIt();
        else if (transform.name == "hudBeer2")
            GameObject.Find("hudBeer3").GetComponent<startAnimBeer>().drinkIt();
        else if (transform.name == "hudBeer3")
            _hudBeers.clearBeers();

    }
}
