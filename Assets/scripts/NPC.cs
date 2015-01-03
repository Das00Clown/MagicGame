using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {
    HumanoidController humanoidController;

	// States
	public bool moving = false;
	public Vector3 movingTo = Vector3.zero;



	void Start () {
        humanoidController = GetComponent<HumanoidController>();
	}

    void Update() {
		if (moving) {
			transform.LookAt (movingTo);
			humanoidController.walk = movingTo != transform.position;
		}
    }

	public void MoveTo(Vector3 movingTo) {
		this.movingTo = movingTo;
		moving = true;
	}
}
