﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
	public Rigidbody projectile;
	public Transform shootPoint;
	public int shootSpeed; 

	
	void Update (){
		if(Input.GetButtonDown("Fire1")){
			Debug.Log ("Shooting");
			Instantiate (projectile, transform.position, transform.parent.transform.rotation);
		//Rigidbody clone;
		//clone = (Rigidbody)Instantiate(projectile,shootPoint.position, projectile.rotation);
		//clone.velocity = shootPoint.TransformDirection
		//(Vector3.forward*shootSpeed);
		}
	}
	}
	
