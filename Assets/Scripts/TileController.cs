using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileController : MonoBehaviour {
    [SerializeField] public char tileValue;
    [SerializeField] public Registers registers;
    [SerializeField] public Text text;
    public void Awake()
    {
        text.text = tileValue.ToString();
    }
    public void Report()
    {
        registers.Add(tileValue);
    }
}
