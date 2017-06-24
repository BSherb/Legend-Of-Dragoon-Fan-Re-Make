using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation
{
	public static void LoadAllInformation()
	{
		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.HP = PlayerPrefs.GetFloat ("HP");
		GameInformation.ATK = PlayerPrefs.GetFloat ("ATK");
		GameInformation.DEF = PlayerPrefs.GetFloat ("DEF");
		GameInformation.MATK = PlayerPrefs.GetFloat ("MATK");
		GameInformation.MDEF = PlayerPrefs.GetFloat ("MDEF");
		GameInformation.Speed = PlayerPrefs.GetFloat ("SPEED");
	}
}
