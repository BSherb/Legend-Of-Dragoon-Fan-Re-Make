using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour 
{
	private BasePlayer newPlayer;
	private bool isDartClass;
	private bool isRoseClass;
	private bool isShanaClass;
	private bool isLavitzClass;
	private string playerName = "Enter Name";

	// Use this for initialization
	void Start () 
	{
		newPlayer = new BasePlayer ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnGUI()
	{
		playerName = GUILayout.TextArea(playerName);
		isDartClass = GUILayout.Toggle (isDartClass, "Dart");
		isRoseClass = GUILayout.Toggle (isRoseClass, "Rose");
		isShanaClass = GUILayout.Toggle (isShanaClass, "Shana");
		isLavitzClass = GUILayout.Toggle (isLavitzClass, "Lavitz");
		if(GUILayout.Button("Choose"))
		{
			if(isDartClass)
			{
				newPlayer.PlayerClass = new BaseDartClass();
			}
				else if (isRoseClass)
				{
					newPlayer.PlayerClass = new BaseRoseClass();
				}
				else if (isLavitzClass)
				{
					newPlayer.PlayerClass = new BaseLavitzClass();
				}
				else if (isShanaClass)
				{
					newPlayer.PlayerClass = new BaseShanaClass();
				}
				newPlayer.PlayerLevel = 1;
				newPlayer.HP = newPlayer.PlayerClass.HP;
				newPlayer.ATK = newPlayer.PlayerClass.ATK;
				newPlayer.DEF = newPlayer.PlayerClass.DEF;
				newPlayer.MATK = newPlayer.PlayerClass.MATK;
				newPlayer.MDEF = newPlayer.PlayerClass.MDEF;
				newPlayer.Speed = newPlayer.PlayerClass.Speed;
				newPlayer.PlayerName = playerName;
				SaveInformation.SaveAllInformation ();

			Debug.Log ("Player Name: " + newPlayer.PlayerName);
			Debug.Log ("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
			Debug.Log ("Player Level: " + newPlayer.PlayerLevel);
			Debug.Log ("Player HP: " + newPlayer.HP);
			Debug.Log ("Player ATK: " + newPlayer.ATK);
			Debug.Log ("Player DEF: " + newPlayer.DEF);
			Debug.Log ("Player MATK: " + newPlayer.MATK);
			Debug.Log ("Player MDEF: " + newPlayer.MDEF);
			Debug.Log ("Player Speed: " + newPlayer.Speed);

		}
	}
}
