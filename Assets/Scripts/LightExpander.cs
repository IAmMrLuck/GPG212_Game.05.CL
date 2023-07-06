using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightExpander : MonoBehaviour
{
    private UnityEngine.Rendering.Universal.Light2D _light;

    private void Start()
    {
        _light = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
    }
    public void GiveMeLight()
    {
        _light.pointLightOuterRadius = 5;
    }
}
