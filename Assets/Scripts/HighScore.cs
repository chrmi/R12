using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {
    public void Clear()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        RefreshScore();
    }
    public void RefreshScore()
    {
        GetComponent<Text>().text = "High Score: \n" + PlayerPrefs.GetInt("HighScore").ToString();       
    }
	public void Awake() {
        RefreshScore();
	}
}
