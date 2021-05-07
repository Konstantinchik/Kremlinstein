using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandgunAmmoPick : MonoBehaviour
{
    public GameObject fakeAmmo;
    public AudioSource ammoPickupSound;
    public GameObject pickUpDisplay;

    private void OnTriggerEnter(Collider other)
    {
        fakeAmmo.SetActive(false);
        ammoPickupSound.Play();
        GlobalAmmo.handgumAmmo += 10;            // 10 патронов в обойме
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "PICK UP BULLETS";
        pickUpDisplay.SetActive(true);
    }
}
