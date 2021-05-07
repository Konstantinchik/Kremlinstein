using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// здесь собраны поля хранящие значения для многих элементов игры. потом перенесу в Manager

public class GlobalScore : MonoBehaviour
{
    public GameObject scoreDisplay;
    public static int scoreValue;
    public static int ratingValue;
    public int internalScore;
    public int internalRating;
    public GameObject finalScore;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
        ratingValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = scoreValue.ToString();
        finalScore.GetComponent<Text>().text = scoreValue.ToString();
    }
}
