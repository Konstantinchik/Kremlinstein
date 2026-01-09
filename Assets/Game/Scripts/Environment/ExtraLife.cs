using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLife : MonoBehaviour
{
    public GameObject lifeItem;
    public AudioSource lifePickupSound;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        GlobalLife.lifeValue += 1;
        lifePickupSound.Play();
        gameObject.SetActive(false);
    }
}
