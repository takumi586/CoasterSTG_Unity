using UnityEngine;
using System.Collections;

public class I_SpeedAdjustment : MonoBehaviour {
	private GameObject tram;
	private N_TramMove scN_TransMove;
	private int cnt = 0;
	public bool CollisionFlag = false;
	public float speed;
	public float flame = 0;

	void Start () {
		tram = GameObject.Find ("N_Tram");
		scN_TransMove = tram.GetComponent<N_TramMove>();
	}
		
	void FixedUpdate () {
		cnt++;
		if (CollisionFlag && cnt >= flame) {
			scN_TransMove.speed = this.speed;
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject == tram) {	
			CollisionFlag = true;
		}
	}
}
