using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager score;

	public Text scoreText;
	public Text hiScoreText;

	public float scoreCount;
	public float hiScoreCount;
	public float scoreCountReset;
	public float pointsPerSecond;

	public bool scoreIncreasing;


	void Start () {
		scoreCountReset = scoreCount;
        hiScoreCount = TextScore.sore.scoreee;
	}

	void Update () {

		if (scoreIncreasing) {
			scoreCount += pointsPerSecond * Time.deltaTime;
			if (scoreCount > hiScoreCount) {
				hiScoreCount = scoreCount;
			}

			scoreText.text = "Score: " + Mathf.Round (scoreCount);
			hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount);

			HighScore.control.highscoree = hiScoreCount;
			TextScore.sore.scoreee =hiScoreCount;
		}
	}
}
