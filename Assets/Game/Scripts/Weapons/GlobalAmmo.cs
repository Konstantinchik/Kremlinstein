using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
    public static int handgumAmmo;
    public GameObject ammoDisplay;

    private void Update()
    {
        ammoDisplay.GetComponent<Text>().text = handgumAmmo.ToString();
    }

}
