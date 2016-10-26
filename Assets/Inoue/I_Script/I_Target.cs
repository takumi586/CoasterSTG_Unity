using UnityEngine;
using System.Collections;

public class I_Target : MonoBehaviour {
	public int ScorePoint;
	private I_Score s;
	private bool seFlag = false;

	// 効果音
	public float seVolume = 1;
	public int destroyCnt = 0;
	private int cnt = 0;
	private AudioSource audioSe;

	void Start() {
		s = GameObject.Find ("ScoreDisplay").GetComponent<I_Score> ();
		audioSe = GetComponent<AudioSource>();
		audioSe.volume = seVolume;
	}

	void FixedUpdate() {
		if (seFlag) {
			if (cnt >= destroyCnt) {
				Destroy (this.gameObject);
			}
			cnt++;
		}
	}
		
	void OnTriggerEnter(Collider other) {
		if (!seFlag) {
			if (other.gameObject.tag == "I_Bullet") {
				if (ScorePoint >= 0) {
					s.addScore (ScorePoint);
				} else {
					s.subScore (-ScorePoint);
				}
				audioSe.Play ();
				seFlag = true;
				Destroy (other.gameObject);
				this.transform.Translate (0f, -100f, 0f);
			}
		}
	}
}
