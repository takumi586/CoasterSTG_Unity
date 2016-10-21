﻿using UnityEngine;
using System.Collections;

public class F_NewTargetCreate : MonoBehaviour {

	public GameObject Vehicle;
	public GameObject Balloon;
	public GameObject Target;
	public GameObject BalloonRare;
	public GameObject TargetRare;
	public float TargetInterbal;
	public int TargetProbability;
	public int RareProbability;
	private float timeElapsed;
	private Vector3 pos;
	private int Flag;

	void Start(){
		Flag = 0;
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "N_Tram") {
				FlagUp ();
		}
	}

	void Update(){
		if (Flag == 1) {
			TargetRandom ();
		} 
	}

	private void TargetRandom(){
		
		timeElapsed += Time.deltaTime;

		if(timeElapsed >= TargetInterbal){
			float TargetX = Random.Range (-10.0f, 10.0f);
			float TargetY = Random.Range (5.5f, 7.5f);
			float TargetZ = Random.Range (30.0f, -25.0f);
			int TargetRand = Random.Range (1, 100);
			int RareRand = Random.Range (1, 100);

			if (TargetProbability - TargetRand >= 0) {
				Vector3 pos = Vehicle.transform.position;
				//Instantiate (Balloon, new Vector3 (pos.x + TargetX, TargetY, TargetZ), Quaternion.identity);
				if(RareProbability - RareRand >= 0){
					Instantiate (TargetRare, new Vector3 (pos.x + TargetX, TargetY, pos.z + TargetZ), Quaternion.identity);
				}else{
					Instantiate (Target, new Vector3 (pos.x + TargetX, TargetY, pos.z + TargetZ), Quaternion.identity);
				}
			}
			timeElapsed = 0.0f;
		}
	}

	public void FlagUp(){
		Flag = 1;
	}

	public void FlagDown(){
		Flag = 0;
		Debug.Log ("フラグダウン");
	}

}
