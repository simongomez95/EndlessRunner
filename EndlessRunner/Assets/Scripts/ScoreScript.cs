using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	public int score;
	public Transform player;
	public Text scoreText;

	// Use this for initialization
	void Start () {

		score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (player.position.x == transform.position.x) {
		
			score++;
			scoreText.text = score.ToString();
		}
	
	}
}
