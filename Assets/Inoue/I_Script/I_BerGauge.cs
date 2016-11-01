using UnityEngine;
using System.Collections;

public class I_BerGauge : MonoBehaviour {
	private GameObject GameTransObject;
	private I_GameTransition GameTrans;

	void Start () {
		GameTransObject = GameObject.Find ("GameTrans");
		GameTrans = GameTransObject.GetComponent<I_GameTransition> ();
	}

	void Update () {
		float x = 1.0f / GameTrans.transFlame * GameTrans.getCnt ();

		this.transform.localScale = new Vector3 (x, this.transform.localScale.y, this.transform.localScale.z);
	}
}
