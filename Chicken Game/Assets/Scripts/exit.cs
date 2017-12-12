using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {


	public void doexit(){
		Debug.Log ("has quit game");
		Application.Quit();
	}
}