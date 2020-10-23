using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using System.Data.SqlClient;

public class Connect_db : MonoBehaviour {
	
	private string connectionstring;
	void Start () {
		connectionstring=@"Data Source=127.0.0.1;user id=Diana_Niti;password=asdfghjklzxcvbnm;Initial Catalog=RPG_Game;";
		SqlConnection dbConnection = new SqlConnection(connectionstring);


		try
		{

			dbConnection.Open();
			Debug.Log("Connected to database.");
		}
		catch (SqlException _exception)
		{
			Debug.LogWarning(_exception.ToString());

		}


		//  conn.Close();
	
	
}
	
	void Update () {
		
	}
}
