using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public float beatTample;
    public bool hasStart;


    // Start is called before the first frame update
    void Start()
    {
        beatTample = beatTample / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            hasStart = true;
        }
        else
        {
            transform.position -= new Vector3(0f, beatTample * Time.deltaTime, 0f);
            //transform.localScale += new Vector3(beatTample / 1800, beatTample / 1800, beatTample / 1800);
        }
    }
}
