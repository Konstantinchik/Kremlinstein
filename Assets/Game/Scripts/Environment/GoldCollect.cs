using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCollect : MonoBehaviour
{
    public GameObject goldIngots;
    public AudioSource goldPickupSound;
    public GameObject pickUpDisplay;

    private void OnTriggerEnter(Collider other)
    {
        GlobalScore.scoreValue += 3;
        GlobalCompleted.treasureCount += 3;
        goldIngots.SetActive(false);
        goldPickupSound.Play();
        GetComponent<BoxCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "PICK UP GOLD";
        pickUpDisplay.SetActive(true);

    }
}
