using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButionPressed()
    {
        Application.Quit();
    }
}
