using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class morreuTextSync : MonoBehaviour {

	public Text txtRecorde, txtMetros;

	void OnEnable () {
		txtRecorde.text = "Recorde: " + playerScript.highScore.ToString ("F1");
		txtMetros.text = "Metros: " + playerScript.distanceWalked.ToString ("F1");
	}

}
