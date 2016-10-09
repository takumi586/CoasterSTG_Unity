using UnityEngine;
using System.Collections;

public class F_CriateBalloon : MonoBehaviour {

	public GameObject Balloon;
	public GameObject Vehicle;
	public GameObject Target;
	public float timeOut;
	private float timeElapsed;
	private Vector3 pos;

	void Start(){
	}

	void Update(){
		timeElapsed += Time.deltaTime;

		if(timeElapsed >= timeOut){
			float x = Random.Range (-7.0f, 7.0f);
			float y = Random.Range (5.5f, 6.0f);
			float z = Random.Range (-2.0f, 2.0f);
			Vector3 pos = Vehicle.transform.position;
			Instantiate (Balloon, new Vector3(pos.x + x, y, z), Quaternion.identity);
			Instantiate (Target, new Vector3(pos.x - x, y, z), Quaternion.identity);
			timeElapsed = 0.0f;
		}
	}

}
