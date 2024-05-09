using UnityEngine;
using UnityEngine.UI;

public class OrbCollisionHandler : MonoBehaviour
{
    public int score = 0;
    public Text scoreText; 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = "Score: " + score.ToString();
        }
    }
}