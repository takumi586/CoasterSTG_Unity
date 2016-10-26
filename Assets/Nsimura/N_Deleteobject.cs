using UnityEngine;
using System.Collections;

public class N_Deleteobject: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "N_Tram") {
			Delete ();
		}
	}


	void Delete(){
		GameObject obj = GameObject.Find ("N_House");
		GameObject.Destroy (obj);
	}
}
