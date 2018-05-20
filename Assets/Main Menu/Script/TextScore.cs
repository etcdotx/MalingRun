using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class TextScore : MonoBehaviour {
	
	public static TextScore sore;
	public Text hiSoreText;
	public float scoreee;

	void Start () {
		
		if (sore == null) {
				DontDestroyOnLoad (gameObject);
				sore = this;
		} else if (sore != this) {
				Destroy (gameObject);
			}
		Load ();
		}

	void Update () {
		if (Application.loadedLevel == 0) {
			hiSoreText = GameObject.Find ("Higo").GetComponent<Text> ();
		}
		hiSoreText.text = "HIGH SCORE : " + Mathf.Round (scoreee);
		save ();
		
	}

public void save(){
	BinaryFormatter bf = new BinaryFormatter ();
	FileStream file = File.Create (Application.persistentDataPath + "/playerinfo.dat");

	PlayerData data = new PlayerData ();
		data.scoreee = scoreee;

	bf.Serialize (file, data);
	file.Close ();
}

public void Load(){
	if (File.Exists (Application.persistentDataPath + "/playerinfo.dat")) {
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Open (Application.persistentDataPath + "/playerinfo.dat", FileMode.Open);
		PlayerData data = (PlayerData)bf.Deserialize (file);
		file.Close ();

			HighScore.control.highscoree = data.scoreee;
			scoreee = data.scoreee;
	} 
}

[System.Serializable]
class PlayerData{
	public float scoreee;
}
}
