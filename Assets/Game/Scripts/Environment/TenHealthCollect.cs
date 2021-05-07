using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TenHealthCollect : MonoBehaviour
{
    public GameObject healthItem;
    public AudioSource healthPickupSound;

    private void OnTriggerEnter(Collider other)
    {
        GlobalHealth.healthValue += 10;
        if (GlobalHealth.healthValue > 100) GlobalHealth.healthValue = 100;
        healthItem.SetActive(false);
        healthPickupSound.Play();
        GetComponent<SphereCollider>().enabled = false;

    }
}
