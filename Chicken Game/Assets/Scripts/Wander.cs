using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour {
	public float moveSpeed;

	public float turnOnSeconds;
	private float elapsedSeconds = 0.0f;

	void MoveForward()
	{
		transform.Translate(Vector3.forward*moveSpeed*Time.deltaTime);
	}

	void Turn(){
		int randomNum = Random.Range(0,360);
		transform.Rotate(0,randomNum,0);
	}

	void Update() {
		if (elapsedSeconds >= turnOnSeconds) {
			Turn ();
			elapsedSeconds = 0;
		} else {
			elapsedSeconds += Time.deltaTime;
		}

		MoveForward ();
	}

	void OnTriggerStay(Collider other){
		if(other.gameObject.tag == "CheckPoint"){
			Turn();	
		}
		MoveForward();
	}	

}
