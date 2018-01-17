using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Register : MonoBehaviour {
    [SerializeField] public int id;
    List<char> values = new List<char>();
    public bool Add(char value)
    {
        if (values.Count == 0)
        {
            values.Add(value);
            GetComponent<Text>().text = "0x" + value;
            return true;
        }
        else if (values.Count <= 7)
        {
            values.Add(value);
            GetComponent<Text>().text += value;
            return true;
        }
        else
        {
            return false;
        }
    }
}
