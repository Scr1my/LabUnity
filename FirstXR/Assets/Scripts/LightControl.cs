using UnityEngine;
using UnityEngine.UI;

public class LightControl : MonoBehaviour
{
    [SerializeField] private Slider lightSlider;
    [SerializeField] private Light light;
    void Start()
    {
        lightSlider.onValueChanged.AddListener(ChangeLightIntensity);
        lightSlider.value = light.intensity;
    }

    private void ChangeLightIntensity(float intensity)
    {
        Debug.Log("Nuovo volume: " + intensity);
        light.intensity = intensity;
    }
}
