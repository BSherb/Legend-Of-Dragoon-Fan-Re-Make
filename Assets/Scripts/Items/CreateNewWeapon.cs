using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : MonoBehaviour 
{
	private BaseWeapon newWeapon;

/*	
	void Start()
	{
		CreateWeaponBastardSword ();
		Debug.Log (newWeapon.ItemName);
		Debug.Log (newWeapon.ItemDescription);
		Debug.Log (newWeapon.ItemID.ToString());
		Debug.Log (newWeapon.WeaponType);
		Debug.Log (newWeapon.ATK.ToString());
	}
*/
	//Dart's Weapons

	public void CreateWeaponBroadSword ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "BroadSword";
		//Description
		newWeapon.ItemDescription = "Dart's First Sword, Trained with Master Tasman of Seles, and went on his 5 Year Journey with this blade.";
		//ID
		newWeapon.ItemID = 1;
		//Stats
		newWeapon.ATK = 2;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.HEAVYSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponBastardSword ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Bastard Sword";
		//Description
		newWeapon.ItemDescription = "A sword much more suited to a knight. Recently sharpened as well.";
		//ID
		newWeapon.ItemID = 2;
		//Stats
		newWeapon.ATK = 7;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.HEAVYSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponHeatBlade ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Heat Blade";
		//Description
		newWeapon.ItemDescription = "An ancient blade made to slay ice and water beasts with ease.";
		//ID
		newWeapon.ItemID = 3;
		//Stats
		newWeapon.ATK = 18;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.HEAVYSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = NEEDS FIRE EFFECT
	}

	public void CreateWeaponFalchion ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Falchion";
		//Description
		newWeapon.ItemDescription = "A broad slightly curved sword, with the cutting edge on the convex side.";
		//ID
		newWeapon.ItemID = 4;
		//Stats
		newWeapon.ATK = 26;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.HEAVYSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponMindCrush ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Mind Crush";
		//Description
		newWeapon.ItemDescription = "Meant to destroy the minds of enemies, leaving confusion in it's wake.";
		//ID
		newWeapon.ItemID = 5;
		//Stats
		newWeapon.ATK = 34;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.HEAVYSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = NEEDS CONFUSE EFFECT
	}

	public void CreateWeaponFairySword ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Fairy Sword";
		//Description
		newWeapon.ItemDescription = "A magical sword that grants Dragoons more spirit per strike.";
		//ID
		newWeapon.ItemID = 6;
		//Stats
		newWeapon.ATK = 39;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.HEAVYSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = 50% SP Generation Effect
	}

	public void CreateWeaponClaymore ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Claymore";
		//Description
		newWeapon.ItemDescription = "A very large and powerful sword.";
		//ID
		newWeapon.ItemID = 7;
		//Stats
		newWeapon.ATK = 44;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.HEAVYSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponSoulEater ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Soul Eater";
		//Description
		newWeapon.ItemDescription = "An ancient bastard sword that steals life from it's user for increased power.";
		//ID
		newWeapon.ItemID = 8;
		//Stats
		newWeapon.ATK = 75;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.HEAVYSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = 10% Health loss on turn
	}

	//Lavitz/Albert's Weapons

	public void CreateWeaponSpear ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Spear";
		//Description
		newWeapon.ItemDescription = "A simple steel tipped polearm.";
		//ID
		newWeapon.ItemID = 9;
		//Stats
		newWeapon.ATK = 4;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LANCE;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponLance ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Lance";
		//Description
		newWeapon.ItemDescription = "Usually used for mounted combat. Re-made for sturdy use.";
		//ID
		newWeapon.ItemID = 10;
		//Stats
		newWeapon.ATK = 19;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LANCE;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponTwisterGlaive ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Twister Glaive";
		//Description
		newWeapon.ItemDescription = "A magically imbued Halberd that strikes with wind.";
		//ID
		newWeapon.ItemID = 11;
		//Stats
		newWeapon.ATK = 28;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LANCE;
		//Spell EffectID
		//newWeapon.SpellEffectID = WIND DAMAGE
	}

	public void CreateWeaponGlaive ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Glaive";
		//Description
		newWeapon.ItemDescription = "A steel Halberd with a stabbing tip as well as a slashing side.";
		//ID
		newWeapon.ItemID = 12;
		//Stats
		newWeapon.ATK = 37;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LANCE;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponSpearOfTerror ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Spear Of Terror";
		//Description
		newWeapon.ItemDescription = "An ancient polearm meant to strike fear into it's enemies.";
		//ID
		newWeapon.ItemID = 13;
		//Stats
		newWeapon.ATK = 45;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LANCE;
		//Spell EffectID
		//newWeapon.SpellEffectID = ADD FEAR EFFECT
	}

	public void CreateWeaponPartisan ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Partisan";
		//Description
		newWeapon.ItemDescription = "A spear with added protrusions to aid in parrying sword thrusts.";
		//ID
		newWeapon.ItemID = 14;
		//Stats
		newWeapon.ATK = 56;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LANCE;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponHalberd ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Halberd";
		//Description
		newWeapon.ItemDescription = "A spear combined with a battle-ax.";
		//ID
		newWeapon.ItemID = 15;
		//Stats
		newWeapon.ATK = 65;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LANCE;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	//Shana/Miranda's Weapons

	public void CreateWeaponShortBow ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Short Bow";
		//Description
		newWeapon.ItemDescription = "A small and simple bow.";
		//ID
		newWeapon.ItemID = 16;
		//Stats
		newWeapon.ATK = 3;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponSparkleArrow ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Sparkle Arrow";
		//Description
		newWeapon.ItemDescription = "An arrow imbued with light magic.";
		//ID
		newWeapon.ItemID = 17;
		//Stats
		newWeapon.ATK = 9;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponLongBow ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Long Bow";
		//Description
		newWeapon.ItemDescription = "A longer bow meant for heavier shots.";
		//ID
		newWeapon.ItemID = 18;
		//Stats
		newWeapon.ATK = 18;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		//Spell EffectID
		//newWeapon.SpellEffectID = 10% Physical damage increase
	}

	public void CreateWeaponBemusingArrow ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Bemusing Arrow";
		//Description
		newWeapon.ItemDescription = "An arrow made to confuse.";
		//ID
		newWeapon.ItemID = 19;
		//Stats
		newWeapon.ATK = 24;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		//Spell EffectID
		//newWeapon.SpellEffectID = Chance to Confuse
	}

	public void CreateWeaponVirulentArrow ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Virulent Arrow";
		//Description
		newWeapon.ItemDescription = "An arrow designed to fire arrows dipped in poison.";
		//ID
		newWeapon.ItemID = 20;
		//Stats
		newWeapon.ATK = 30;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		//Spell EffectID
		//newWeapon.SpellEffectID = Chance to Poison
	}

	public void CreateWeaponArrowOfForce ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Arrow of Force";
		//Description
		newWeapon.ItemDescription = "A magical arrow that increases a dragoons spirit per shot.";
		//ID
		newWeapon.ItemID = 21;
		//Stats
		newWeapon.ATK = 40;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		//Spell EffectID
		//newWeapon.SpellEffectID = 50% Spirit Generation
	}

	public void CreateWeaponDetonateArrow ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Detonate Arrow";
		//Description
		newWeapon.ItemDescription = "An arrow designed to explode to hit all enemies.";
		//ID
		newWeapon.ItemID = 22;
		//Stats
		newWeapon.ATK = 50;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		//Spell EffectID
		//newWeapon.SpellEffectID = All enemy attack
	}

	//Rose's Weapons
	public void CreateWeaponRapier ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Rapier";
		//Description
		newWeapon.ItemDescription = "A thin, light, sharp-pointed sword made for thrusting attacks.";
		//ID
		newWeapon.ItemID = 23;
		//Stats
		newWeapon.ATK = 13;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LIGHTSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponDemonStilletto ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Demon Stilletto";
		//Description
		newWeapon.ItemDescription = "A thin, light, sharp-pointed sword made for thrusting attacks. Has a chance to cause fear.";
		//ID
		newWeapon.ItemID = 24;
		//Stats
		newWeapon.ATK = 18;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LIGHTSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}

	public void CreateWeaponShadowCutter ()
	{
		newWeapon = new BaseWeapon ();
		//Assign Name
		newWeapon.ItemName = "Shadow Cutter";
		//Description
		newWeapon.ItemDescription = "An ancient rapier that causes Dark Damage.";
		//ID
		newWeapon.ItemID = 25;
		//Stats
		newWeapon.ATK = 24;
		//Type
		newWeapon.WeaponType = BaseWeapon.WeaponTypes.LIGHTSWORD;
		//Spell EffectID
		//newWeapon.SpellEffectID = Effect Here
	}
}