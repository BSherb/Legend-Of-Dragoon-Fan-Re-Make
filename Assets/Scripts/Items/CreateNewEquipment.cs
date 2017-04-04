using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour 
{
	private BaseEquipment newEquipment;

/*	
	void Start()
	{
		CreateEquipmentBandana ();
		Debug.Log (newEquipment.ItemName);
		Debug.Log (newEquipment.ItemDescription);
		Debug.Log (newEquipment.ItemID.ToString());
		Debug.Log (newEquipment.WeaponType);
		Debug.Log (newEquipment.DEF.ToString());
		Debug.Log (newEquipment.MDEF.ToString());
		Debug.Log (newEquipment.MATK.ToString());
	}
*/

	public void CreateEquipmentBandana ()
	{
		newEquipment = new BaseEquipment ();
		//Assign Name
		newEquipment.ItemName = "Bandana";
		//Description
		newEquipment.ItemDescription = "A small cloth bandana used for protection.";
		//ID
		newEquipment.ItemID = 26;
		//Stats
		newEquipment.DEF = 0;
		newEquipment.MATK = 3;
		newEquipment.MDEF = 0;
		//Type
		newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}
}
