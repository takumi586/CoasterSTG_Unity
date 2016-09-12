using UnityEngine;
using System.Collections;

public class I_Target : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "I_Bullet") {
			Destroy(this.gameObject);
		}
	}
}
