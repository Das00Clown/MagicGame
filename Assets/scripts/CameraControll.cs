using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {
	public GameObject player;
    HumanoidController playerController;
    void Start() {
        playerController = player.GetComponent<HumanoidController>();
    }
    void Update() {
        camera.transform.position = playerController.headBone.position;
        camera.transform.rotation = Quaternion.Euler(player.transform.rotation.eulerAngles.x, player.transform.rotation.eulerAngles.y, 0);
	}
    float Middle(float a, float b) {
        return b + ((a + b) / 2);
    }
}