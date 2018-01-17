using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {
    [SerializeField] string SceneToLoad;
    public void Load()
    {
        SceneManager.LoadScene(SceneToLoad);
    }

}
