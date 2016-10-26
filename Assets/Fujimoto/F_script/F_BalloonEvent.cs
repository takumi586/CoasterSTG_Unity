using UnityEngine;
using System.Collections;

public class F_BalloonEvent : MonoBehaviour {

	public GameObject Balloon;
	public GameObject BalloonRare;
	public float Timing;
	public GameObject BalloonPoint;
	public int number;

	//何回生成するか
	public int count;
	//次に出る秒数
	public float NextTime;

	public void Start(){
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "N_Tram") {
			Invoke ("BalloonCreate", Timing);
			count--;
			float TimeAdd = Timing;
			while (count > 0) {
				TimeAdd += NextTime;
				Invoke ("BalloonCreate", TimeAdd);
				count--;
			}
			Destroy (gameObject,TimeAdd);
		}
	}

	public void Update(){
	}

	public void BalloonCreate(){
		Vector3 pos;

		for (int i = 0; i < number; i++) {
			float Angle = (float)360 / number;

			transform.Rotate(new Vector3(0f,Angle,0f));
			pos = BalloonPoint.transform.position;

			Instantiate (Balloon, pos, Quaternion.identity);
		}

	}

}
