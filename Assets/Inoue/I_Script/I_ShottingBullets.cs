using UnityEngine;
using System.Collections;

public class I_ShottingBullets : MonoBehaviour {

	// bullet prefab
	public GameObject bullet;

	// 弾丸発射点
	public Transform shotPoint;

	// 弾丸の速度
	public float speed = 1000;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// z キーが押された時
		if(Input.GetMouseButtonDown (0)){
			// 弾丸の複製
			GameObject bullets = GameObject.Instantiate(bullet)as GameObject;

			Vector3 force;
			force = this.gameObject.transform.forward * speed;
			// Rigidbodyに力を加えて発射
			bullets.GetComponent<Rigidbody>().AddForce (force);
			// 弾丸の位置を調整
			bullets.transform.position = shotPoint.position;
		}
	}
}
