using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void RepeatScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Change(int indexScene)
    {
        SceneManager.LoadScene(indexScene);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
