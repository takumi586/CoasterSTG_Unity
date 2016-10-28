using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class F_SceneMove : MonoBehaviour {

	private int cnt;
	public int dacnt;

	// Use this for initialization
	void Start () {
		cnt = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Debug.Log (cnt);
		if(Input.GetButton("Fire1") || Input.GetButton("Fire2") ||
			Input.GetButton("Fire3") || Input.GetButton("Jump") || Input.GetKey(KeyCode.Z)){
			cnt++;
			if(cnt >= dacnt){
				SceneManager.LoadScene ("kitayamasai");
			}
		}else if(Input.GetButtonUp("Fire1") || Input.GetButtonUp("Fire2") ||
			Input.GetButtonUp("Fire3") || Input.GetButtonUp("Jump") || Input.GetKeyUp(KeyCode.Z)){
			cnt = 0;
		}
	}

/*	public void ButtonClick(){
		SceneManager.LoadScene ("kitayamasai");
	}*/

}
