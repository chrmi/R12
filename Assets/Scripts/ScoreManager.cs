using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    int points = 0;

    public delegate void PointerDownAction(int points);
    public static event PointerDownAction PointerDownEvent;

    int highScore; 

    public void Awake()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }
    public void Add(short pointsToAdd)
    {
        if (points < int.MaxValue - pointsToAdd)
        {
            points += pointsToAdd;
            GetComponent<Text>().text = points.ToString();
            if (points > highScore)
            {
                PlayerPrefs.SetInt("HighScore", points);
            }
            PointerDownEvent(points: points);
        }
        else
        {
            Debug.Log("MORE THAN MAX VALUE OF INT! Do win");
        }
    }
}