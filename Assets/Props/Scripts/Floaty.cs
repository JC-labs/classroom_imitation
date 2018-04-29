using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floaty : MonoBehaviour {

	private float waited = 0f;
	public float waitingTime = 5f;
	private int[] bindir = new int[] {1, -1};
	public float distance = 0.005f;
	public float[] bounds = new float[] {0.075f, 0.042f, 0.032f, -0.03f};

	void Update () {
		waited += Time.deltaTime;
		if (waited > waitingTime) {
			waited = 0f;
			if (transform.localPosition.y + distance > bounds[0])
				bindir[1] = -1;
			if (transform.localPosition.y - distance < bounds[1])
				bindir[1] = 1;
			if (transform.localPosition.x + distance > bounds[2])
				bindir[0] = -1;
			if (transform.localPosition.x - distance < bounds[3])
				bindir[0] = 1;
			transform.localPosition += new Vector3 (bindir[0] * distance, bindir[1] * distance);
		}
	}
}
