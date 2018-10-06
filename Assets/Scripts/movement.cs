using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movement : MonoBehaviour {
	
	public float velocity = 0.004f;
	public float lane1 = -1.7f, lane2 = 1.47f;
	private Touch initialTouch = new Touch();
	Animator animPlayer;

	void Start()
	{
		animPlayer = this.GetComponent<Animator> ();
	}

	void Update () 
	{
		if (Input.GetMouseButtonDown(0) && !playerScript.isDead) {
            
			if (transform.position.x <= lane1)
				animPlayer.SetTrigger ("go_right");

			if (transform.position.x >= lane2)
            {
                animPlayer.SetTrigger ("go_left");
            }
        }

		foreach (Touch t in Input.touches) 
		{
			print ("touch");
			if (t.phase == TouchPhase.Began && !playerScript.isDead)
			{
				initialTouch = t;

				if (this.transform.position.x <= lane1)
					animPlayer.SetTrigger ("go_right");

				if (this.transform.position.x >= lane2)
					animPlayer.SetTrigger ("go_left");
			}


			else if (t.phase == TouchPhase.Ended) 
			{
				initialTouch = new Touch ();
				animPlayer.ResetTrigger ("go_right");
				animPlayer.ResetTrigger ("go_left");
			}


		}


	}
		
}
