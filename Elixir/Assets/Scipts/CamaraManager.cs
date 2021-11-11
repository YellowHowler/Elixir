using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamaraManager : MonoBehaviour
{
    private Camera camera;

    public float horizontalResolution = 1920f;
    float currentAspect;
    float cameraSize;

    float w;
    float h;
    int size = 3000;
    
    void Awake()
    {
        camera = Camera.main;

        currentAspect = (float) Screen.width / (float) Screen.height;
        cameraSize = horizontalResolution / currentAspect / 50;
        camera.orthographicSize = cameraSize;
    }

    void Update()
    {
        
    }
}
