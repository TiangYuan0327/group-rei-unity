using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    private RectTransform canvasRect;
    public GameObject Lg;
    private void Start()
    {
        canvasRect =GameObject.Find("Canvas").GetComponent<RectTransform>();
        float canvasWidth = canvasRect.rect.width;
        float canvasHeight = canvasRect.rect.height;
        float screenRatio = Screen.width / (float)Screen.height;
        float referenceRatio = canvasWidth / canvasHeight;
        Camera mainCamera = Camera.main;
        mainCamera.orthographicSize *= referenceRatio / screenRatio;

    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            GameObject createdObject = Instantiate(Lg, new Vector2(500,0), Quaternion.identity);
            createdObject.transform.SetParent(canvasRect.transform, false);
        }
    }

}
