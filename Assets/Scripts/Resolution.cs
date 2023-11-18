using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    private RectTransform canvasRect;
    private void Start()
    {
        canvasRect =GameObject.Find("Canvas").GetComponent<RectTransform>();
        float canvasWidth = canvasRect.rect.width;
        float canvasHeight = canvasRect.rect.height;
        float screenRatio = Screen.width / Screen.height;
        float referenceRatio = canvasWidth / canvasHeight;
        Camera mainCamera = Camera.main;
        mainCamera.orthographicSize *= referenceRatio / screenRatio;
    }
}
