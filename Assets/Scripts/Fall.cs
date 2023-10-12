using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public float beatTample;
    public bool hasStart;

    void Start()
    {
        beatTample = beatTample / 60f;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            hasStart = true;
        }
        else
        {
            transform.position -= new Vector3(0f, beatTample * Time.deltaTime, 0f);
        }
    }
}
