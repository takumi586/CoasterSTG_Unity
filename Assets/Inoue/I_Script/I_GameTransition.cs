using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class I_GameTransition : MonoBehaviour {
	public int transFlame = 0;
	public int loadFlame = 0;

	private int cnt = 0;
	private int loadCnt = 0;
	private bool loadFlag = false;

	private GameObject startBgmObject;
	private I_BGM startBgmSc;


	void Start() {
		startBgmObject = GameObject.Find ("I_start_cmp");
		startBgmSc = startBgmObject.GetComponent<I_BGM>();
	}

	void FixedUpdate() {
		if (loadFlag) {
			if (loadFlame <= loadCnt) {
				SceneManager.LoadScene ("kitayamasai");
			}
			startBgmSc.endFlag = true;
			loadCnt++;
		} else {
			if (transFlame <= cnt) {
				loadFlag = true;
				cnt = transFlame;
			}
			if (!loadFlag) {
				if (Input.GetButton ("Fire1") || Input.GetButton ("Fire2") || Input.GetButton ("Fire3") || Input.GetButton ("Jump") || Input.GetKey (KeyCode.Z)) {
					cnt++;
				} else {
					cnt = 0;
				}
			}
		}
	}

	public int getCnt() {
		return cnt;
	}
}
