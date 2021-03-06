﻿using UnityEngine;
using System.Collections;

public class I_ShottingBullets : MonoBehaviour {

	// prefab
	public GameObject bullet;
	private GameObject camera;
	private GameObject tram;
	private N_TramMove scN_TransMove;

	// tram がいるならチェックする
	public bool tramExist = true;

	// 効果音
	public AudioClip shotSe;
	public float seVolume = 1;

	// 発射スピード
	public float speed = 1000;
	// ショットフレーム
	public int shotFlame = 60;
	// private int flame = 0;
	// 消滅時間
	public float disappearanceTime;

	void Start () {
		camera = transform.FindChild ("MainCamera").gameObject;
		if (tramExist) {
			tram = GameObject.Find ("N_Tram");
			scN_TransMove = tram.GetComponent<N_TramMove> ();
		}
		// 初期値を乱数で生成
		// ** flame = (int)Random.value % shotFlame;
	}
		
	void Update () {
		/*
		if (!isLocalPlayer) {
			return;
		}
		*/
		/* ++
		flame++;
		if (flame % shotFlame == 0) {
			Shot ();
			flame = 0;
		}
		++ */
			
		if(Input.GetKeyDown (KeyCode.Z)){
			Shot ();
		}
		// ここからボタン
		if(Input.GetButtonDown ("Fire1")){
			Shot ();
		} else if(Input.GetButtonDown ("Fire2")){
			Shot ();
		} else if(Input.GetButtonDown ("Fire3")){
			Shot ();
		} else if(Input.GetButtonDown ("Jump")){
			Shot ();
		}
	}

	// [Command]
	void Shot() {
		AudioSource.PlayClipAtPoint (shotSe, transform.position, seVolume);

		GameObject bullets = (GameObject)Instantiate(
			bullet,
			camera.transform.position - camera.transform.forward,
			Quaternion.identity);
		if (tramExist) {
			bullets.GetComponent<Rigidbody> ().velocity = camera.transform.forward * speed + tram.transform.forward * scN_TransMove.speed;
		} else {
			bullets.GetComponent<Rigidbody> ().velocity = camera.transform.forward * speed;
		}
		// NetworkServer.Spawn(bullets);

		Destroy (bullets, disappearanceTime);
	}
}