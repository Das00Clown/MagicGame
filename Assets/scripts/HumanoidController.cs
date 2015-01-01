using UnityEngine;
using System.Collections;
using System;

public class HumanoidController : MonoBehaviour {
    public float maxturn = 45;

	public GameObject head;
	public GameObject spine;

    public void Look(Vector3 MoveMent) {
		float newY = head.transform.eulerAngles.y + MoveMent.y;
        if (newY > maxturn && newY < 360f - maxturn) {
			newY = spine.transform.eulerAngles.y + MoveMent.y;
            if (!(newY > maxturn && newY < 360f - maxturn))
				spine.transform.rotation = Quaternion.Euler(head.transform.eulerAngles.x, newY, head.transform.eulerAngles.z);
        } else {
			head.transform.rotation = Quaternion.Euler(head.transform.eulerAngles.x, newY, head.transform.eulerAngles.z);
        }
    }
}
