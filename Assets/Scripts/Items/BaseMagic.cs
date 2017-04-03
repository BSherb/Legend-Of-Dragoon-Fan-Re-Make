using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMagic : BaseItem
{
	private int spellEffectID;

	public int SpellEffectID
	{
		get { return spellEffectID; }
		set { spellEffectID = value; }
	}
}