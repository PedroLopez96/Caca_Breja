using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highMode : MonoBehaviour {

	bool isShaking;
	public GameObject topPanel, x2;
	SpriteRenderer panel;
	public Sprite panelSimple, panelItens;
	public AudioClip running, high;

	void Start()
	{
		panel = topPanel.GetComponent<SpriteRenderer> ();
		isShaking = false;
	}

	void Update () {
		if (playerScript.highMode == true) {
			StartCoroutine (startShake ());
			panel.sprite = panelSimple;
			x2.SetActive (true);
		} else {
			StartCoroutine (stopShake ());
			panel.sprite = panelItens;
			x2.SetActive (false);
		}
		
	}

	private IEnumerator playMusic (AudioClip clip)
	{
		yield return new WaitForSecondsRealtime (0);
		GetComponent<AudioSource> ().PlayOneShot (clip);
	}

	private IEnumerator startShake ()
	{
		yield return new WaitForSecondsRealtime (0);
		Camera.main.GetComponent<Animator> ().SetBool ("gotDrunk", true);
	}

	private IEnumerator stopShake ()
	{
		yield return new WaitForSecondsRealtime (0);
		Camera.main.GetComponent<Animator> ().SetBool ("gotDrunk", false);
	}
}
