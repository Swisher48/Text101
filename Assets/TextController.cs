using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, freedom};
	private States myState;

	// Use this for initialization
	void Start () {

		myState = States.cell;
		
	}
	
	// Update is called once per frame
	void Update () {

	print (myState);
		
	}

	void state_cell (){

		text.text = "You are in a Prison Cell and want to escape. There are some dirty sheets on the bed, a mirror on the wall and the " +
						"door is locked from the outside \n\n" +
						"Press S to view the Sheets, M to view the Mirror and L to view the Lock ";

		if (Input.GetKeyDown(KeyCode.Space)){

			
			}
	}
}
