using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldenKeyCollects : MonoBehaviour
{
    public GameObject goldenKey;
    public AudioSource goldenKeyPickUpSound;
    public GameObject pickUpDisplay;

    
    private void OnTriggerEnter(Collider other)
    {
        GlobalKeys.goldenKeysValue ++;
        goldenKey.SetActive(false);
        goldenKeyPickUpSound.Play();
        GetComponent<SphereCollider>().enabled = false;
        pickUpDisplay.SetActive(false);
        pickUpDisplay.GetComponent<Text>().text = "PICK UP GOLDEN KEY";
        pickUpDisplay.SetActive(true);
    }
}
