using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Test
{
    public void PlayButtonStartsPlay()
    {
        SceneManager.LoadScene("Intro");
        GameObject playButton = GameObject.Find("PlayButton");
        playButton.GetComponent<Button>().onClick.Invoke();
    }

    public void StopButtonStopsPlay()
    {
        GameObject stopButton = GameObject.Find("StopButton");
        stopButton.GetComponent<Button>().onClick.Invoke();
    }

    public void PlayAgainButtonRestartsGame()
    {
        GameObject playAgainButton = GameObject.Find("PlayAgainButton");
        playAgainButton.GetComponent<Button>().onClick.Invoke();
    }
}
