using UnityEngine;
using System.Collections;
using System;

public class HumanoidController : MonoBehaviour {
    public Transform headBone;
    Animator anim;
    public bool walk;
    public bool sprint;

    public float minimum = 0F;
    public float maximum = 0F;

    void Start() {
        anim = transform.GetComponent<Animator>();
    }

    public void Look(Vector3 MoveMent) {
        maximum = MoveMent.y;
        anim.SetFloat("Direction", Mathf.Lerp(minimum, maximum, Time.time * 0.1f));
        anim.SetBool("Moving", walk);
        anim.SetBool("Sprint", sprint);
    }
}