using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {
	public GameObject leftEye;
	public GameObject rightEye;
	void Update () {
		transform.position = new Vector3 (Middle (leftEye.transform.position.x,rightEye.transform.position.x),leftEye.transform.position.y,leftEye.transform.position.z);
		transform.rotation = new Quaternion(leftEye.transform.rotation.x,leftEye.transform.rotation.y,leftEye.transform.rotation.z,leftEye.transform.rotation.w);
	}
	float Middle(float f1, float f2) {
		return f2 + ((f1 + f2 )/2);
	}
}