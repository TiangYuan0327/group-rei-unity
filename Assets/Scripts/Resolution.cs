using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    public float referenceScreenWidth = 1800f; 
    public float referenceScreenHeight = 900f; 

    private void Start()
    {
        float screenRatio = Screen.width / (float)Screen.height;
        float referenceRatio = referenceScreenWidth / referenceScreenHeight;
        Debug.Log(screenRatio);
        Debug.Log(referenceRatio);

        Camera mainCamera = Camera.main;
        mainCamera.orthographicSize *= referenceRatio / screenRatio;
        Debug.Log(mainCamera.orthographicSize);
    }
}
