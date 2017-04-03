using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem //BaseWeapon <- BaseStatItem <- BaseItem (chain inheritance)
{
	public enum WeaponTypes
	{
		HEAVYSWORD,
		BOW,
		LANCE,
		LIGHTSWORD,
		FIST,
		HAMMER,
		AXE
	}

	private WeaponTypes weaponType;

	private int spellEffectID;

	public WeaponTypes WeaponType
	{
		get { return weaponType; }
		set { weaponType = value; }
	}

	public int SpellEffectID
	{
		get { return spellEffectID; }
		set { spellEffectID = value; }
	}
}