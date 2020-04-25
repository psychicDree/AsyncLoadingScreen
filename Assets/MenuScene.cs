using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public string loadingSceneName;
    void OnPlayButtonPressed()
    {
        SceneManager.LoadScene(loadingSceneName, LoadSceneMode.Additive);
    }

    void OnQuitButionPressed()
    {
        Application.Quit();
    }
}
