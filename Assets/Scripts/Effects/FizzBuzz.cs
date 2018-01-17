using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    public void Check(int points)
    {
        if (points % 3 == 0 && points % 5 == 0)
        {
            GameObject prefab = Instantiate(Resources.Load("FizzBuzz")) as GameObject;	
            Destroy(prefab, 3);
            scoreManager.Add(3);
        } else if (points % 3 == 0)
        {
            GameObject prefab = Instantiate(Resources.Load("Fizz")) as GameObject;	
            Destroy(prefab, 3);
            scoreManager.Add(1);
        } else if (points % 5 == 0)
        {
            GameObject prefab = Instantiate(Resources.Load("Buzz")) as GameObject;	
            Destroy(prefab, 3);
            scoreManager.Add(2);
        }
    }
}
