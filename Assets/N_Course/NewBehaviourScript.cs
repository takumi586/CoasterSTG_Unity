using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public float speed = 0.02f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (speed, 0, 0);

	}
}
