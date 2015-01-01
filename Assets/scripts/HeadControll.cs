using UnityEngine;
using System.Collections;

public class HeadControll : MonoBehaviour {
    HumanoidController humanoidController;

	void Start () {
        humanoidController = transform.GetComponentInParent<HumanoidController>();
	}
	
	void Update () {
        transform.rotation = humanoidController.headRotation;
	}
}