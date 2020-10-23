using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; 

public class Serializare : MonoBehaviour {
	public GameObject player;
	static readonly string FISIER_STOCARE_JSON = "STOCARE_JSON.json";
	public GameObject go;
	void Start(){
	//	LoadDataPlayer ();
	}
	void Update(){
	
	}
	void OnApplicationQuit(){
	//	SaveDataPlayer ();
	}


	public void SaveDataPlayer(){

		SaveData data = new SaveData () {
			name = "Hero",
			experience = go.GetComponent<playerEXP>().experience,
			level= go.GetComponent<playerEXP>().levelText.text,
			position=player.transform.position,
			rotation=player.transform.rotation
		};
		string json=JsonUtility.ToJson(data);


		//consction string

		string filename=Path.Combine (Application.persistentDataPath,FISIER_STOCARE_JSON);


		//trimitere catre FISIER_STOCARE_JSON
		//if(File.Exists(filename)){
		//File.Delete (filename);
		//	}
		File.WriteAllText (filename, json);


		//aflam unde a fost salvat
		Debug.Log ("Exemplu serializare, fisier primit in" + filename);


		//Deserializare
		string jsonFromFile=File.ReadAllText(filename);



	}

	public void LoadDataPlayer(){

		string filename=Path.Combine (Application.persistentDataPath,FISIER_STOCARE_JSON);
		if (File.Exists (filename)) {
			string dataAsJson = File.ReadAllText (filename);
			//deserializare
			SaveData copy = JsonUtility.FromJson<SaveData> (dataAsJson);
			Debug.Log ("Exemplu deserializare"+copy.name);
			player.transform.position = copy.position;
			player.transform.rotation = copy.rotation;
			player.transform.GetComponent<playerEXP> ().experience = copy.experience;
			player.transform.GetComponent<playerEXP> ().levelText.text = copy.level;

		}

	}
}