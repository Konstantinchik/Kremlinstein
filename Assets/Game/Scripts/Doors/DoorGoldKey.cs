using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorGoldKey : MonoBehaviour
{
    public GameObject movableDoor;
    public AudioSource doorFX;
    public GameObject pickUpDisplay;
    private static bool isTriggered;


    private void Start()
    {
        isTriggered = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (GlobalKeys.goldenKeysValue == 0)
        {
            pickUpDisplay.SetActive(false);
            pickUpDisplay.GetComponent<Text>().text = "НАЙДИ ЗОЛОТОЙ КЛЮЧ !";
            pickUpDisplay.SetActive(true);
            return;
        }
        if (other.gameObject.CompareTag("Player") && isTriggered == false)
        {
            isTriggered = true;
            GlobalKeys.blueKeysValue--;
            movableDoor.GetComponent<Animator>().Play("DoorBlueOpen");
            movableDoor.GetComponent<BoxCollider>().isTrigger = false;
            //this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}