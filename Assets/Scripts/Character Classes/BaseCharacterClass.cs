using System.Collections;
using UnityEngine;

public class BaseCharacterClass
{
	private string characterClassName;
	private string characterClassDescription;
	//Stats
	private float hp;
	private float atk;
	private float def;
	private float matk;
	private float mdef;
	private float speed;

	public string CharacterClassName
	{
		get { return characterClassName; }
		set { characterClassName = value; }
	}

	public string CharacterClassDescription
	{
		get { return characterClassDescription; }
		set { characterClassDescription = value; }
	}

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