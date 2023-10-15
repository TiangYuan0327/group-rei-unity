using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterStage : MonoBehaviour
{
    public static bool canHit = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Stage()
    {
        if (canHit)
        {
            Destroy(GameObject.Find("DefaultDialogPrefab(Clone)"));
            SceneManager.LoadScene("SampleScene");
        }
        
    }
    public void exit()
    {
        if (canHit)
        {
            Application.Quit();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
