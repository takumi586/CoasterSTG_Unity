using UnityEngine;
using System.Collections;

public class F_NewBalloonMove : MonoBehaviour {

		public float speed = 0.05f;
	public float disappearanceTime;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void FixedUpdate () {
			transform.Translate (0, speed, 0);
		Destroy (gameObject, disappearanceTime);
		}

}
