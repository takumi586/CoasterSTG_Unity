using UnityEngine;
using System.Collections;

public class I_ShottingBullets : MonoBehaviour {

	// prefab
	public GameObject bullet;
	private GameObject camera;

	// 発射スピード
	public float speed = 1000;
	// ショットフレーム
	public int shotFlame = 60;
	private int flame = 0;
	// 消滅時間
	public float disappearanceTime;

	void Start () {
		camera = transform.FindChild ("MainCamera").gameObject;
		// 初期値を乱数で生成
		flame = (int)Random.value % shotFlame;
	}
		
	void Update () {
		/*
		if (!isLocalPlayer) {
			return;
		}
		*/

		flame++;
		if (flame % shotFlame == 0) {
			Shot ();
			flame = 0;
		}
			
		if(Input.GetKeyDown (KeyCode.Z)){
			Shot ();
		}
	}

	// [Command]
	void Shot() {
		GameObject bullets = (GameObject)Instantiate(
			bullet,
			camera.transform.position - camera.transform.forward,
			Quaternion.identity);

		bullets.GetComponent<Rigidbody>().velocity = camera.transform.forward*speed;

		// NetworkServer.Spawn(bullets);

		Destroy (bullets, disappearanceTime);
	}
}