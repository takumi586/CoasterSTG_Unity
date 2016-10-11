using UnityEngine;
using System.Collections;

public class N_TramMove : MonoBehaviour {
	public float speed = 0.01f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, speed);
	}
}

