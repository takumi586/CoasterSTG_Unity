using UnityEngine;
using System.Collections;

public class I_Crystal : MonoBehaviour {
	public float speed;
	public float topSpeed;
	public float topSpeedFlame;
	private bool topSpeedFlag = false;
	private int cnt = 0;

	private GameObject body1;
	private GameObject body2;

	private AudioSource audioSe;
	public float seVolume = 1;

	void Start() {
		body1 = transform.FindChild ("CrystalBody1").gameObject;
		body2 = transform.FindChild ("CrystalBody2").gameObject;

		audioSe = GetComponent<AudioSource>();
		audioSe.volume = seVolume;
	}
		
	void FixedUpdate () {
		float tmpSpeed;

		if (topSpeedFlag && topSpeedFlame >= cnt) {
			tmpSpeed = topSpeed;
		} else {
			tmpSpeed = speed;
			topSpeedFlag = false;
		}
		cnt++;

		body1.transform.Rotate (0f, tmpSpeed, 0f);
		body2.transform.Rotate (0f, -tmpSpeed, 0f);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "I_Bullet") {
			audioSe.Play ();
			Destroy (other.gameObject);
			topSpeedFlag = true;
			cnt = 0;
		}
	}
}
