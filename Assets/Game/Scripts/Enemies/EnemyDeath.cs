using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public int enemyHealth;
    public bool enemyDead;
    public GameObject enemyAI;
    public GameObject theEnemy;
    public GameObject hurtFlash;


    private void Start() 
    {
        enemyHealth = 20;
        enemyDead = false;
    }

    public void DamageEnemy(int damageAmount)
    {
        enemyHealth -= damageAmount;
    }
    
    void Update()
    {
        if(enemyHealth <= 0 && enemyDead == false)
        {
            enemyDead = true;
            theEnemy.GetComponent<Animator>().Play("Death");
            enemyAI.SetActive(false);
            if (hurtFlash.activeInHierarchy) hurtFlash.SetActive(false);
            theEnemy.GetComponent<LookPlayer>().enabled = false;
            GlobalScore.ratingValue += 100;
            GlobalCompleted.enemyCount += 1;
        }
    }
}
