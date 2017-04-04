using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour 
{
	private BasePotion newPotion;

/*	
	void Start()
	{
		CreateEquipmentBandana ();
		Debug.Log (newPotion.ItemName);
		Debug.Log (newPotion.ItemDescription);
		Debug.Log (newPotion.ItemID.ToString());
		Debug.Log (newPotion.PotionType);
	}
*/

	// Use this for initialization
	void Start () 
	{
		
	}

	private void CreatePotion ()
	{
		newPotion = new BasePotion ();
		newPotion.ItemName = "Potion";
		newPotion.ItemDescription = "This is a Potion";
		newPotion.ItemID = 50;
		newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
	}
}
