using UnityEngine;
using System.Collections;

public class F_TargetCreateStop : MonoBehaviour {

	private F_NewTargetCreate t;
	public GameObject StartPosition;

	// Use this for initialization
	void Start () {
		 t = StartPosition.GetComponent<F_NewTargetCreate> ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "N_Tram") {
			t.FlagDown();
		}
	}

}
