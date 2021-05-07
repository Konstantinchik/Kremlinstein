using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public Transform playerTarget;
    
    void Update()
    {
        transform.LookAt(playerTarget);    
    }
}
