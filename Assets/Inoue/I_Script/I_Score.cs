using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class I_Score : MonoBehaviour {
	private int score;
	private TextMesh scoreText;

	void Start () {
		score = 0;
		scoreText = GetComponent<TextMesh> ();
	}
	void Update () {
		scoreText.text = "" + score;
	}

	public int getScore() {
		return score;
	}

	public void addScore(int s) {
		if (s >= 0) {
			score += s;
		}
	}
	public void subScore(int s) {
		if (s >= 0) {
			score -= s;
		}
	}
}
