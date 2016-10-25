using UnityEngine;
using System.Collections;

public class N_TramMove : MonoBehaviour {
	public float speed = 0.01f;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody>().velocity = this.transform.forward*speed;
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		this.GetComponent<Rigidbody>().velocity = this.transform.forward*speed;
		Debug.Log (this.speed);
	}
}

