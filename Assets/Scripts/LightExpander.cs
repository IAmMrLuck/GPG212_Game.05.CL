using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightExpander : MonoBehaviour
{
    private Light _light;

    private void Start()
    {
        _light = GetComponent<Light>();
    }
    public void GiveMeLight()
    {
        _light.range = 5;
    }
}
