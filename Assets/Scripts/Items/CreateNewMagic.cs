using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewMagic : MonoBehaviour 
{
	private BaseMagic newMagic;

/*	
	void Start()
	{
		CreateEquipmentBandana ();
		Debug.Log (newMagic.ItemName);
		Debug.Log (newMagic.ItemDescription);
		Debug.Log (newMagic.ItemID.ToString());
		Debug.Log (newMagic.SpellEffectID.ToString());
	}
*/

	// Use this for initialization
	void Start () 
	{
		
	}

	private void CreateMagic()
	{
		newMagic = new BaseMagic();
		newMagic.ItemName = "Magic";
		newMagic.ItemDescription = "This is a Magic Spell";
		newMagic.ItemID = 97;
		newMagic.SpellEffectID = 99;
	}
}