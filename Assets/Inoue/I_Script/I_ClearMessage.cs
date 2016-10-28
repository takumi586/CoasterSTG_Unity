using UnityEngine;
using System.Collections;

public class I_ClearMessage : MonoBehaviour {
	public int num = 3;
	public int[] tensu; // = new int[num + 1];
	public string[] message; // = new string[num];

	private TextMesh ClearText;
	private bool messageDisplay = false;
	private bool clearFlag = true;
	private I_Score s;

	void Start() {
		ClearText = GetComponent<TextMesh>();
		ClearText.text = "";
		s = GameObject.Find ("ScoreDisplay").GetComponent<I_Score> ();
	}

	void Update() {
		if (!messageDisplay && clearFlag) {
			int score = s.getScore();
			for (int i = 0; i < num; i++) {
				if (tensu[i] <= score && score <= tensu[i+1]) {
					ScoreMessage(score);
					ClearText.text += message[i];
					messageDisplay = true;
				}
			}
			if (score < tensu[0]) {
				ScoreMessage(score);
				ClearText.text += "...うーん... " + tensu[0] + "を下回るはずないんだけどなぁ...\n";
				ClearText.text +=  "もしこのメッセージが表示されたら、スタッフに声をかけてね！";
				messageDisplay = true;
			}
			if (score > tensu[tensu.Length - 1]) {
				ScoreMessage(score);
				ClearText.text += "ありえない！この点数は想定外だ！\n";
				ClearText.text += "...何かズルをしたんじゃないか！？\n";
			}
		}
	}

	private void ScoreMessage(int score) {
		ClearText.text = "クリアおめでとう！\n";
		ClearText.text += "あなたの点数は " + score + "点でした！\n\n";
	}
}
