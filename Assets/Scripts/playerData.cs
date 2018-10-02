using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


public class playerData : MonoBehaviour {


	void Start () {
		DontDestroyOnLoad (gameObject);
		this.GetComponent<playerLevel> ().getLevel ();
	}
	
	public static void Save()
	{
		try 
		{
			BinaryFormatter bf = new BinaryFormatter ();

			FileStream file =  new FileStream(Application.persistentDataPath + "/playerData.dat", FileMode.OpenOrCreate);

			PlayerData data = new PlayerData ();

			data.coins = playerScript.coinsEver + playerScript.coins;
			data.score = playerScript.distanceEver + playerScript.distanceWalked;
			data.highScore = playerScript.highScore;

			print("Data: "+data.highScore+"\nPlayer: "+playerScript.highScore);
		

			bf.Serialize (file, data);
			file.Close();

			Load();

		}
		catch (System.Exception e) {
			Debug.Log (e);
		}
			
	}


	public static void Load()
	{
		
		if (File.Exists (Application.persistentDataPath + "/playerData.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/playerData.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);

			playerScript.coinsEver = data.coins;
			playerScript.distanceEver = data.score;
			playerScript.highScore = data.highScore;

			file.Close ();

		} else {
			print ("Arquivo não existente");
		}
	}

	public void Delete()
	{
		File.Delete(Application.persistentDataPath + "/playerData.dat");

	}

}


[Serializable]

class PlayerData
{
	//public string name;
	public float score, highScore=0;
	public int coins;
	//public bool first;
}
