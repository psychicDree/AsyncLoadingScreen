using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject loadingScreen;
    public Slider bar;
    void Awake()
    {
        Instance = this;
        SceneManager.LoadSceneAsync((int)SceneIndex.AsyncLoadingScene, LoadSceneMode.Additive);
    }

    List<AsyncOperation> scensLoading = new List<AsyncOperation>();

    void LoadGame()
    {
        loadingScreen.gameObject.SetActive(true);
        scensLoading.Add(SceneManager.UnloadSceneAsync((int)SceneIndex.AsyncLoadingScene));
        scensLoading.Add(SceneManager.LoadSceneAsync((int)SceneIndex.Scene_Lvl01,LoadSceneMode.Additive));
        StartCoroutine(GetSceneLoadProgress());
    }

    float totalSceneProgress;
    public IEnumerator GetSceneLoadProgress()
    {
        for (int i = 0; i < scensLoading.Count; i++)
        {
            while (!scensLoading[i].isDone)
            {
                totalSceneProgress = 0;
                foreach (AsyncOperation operation in scensLoading)
                {
                    totalSceneProgress += operation.progress;
                }
                totalSceneProgress = (totalSceneProgress / scensLoading.Count) * 100f;
                bar.value = Mathf.RoundToInt(totalSceneProgress);
                yield return null;
            }
        }

        loadingScreen.gameObject.SetActive(false);
    }
}

public enum SceneIndex
{
    StartMenuScene=0, AsyncLoadingScene=1, Scene_Lvl01=2
}
