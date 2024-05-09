using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour
{
    public Text nameText;

    void Start()
    {
        nameText.text = NameManager.playerName;
    }
}