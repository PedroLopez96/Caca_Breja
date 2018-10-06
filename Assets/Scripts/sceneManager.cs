using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneManager : MonoBehaviour {

	public GameObject pnlLevel, pnlSettings;

	public void playButton()
	{
		SceneManager.LoadScene ("runner");
	}

	public void menuButton()
	{
		SceneManager.LoadScene ("menu");
	}

	public void showLevel()
	{
		pnlLevel.SetActive (true);
	}

	public void hideLevel()
	{
		pnlLevel.SetActive (false);
	}

	public void showSettings()
	{
		pnlSettings.SetActive (true);
	}

	public void hideSettings()
	{
		pnlSettings.SetActive (false);
	}

}

