using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    public float zoomOutSize = 8f;
    public float zoomSpeed = 2f;

    private float originalSize;
    private float targetSize;
    private bool isZooming;

    private void Start()
    {
        // Store the original orthographic size
        originalSize = virtualCamera.m_Lens.OrthographicSize;
        targetSize = originalSize;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Start zooming out
            targetSize = zoomOutSize;
            isZooming = true;
        }
    }

    private void Update()
    {
        if (isZooming)
        {
            // Smoothly interpolate between current size and target size
            float newSize = Mathf.Lerp(virtualCamera.m_Lens.OrthographicSize, targetSize, zoomSpeed * Time.deltaTime);

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