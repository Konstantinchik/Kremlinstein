using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalKeys : MonoBehaviour
{
    public GameObject goldenKeyDisplay;
    public GameObject redKeyDisplay;
    public GameObject blueKeyDisplay;
    public static int goldenKeysValue;
    public static int redKeysValue;
    public static int blueKeysValue;

    private void Start()
    {
        goldenKeysValue = 0;
        redKeysValue = 0;
        blueKeysValue = 0;
    }

    private void Update()
    {
        //internalScore = scoreValue;
        goldenKeyDisplay.GetComponent<Text>().text = goldenKeysValue.ToString();
        redKeyDisplay.GetComponent<Text>().text = redKeysValue.ToString();
        blueKeyDisplay.GetComponent<Text>().text = blueKeysValue.ToString();
    }
}
