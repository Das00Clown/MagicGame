using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
    public GameObject player;
    public HumanoidController playerController;
    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<HumanoidController>();
    }
    void Update() {
        playerController.Look(new Vector3(0, Input.GetAxis("Mouse X"),0));
    }
}