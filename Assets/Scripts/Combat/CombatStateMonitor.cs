using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatStateMonitor : MonoBehaviour 
{
	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		PLAYERANIM,
		ENEMYCHOICE,
		ENEMYANIM,
		LOSE,
		WIN
	}

	private BattleStates currentState;


	// Use this for initialization
	void Start () 
	{
		currentState = BattleStates.START;
	}
	// Update is called once per frame
	void Update () 
	{
		Debug.Log (currentState);

		switch (currentState) 
		{
		case (BattleStates.START):
			//setup battle function
			break;
		case (BattleStates.PLAYERCHOICE):
			
			break;
		case (BattleStates.PLAYERANIM):
			
			break;
		case (BattleStates.ENEMYCHOICE):
			
			break;
		case (BattleStates.ENEMYANIM):
			
			break;
		case (BattleStates.WIN):
			
			break;
		case (BattleStates.LOSE):
			
			break;
		}
	}

	void OnGUI()
	{
		if(GUILayout.Button("NEXT STATE"))
		{
			if (currentState == BattleStates.START) 
			{
				currentState = BattleStates.PLAYERCHOICE;
			}
			else if (currentState == BattleStates.PLAYERCHOICE) 
			{
				currentState = BattleStates.PLAYERANIM;
			}
			else if (currentState == BattleStates.PLAYERANIM) 
			{
				currentState = BattleStates.ENEMYCHOICE;
			}
			else if (currentState == BattleStates.ENEMYCHOICE) 
			{
				currentState = BattleStates.ENEMYANIM;
			}
			else if (currentState == BattleStates.ENEMYANIM) 
			{
				currentState = BattleStates.WIN;
			}
			else if (currentState == BattleStates.WIN) 
			{
				currentState = BattleStates.LOSE;
			}
			else if (currentState == BattleStates.LOSE) 
			{
				currentState = BattleStates.START;
			}
		}
	}
}