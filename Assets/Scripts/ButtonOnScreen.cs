using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonOnScreen : MonoBehaviour
{
    public string tagToControl = "Button";

    private Button button;
    private Camera mainCamera;

    private void Start()
    {
        button = GetComponent<Button>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (gameObject.CompareTag(tagToControl))
        {
            Vector3 screenPoint = mainCamera.WorldToScreenPoint(transform.position);
            bool isVisible = IsPointInScreen(screenPoint);
            button.enabled = isVisible;
        }
    }

    private bool IsPointInScreen(Vector3 screenPoint)
    {
        return screenPoint.x >= 0 && screenPoint.x <= Screen.width &&
               screenPoint.y >= 0 && screenPoint.y <= Screen.height &&
               screenPoint.z > 0;
    }
}