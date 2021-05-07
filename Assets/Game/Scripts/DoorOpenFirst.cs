using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenFirst : MonoBehaviour
{
    public GameObject theDoor;
    public AudioSource doorFX;

    private void OnTriggerEnter(Collider other)
    {
        doorFX.Play();
        theDoor.GetComponent<Animator>().Play("Door Open");
        // отключаем BoxCollider чтобы небыло ложных срабатываний
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5f);
        doorFX.Play();  
        theDoor.GetComponent<Animator>().Play("Door Close");
        // по прошествии заданного времени активируем коллайдер
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
