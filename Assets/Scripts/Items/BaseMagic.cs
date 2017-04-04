using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMagic : BaseStatItem
{
	private int spellEffectID;

	public int SpellEffectID
	{
		get { return spellEffectID; }
		set { spellEffectID = value; }
	}
}