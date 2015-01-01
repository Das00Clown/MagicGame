using UnityEngine;
using System.Collections;
using System;

public class HumanoidController : MonoBehaviour {
    public float maxturn = 45;

    public Quaternion headRotation = Quaternion.Euler(Vector3.zero);
    public Quaternion spineRotation = Quaternion.Euler(Vector3.zero);

    public void Look(Vector3 MoveMent) {
        float newY = headRotation.eulerAngles.y + MoveMent.y;
        if (newY > maxturn && newY < 360f - maxturn) {
            newY = spineRotation.eulerAngles.y + MoveMent.y;
            if (!(newY > maxturn && newY < 360f - maxturn))
                spineRotation = Quaternion.Euler(headRotation.eulerAngles.x, newY, headRotation.eulerAngles.z);
        } else {
            headRotation = Quaternion.Euler(headRotation.eulerAngles.x, newY, headRotation.eulerAngles.z);
        }
    }
}
