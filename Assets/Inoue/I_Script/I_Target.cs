using UnityEngine;
using System.Collections;

public class I_Target : MonoBehaviour {
	public int ScorePoint;
	private I_Score s;

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
			Destroy(this.gameObject);
		}
	}
}
