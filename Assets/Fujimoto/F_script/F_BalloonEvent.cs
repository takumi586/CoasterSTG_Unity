using UnityEngine;
using System.Collections;

public class F_BalloonEvent : MonoBehaviour {

	public GameObject Balloon;
	public GameObject BalloonRare;
	public float Timing;
	public GameObject BalloonPoint1;
	public GameObject BalloonPoint2;
	public int n1;
	public int n2;

	public void Start(){
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "N_Tram") {
			Invoke ("BalloonCreate", Timing);
		}
	}

	public void FixedUpdate(){
	}

	public void BalloonCreate(){
		for (int i = 0; i < n1; i++) {
			float Angle = (float)360 / n1;
			transform.Rotate(new Vector3(0f,Angle,0f));
			Vector3 pos1 = BalloonPoint1.transform.position;
			Instantiate (Balloon, pos1, Quaternion.identity);
		}
		for (int i = 0; i < n2; i++) {
			float Angle = (float)360 / n2;
			transform.Rotate(new Vector3(0f,Angle,0f));
			Vector3 pos2 = BalloonPoint2.transform.position;
			Instantiate (Balloon, pos2, Quaternion.identity);
		}
		Destroy (gameObject);
	}

}
