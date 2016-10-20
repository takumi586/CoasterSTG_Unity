using UnityEngine;
using System.Collections;

public class F_TargetCreateStop : MonoBehaviour {

	private F_NewTargetCreate t;

	// Use this for initialization
	void Start () {
		// t = GameObject.Find ("NF_Demo1020_2").GetComponent<F_NewTargetCreate> ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "N_Tram") {
			t.FlagDown();
		}
	}

}
