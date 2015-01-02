using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
    public GameObject player;
    public HumanoidController playerController;

    public KeyCode move;
    public KeyCode sprint;

    void Start() {
        playerController = player.GetComponent<HumanoidController>();
    }
    void Update() {
        playerController.Look(new Vector3(0, Input.GetAxis("Mouse X"), 0));
        playerController.walk = Input.GetKey(move);
        playerController.sprint = Input.GetKey(sprint);
    }
}