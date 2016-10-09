using UnityEngine;
using System.Collections;

public class F_Target : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "F_Bullet") {
			Destroy(this.gameObject);
		}
	}
}
