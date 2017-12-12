using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public int damage = 1;
	public int time = 5;

	public float moveSpeed;

	void Start () {
		
	}

	void Update() {
		transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void OnCollisionEnter(Collision other){
		var hit = other.gameObject;
		var health = hit.GetComponent<wolfHealth>();
		if(health != null){
			health.TakeDamage(damage);
		}

	}	
	IEnumerator DestroyBullet(){
		yield return new WaitForSeconds(time);
		Destroy(gameObject);
	}

}

