using UnityEngine;
using UnityEngine.UI;

public class OrbSize : MonoBehaviour
{
    public Slider playerSizeSlider;
    public float minSize = 1f;
    public float maxSize = 2f;

    void Start()
    {
        playerSizeSlider.onValueChanged.AddListener(ChangePlayerSize);
    }

    void ChangePlayerSize(float value)
    {
        float scaledValue = Mathf.Clamp(value, minSize, maxSize);
        transform.localScale = new Vector3(scaledValue, scaledValue, scaledValue);
    }
}