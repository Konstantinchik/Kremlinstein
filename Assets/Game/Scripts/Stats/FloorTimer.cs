using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorTimer : MonoBehaviour
{
    public int secondCount=0;
    public int minuteCount=0;
    public bool addingTime = false;
    public GameObject timeDisplay;

    // Update is called once per frame
    void Update()
    {
        if (!addingTime)
        {
            StartCoroutine(AddSecond());
        }
    }
    IEnumerator AddSecond()
    {
        addingTime = true;
        yield return new WaitForSeconds(1f);
        secondCount += 1;
        if(secondCount == 60)
        {
            secondCount = 0;
            minuteCount += 1;
        }

        if(secondCount <= 9)
        {
            if(minuteCount <= 9)
            {
                timeDisplay.GetComponent<Text>().text = "0" + minuteCount.ToString() + " : 0" + secondCount.ToString();
            }
            else
            {
                timeDisplay.GetComponent<Text>().text = minuteCount.ToString() + " : 0" + secondCount.ToString();
            }
        }
        else
        {
            if (minuteCount <= 9)
            {
                timeDisplay.GetComponent<Text>().text = "0" + minuteCount.ToString() + " : " + secondCount.ToString();
            }
            else
            {
                timeDisplay.GetComponent<Text>().text = minuteCount.ToString() + " : " + secondCount.ToString();
            }
        }

        timeDisplay.GetComponent<Text>().text = minuteCount.ToString() + " : " + secondCount.ToString();
        addingTime = false;
    }
}
