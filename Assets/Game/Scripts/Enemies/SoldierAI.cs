using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAI : MonoBehaviour
{
    public string hitTag;
    public bool lookingAtPlayer = false;
    public GameObject objectSoldier;
    public AudioSource fireSound;
    public bool isFiring = false;
    public float fireRate = 1.5f;
    public int generateHurt;
    public AudioSource[] hurtSound;
    public GameObject hurtFlash;

    private void Start()
    {
        lookingAtPlayer = false;
        isFiring = false;
    }
    
    void Update()
    {
        RaycastHit Hit;
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            hitTag = Hit.transform.tag;
        }
        if(hitTag == "Player" && isFiring == false)
        {
            StartCoroutine(EnemyFire());
        }
        if(hitTag != "Player")
        {
            objectSoldier.GetComponent<Animator>().Play("Idle");
            lookingAtPlayer = false;
        }
    }

    IEnumerator EnemyFire()
    {
        isFiring = true;
        objectSoldier.GetComponent<Animator>().Play("Fire 1Pistol", -1, 0);
        objectSoldier.GetComponent<Animator>().Play("Fire 1Pistol");
        fireSound.Play();
        lookingAtPlayer = true;
        GlobalHealth.healthValue -= 5; // 30; // 5;
        hurtFlash.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        hurtFlash.SetActive(false);
        generateHurt = Random.Range(0, 3);
        hurtSound[generateHurt].Play();
        yield return new WaitForSeconds(fireRate);
        isFiring = false;
    }
}
