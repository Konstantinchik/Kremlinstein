using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedKeyCollects : MonoBehaviour
{
    public GameObject redKey;
    public AudioSource redKeyPickUpSound;
    public GameObject pickUpDisplay;


    private void OnTriggerEnter(Collider other)
    {
        GlobalKeys.redKeysValue++;
        redKey.SetActive(false);
        redKeyPickUpSound.Play();
        GetComponent<SphereCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "PICK UP RED KEY";
        pickUpDisplay.SetActive(true);
    }
}
