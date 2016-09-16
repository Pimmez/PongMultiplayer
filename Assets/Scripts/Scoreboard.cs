using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour {

	[SerializeField] private Text scoreText;
	[SerializeField] private Text scoreText2;
	[SerializeField] private int Score = 0;
	[SerializeField] private int Score2 = 0;
	[SerializeField] private int MaxScore;
		
	void GetScoresRight()
	{
		if (Score < MaxScore) {
			Score = Score + 1;
		} else if (Score >= MaxScore) {
			//You Win
		}
	}

	void GetScoresLeft()
	{
		if (Score2 < MaxScore) {
			Score2 = Score2 + 1;
		} else if (Score2 >= MaxScore) {
			//You Win
		}
	}

	void Update()
	{
		scoreText.text = "" + Score;
		scoreText2.text = "" + Score2;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Ball") {
			if (col.gameObject.name == "WallRight") {
				GetScoresRight ();
			} else if (col.gameObject.name == "WallLeft") {
				GetScoresLeft();
			}
		}
	}
}
