using UnityEngine;
using System.Collections;

public class F_NewBalloonMove : MonoBehaviour {

	public float speed = 0.05f;
	public float disappearanceTime;
	private Renderer ren;

		// Use this for initialization
	void Start () {
		//GetComponent<Renderer> ().material.SetColor (Color.black);
	}

		// Update is called once per frame
		void FixedUpdate () {
		//GetComponent<Renderer> ().material.SetColor (Color.black);
			transform.Translate (0, speed, 0);
		Destroy (gameObject, disappearanceTime);
		}

}
