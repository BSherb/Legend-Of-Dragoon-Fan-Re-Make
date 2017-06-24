using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour 
{
	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	public static string PlayerName{ get; set;}
	public static int PlayerLevel{ get; set;}
	//public static string BaseCharacterClass PlayerClass{ get; set;}
	public static float HP{ get; set;}
	public static float ATK{ get; set;}
	public static float DEF{ get; set;}
	public static float MATK{ get; set;}
	public static float MDEF{ get; set;}
	public static float Speed{ get; set;}

}
