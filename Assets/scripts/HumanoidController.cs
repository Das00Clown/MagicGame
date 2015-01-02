using UnityEngine;
using System.Collections;
using System;

public class HumanoidController : MonoBehaviour {
    public float maxturn = 45;

    public Vector3 headEuler = Vector3.zero;

    public GameObject head;

    public bool turn = false;

    public void Look(Vector3 MoveMent) {
		float newY = transform.eulerAngles.y + MoveMent.y;
        if (newY > maxturn && newY < 360f - maxturn) {

        } else {
            headEuler = new Vector3(transform.eulerAngles.x, newY, 0);
        }
        turn = transform.eulerAngles.y == 0;
    }
}

        //float newY = head.transform.eulerAngles.y + MoveMent.y;
        //if (newY > maxturn && newY < 360f - maxturn) {
        //    newY = spine.transform.eulerAngles.y + MoveMent.y;
        //    if (!(newY > maxturn && newY < 360f - maxturn))
        //        spine.transform.rotation = Quaternion.Euler(spine.transform.eulerAngles.x, newY, spine.transform.eulerAngles.z);
        //} else {
        //    head.transform.rotation = Quaternion.Euler(head.transform.eulerAngles.x, newY, head.transform.eulerAngles.z);
        //}