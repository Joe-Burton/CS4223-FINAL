using UnityEngine;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    public static string playerName = "";

    public void SetPlayerName(string name)
    {
        playerName = name;
    } 
}