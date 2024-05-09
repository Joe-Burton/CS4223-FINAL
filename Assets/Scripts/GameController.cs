using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public void StopGame()
    {
        SceneManager.LoadScene("Exit");
        
        string playerName = NameManager.playerName;
        int score = GetComponent<OrbCollisionHandler>().score;
    }
}