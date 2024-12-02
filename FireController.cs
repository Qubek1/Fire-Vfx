using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public Light pointLight;
    public float minLightIntensity = 0.5f;
    public float maxLightIntensity = 2f;
    public float lightIntensityChangeSpeed = 3f;

    private void Update()
    {
        pointLight.intensity = Mathf.Lerp(minLightIntensity, maxLightIntensity, Mathf.PerlinNoise(0, lightIntensityChangeSpeed * Time.time%100));
    }
}
