using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadScene(string scene) {
        SceneManager.LoadScene(scene);
    
    }
    public static void gotoScene(string scene)
    {
        SceneManager.LoadScene(scene);

    }

    public void Exit()
    {
        Application.Quit();
    }
}
