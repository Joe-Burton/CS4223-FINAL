using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string gameScene = "Game";
    public string exitScene = "Exit";
    public string titleScene = "Intro";
    
    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameScene);
    }

    public void LoadExitScene()
    {
        SceneManager.LoadScene(exitScene);
    }

    public void LoadTitleScene()
    {
        SceneManager.LoadScene(titleScene);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}