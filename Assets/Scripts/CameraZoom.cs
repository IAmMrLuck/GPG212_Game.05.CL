using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public float zoomSpeed = 2f;
    private float targetSize;
    private bool isZooming;

    private float timeElapsed;
    private float lerpDuration = 50f;

    private float newSize;

    private void Start()
    {
        // Store the original orthographic size
        virtualCamera.m_Lens.OrthographicSize = 5f;
        
    }

    public void MakeCameraLarger(float cameraZoom)
    {
        // Start zooming out
        targetSize = cameraZoom;
        isZooming = true;
        timeElapsed = 0f;
    }

    private void Update()
    {
        if (isZooming)
        {
            if(timeElapsed < lerpDuration)
            {
                newSize = Mathf.Lerp(virtualCamera.m_Lens.OrthographicSize, targetSize, timeElapsed / lerpDuration);
                timeElapsed += Time.deltaTime;
            }
            else
            {
                newSize = targetSize; 
            }
            // Smoothly interpolate between current size and target size
           


            // Apply the new size to the camera
            virtualCamera.m_Lens.OrthographicSize = newSize;

            // Check if zooming is complete
            if (Mathf.Approximately(newSize, targetSize))
            {
                isZooming = false;
            }
        }
    }
}