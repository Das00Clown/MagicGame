using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {
	public GameObject player;
    HumanoidController playerController;
    void Start() {
        playerController = player.GetComponent<HumanoidController>();
    }
    void Update() {
        transform.rotation = Quaternion.Euler(playerController.headEuler.x, playerController.head.transform.eulerAngles.y, 0);
        transform.position = new Vector3(player.transform.position.x, playerController.head.transform.position.y, player.transform.position.z);
        //transform.position = new Vector3 (Middle (leftEye.transform.position.x,rightEye.transform.position.x),leftEye.transform.position.y,leftEye.transform.position.z);
        //transform.rotation = new Quaternion(leftEye.transform.rotation.x,leftEye.transform.rotation.y,leftEye.transform.rotation.z,leftEye.transform.rotation.w);
	}
	float Middle(float f1, float f2) {
		return f2 + ((f1 + f2 )/2);
	}
}