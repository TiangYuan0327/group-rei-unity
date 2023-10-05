using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLong : MonoBehaviour
{
    public GameObject lg;
    private Vector2 vt;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject.Instantiate(lg, new Vector2(0,0),Quaternion.identity);
        }
    }


}
