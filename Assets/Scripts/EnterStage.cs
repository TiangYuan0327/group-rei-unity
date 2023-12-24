using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnterStage: MonoBehaviour
{
    //public static bool canHit = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Stage()
    {
            SceneManager.LoadScene("SampleScene");
        
    }
    public void exit()
    {
        Application.Quit();
        
    }

    public void EnterDashboard()
    {
        SceneManager.LoadScene("Main");
    }

    public void EnterLogin()
    {
        SceneManager.LoadScene("Login");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
