using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Registers : MonoBehaviour {
    [SerializeField] public ScoreManager scoreManager;
    Component[] registers;
    Dictionary<char, short> hexValues = new Dictionary<char, short>()
    {
        {'1', 1 }, {'2', 2 }, {'3', 3 },
        { '4', 4 }, {'5', 5 }, {'6', 6 },
        { '7', 7 }, {'8', 8 }, {'9', 9 },
        { 'A', 10 }, {'B', 11 }, {'C', 12 },
        {'D', 13 }, {'E', 14 }, {'F', 15 }
    };
    int active = 0;

    public void Awake()
    {
        registers = GetComponentsInChildren<Register>();
    }

    public void Add(char tileValue)
    {
        if (registers[active].GetComponent<Register>().Add(tileValue))
        {

        }
        else
        {
            active++;
            if (active > registers.Length -1)
            {
                SceneManager.LoadScene("Main");
            }
            else
            {
                registers[active].GetComponent<Register>().Add(tileValue);
            }
        }
        scoreManager.Add(hexValues[tileValue]);
    }
}
