using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class I_ClearFlag_MenuTransition : MonoBehaviour {
	public int clearFlame = 0;
	public int nagaosiFlame = 0;
	public bool clearFlag = false;

	private int cnt = 0;
	private int nagaosiCnt = 0;

	void FixedUpdate () {
		if (cnt >= clearFlame) {
			clearFlag = true;
		}
		if (clearFlag && nagaosiCnt >= nagaosiFlame) {
			SceneManager.LoadScene ("F_Title");
		}


		if (Input.GetButton ("Fire1") || Input.GetButton ("Fire2") || Input.GetButton ("Fire3") || Input.GetButton ("Jump") || Input.GetKey (KeyCode.Z)) {
			nagaosiCnt++;
		} else {
			nagaosiCnt = 0;
		}
		cnt++;
		Debug.Log (nagaosiCnt);
	}
}
