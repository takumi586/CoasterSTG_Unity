using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class F_SceneMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void ButtonClick(){
		SceneManager.LoadScene ("F_Game");
	}

}
