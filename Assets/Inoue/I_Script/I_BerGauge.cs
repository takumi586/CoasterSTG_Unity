using UnityEngine;
using System.Collections;

public class I_BerGauge : MonoBehaviour {
	private GameObject barObject;
	private I_GameTransition bar;

	void Start () {
		barObject = GameObject.Find ("BarBase");
		bar = barObject.GetComponent<I_GameTransition> ();
	}

	void Update () {
		float x = 1.0f / bar.transFlame * bar.getCnt ();

		this.transform.localScale = new Vector3 (x, this.transform.localScale.y, this.transform.localScale.z);
	}
}
