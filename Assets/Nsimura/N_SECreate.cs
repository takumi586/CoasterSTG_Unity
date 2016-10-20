using UnityEngine;
using System.Collections;

public class N_SECreate: MonoBehaviour {

	public AudioSource shootSound;

	// Use this for initialization
	void Start () {
		
	shootSound = GetComponent<AudioSource>();
	 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.K)) {
			shootSound.PlayOneShot (shootSound.clip);
		} 
	}
}
