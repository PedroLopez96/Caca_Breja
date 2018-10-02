using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAnimBeer : MonoBehaviour {

    Animator thisAnim;

	void Start () {
        thisAnim = GetComponent<Animator>();
	}

    public void drinkIt()
    {
        thisAnim.SetBool("drink", true);
    }
	

}
