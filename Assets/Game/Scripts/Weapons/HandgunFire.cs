using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunFire : MonoBehaviour
{
    public GameObject theGun;
    public GameObject muzzleFlash;
    public GameObject castingObject; // откуда целимся
    public AudioSource gunFire;
    public AudioSource emptySound;
    public bool isFiring;
    public float targetDistance;
    public int damageAmount;

    private void Start()
    {
        isFiring = false;
        damageAmount = 5;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (GlobalAmmo.handgumAmmo < 1)
            {
                emptySound.Play();
            }
            else
            if (!isFiring) StartCoroutine(FiringHandgun());
        }
    }

    IEnumerator FiringHandgun()
    {
        RaycastHit theShot;
        isFiring = true;
        GlobalAmmo.handgumAmmo -= 1;
        if(Physics.Raycast(castingObject.transform.position, castingObject.transform.TransformDirection(Vector3.forward), out theShot))
        {
            targetDistance = theShot.distance;
            theShot.transform.SendMessage("DamageEnemy", damageAmount, SendMessageOptions.DontRequireReceiver);
        }
        theGun.GetComponent<Animator>().Play("HandgunFire");
        muzzleFlash.SetActive(true);
        gunFire.Play();
        yield return new WaitForSeconds(0.05f);
        muzzleFlash.SetActive(false);
        yield return new WaitForSeconds(0.35f);
        isFiring = false;
    }
}
