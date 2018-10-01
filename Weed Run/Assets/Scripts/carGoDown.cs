using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carGoDown : MonoBehaviour {

	public float velocity, direction;
    public bool goDown, randomized;

    void Start()
    {
        goDown = true;
        randomized = false;
    }

    void Update()
    {
        if (goDown)
            this.transform.Translate(0, -velocity * 0.5f, 0);
        else
        {
            if (!randomized)
                StartCoroutine(randomizeDirection());

            this.transform.Translate(direction, velocity * 3, 0);
        }
    }

    IEnumerator randomizeDirection()
    {
        yield return new WaitForSeconds(0);
        direction = Random.Range(-0.5f, 0.5f);
        randomized = true;

    }

}
