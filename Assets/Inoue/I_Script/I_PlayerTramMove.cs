using UnityEngine;
using System.Collections;

public class I_PlayerTramMove : MonoBehaviour {
	private GameObject tram;
	private N_TramMove scN_TransMove;


	void Start () {
		tram = GameObject.Find ("N_Tram");
		scN_TransMove = tram.GetComponent<N_TramMove>();
	}
		
	void Update () {
		// t = tram.GetComponent<transform> ();
		this.GetComponent<Rigidbody>().velocity = tram.transform.forward*scN_TransMove.speed;
		Debug.Log (scN_TransMove.speed);
	}
}
