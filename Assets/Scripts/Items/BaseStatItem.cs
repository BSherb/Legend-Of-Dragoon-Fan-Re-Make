using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatItem : BaseItem 
{
	private float hp;
	private float atk;
	private float def;
	private float matk;
	private float mdef;
	private float speed;

	public float HP
	{
		get { return hp; }
		set { hp = value; }
	}

	public float ATK
	{
		get { return atk; }
		set { atk = value; }
	}

	public float DEF
	{
		get { return def; }
		set { def = value; }
	}

	public float MATK
	{
		get { return matk; }
		set { matk = value; }
	}

	public float MDEF
	{
		get { return mdef; }
		set { mdef = value; }
	}

	public float Speed
	{
		get { return speed; }
		set { speed = value; }
	}
}