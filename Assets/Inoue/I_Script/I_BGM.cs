using UnityEngine;
using System.Collections;

public class I_BGM : MonoBehaviour {
	private int cnt = 0;
	public float volume = 1;
	public int startFlame = -1;
	public int endFlame = -1;
	public float endSec = 0;
	public bool endFlag = false;
	public bool destroy = false;
	private AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
		audio.volume = volume;
	}

	void FixedUpdate () {
		audio.volume = volume;
		if (startFlame >= 0 && startFlame <= cnt && !audio.isPlaying) {
			audio.Play ();
			startFlame = -1;
		}
		if ((endFlame >= 0 && endFlame <= cnt && audio.isPlaying) || endFlag) {
			if (endSec == 0) {
				volume = 0;
			} else {
				volume -= 1 / (50 * endSec);
			}
			if (volume <= 0) {
				audio.Stop ();
				endFlame = -1;
				if (destroy)
					Destroy (this.gameObject);
			}
		}
		cnt++;
	}
}