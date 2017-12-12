using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour {

	public static int score;

	public int scoreAmount = score;

	public Text scoreText;

	public int winScore;

	public Text winText;

	void Awake(){
		Time.timeScale = 1;
	}
	// Use this for initialization
	void Start () {
		winText.GetComponent<Text>().enabled = false;  
		score = 0;
	}

	// Update is called once per frame
	void Update () {
		if(score < 0)
			score = 0;

		scoreText.text = " " + score;

		if (winScore >= score){
			print("Win Score Reached = " + score);
			winText.GetComponent<Text>().enabled = true; 
			//Time.timeScale = 0; 
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene(0);
		}
	}

	public static void AddPoints(int pointsToAdd){
		score += pointsToAdd;
	}

	public void Reset(){
		score = 0;
	}

}