using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullHealthCollect : MonoBehaviour
{
    public GameObject healthItem;
    public AudioSource healthPickupSound;

    private void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue = 100;
        healthItem.SetActive(false);
        healthPickupSound.Play();
        GetComponent<SphereCollider>().enabled = false;
    
    }
}
