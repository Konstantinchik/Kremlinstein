using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Secret001A : MonoBehaviour
{
    public GameObject movableWall;
    private static bool isTriggered;

    private void Start()
    {
        isTriggered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && isTriggered == false)
        {
            isTriggered = true;
            movableWall.GetComponent<Animator>().Play("SecretRoomR");
            movableWall.GetComponent<BoxCollider>().isTrigger = false;
            //this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
