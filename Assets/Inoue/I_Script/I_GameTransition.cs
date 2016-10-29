using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class I_GameTransition : MonoBehaviour {
	public int transFlame = 0;
	private int cnt = 0;

	void FixedUpdate() {
		if (transFlame <= cnt) {
			SceneManager.LoadScene ("kitayamasai");
		}

		if (Input.GetButton ("Fire1") || Input.GetButton ("Fire2") || Input.GetButton ("Fire3") || Input.GetButton ("Jump") || Input.GetKey (KeyCode.Z)) {
			cnt++;
		} else {
			cnt = 0;
		}
	}

	public int getCnt() {
		return cnt;
	}
}
