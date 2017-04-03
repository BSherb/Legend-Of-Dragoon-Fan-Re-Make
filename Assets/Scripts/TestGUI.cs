using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour 
{
	private BaseCharacterClass class1 = new BaseDartClass();
	private BaseCharacterClass class2 = new BaseRoseClass();
	private BaseCharacterClass class3 = new BaseLavitzClass();
	private BaseCharacterClass class4 = new BaseShanaClass();

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	//GUI On
	void OnGUI() 
	{
		GUILayout.Label (class1.CharacterClassName);
		GUILayout.Label (class1.CharacterClassDescription);
		GUILayout.Label (class1.HP.ToString());

		GUILayout.Label (class2.CharacterClassName);
		GUILayout.Label (class2.CharacterClassDescription);
		GUILayout.Label (class2.HP.ToString());

		GUILayout.Label (class3.CharacterClassName);
		GUILayout.Label (class3.CharacterClassDescription);
		GUILayout.Label (class3.HP.ToString());

		GUILayout.Label (class4.CharacterClassName);
		GUILayout.Label (class4.CharacterClassDescription);
		GUILayout.Label (class4.HP.ToString());
	}

}