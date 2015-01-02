using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

    HumanoidController humanoidController;

	void Start () {
        humanoidController = GetComponent<HumanoidController>();
	}


    void Update() {
        //hier ki update:D
        System.Random rnd = new System.Random();
        humanoidController.Look(new Vector3(0, (float)(2 * rnd.NextDouble() -1), 0));
        humanoidController.walk = System.Convert.ToBoolean( rnd.Next(0, 1));
    }
}
