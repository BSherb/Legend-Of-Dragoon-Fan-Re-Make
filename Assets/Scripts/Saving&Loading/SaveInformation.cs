using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation
{
	public static void SaveAllInformation()
	{
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetFloat ("HP", GameInformation.HP);
		PlayerPrefs.SetFloat ("ATK", GameInformation.ATK);
		PlayerPrefs.SetFloat ("DEF", GameInformation.DEF);
		PlayerPrefs.SetFloat ("MATK", GameInformation.MATK);
		PlayerPrefs.SetFloat ("MDEF", GameInformation.MDEF);
		PlayerPrefs.SetFloat ("SPEED", GameInformation.Speed);
		Debug.Log ("Saved All Information");
	}
}