using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightExpander : MonoBehaviour
{
    [SerializeField] private UnityEngine.Rendering.Universal.Light2D _light;

    private void Start()
    {
        _light = GetComponent<UnityEngine.Rendering.Universal.Light2D>();
    }
    public void LightExpansion(float outerRadius)
    {
        _light.pointLightOuterRadius = outerRadius;
    }
}
