using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour {
    [SerializeField] FizzBuzz fizzBuzz;
    public void Awake()
    {
        ScoreManager.PointerDownEvent += fizzBuzz.Check;
    }
    public void OnDisable()
    {
        ScoreManager.PointerDownEvent -= fizzBuzz.Check;
    }
}
