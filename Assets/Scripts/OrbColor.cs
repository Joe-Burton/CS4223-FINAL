using UnityEngine;
using UnityEngine.UI;

public class OrbColor : MonoBehaviour
{
    public Dropdown colorDropdown;
    public Material playerMaterial;

    void Start()
    {
        colorDropdown.onValueChanged.AddListener(ChangePlayerColor);
    }

    void ChangePlayerColor(int colorIndex)
    {
        Color[] colors = { Color.red, Color.green, Color.blue };
        
        playerMaterial.color = colors[colorIndex];
    }
}