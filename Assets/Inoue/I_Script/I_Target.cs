using UnityEngine;
using System.Collections;

public class I_Target : MonoBehaviour {
	public int ScorePoint;
	private I_Score s;

	// 効果音
	public AudioClip Se;

	void Start() {
		s = GameObject.Find ("ScoreDisplay").GetComponent<I_Score> ();
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "I_Bullet") {
			if (ScorePoint >= 0) {
				s.addScore (ScorePoint);
			} else {
				s.subScore (-ScorePoint);
			}
			PlaySe ();
			Destroy(this.gameObject);
			Destroy (other.gameObject);
		}
	}

	void PlaySe() {
		AudioSource.PlayClipAtPoint (Se, transform.position);
	}
}
