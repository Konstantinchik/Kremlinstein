using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueKeyCollects : MonoBehaviour
{
    public GameObject blueKey;
    public AudioSource blueKeyPickUpSound;
    public GameObject pickUpDisplay;


    private void OnTriggerEnter(Collider other)
    {
        GlobalKeys.blueKeysValue++;
        blueKey.SetActive(false);
        blueKeyPickUpSound.Play();
        GetComponent<SphereCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "PICK UP BLUE KEY";
        pickUpDisplay.SetActive(true);
    }
}
