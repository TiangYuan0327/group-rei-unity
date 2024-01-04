using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartPage : MonoBehaviour
{
    public GameObject loginBackground;
    public GameObject signupBackground;

    public void Login()
    {



    }

    public void Signup()
    {
        GameObject.Find("LoginBackground").SetActive(false);
        GameObject.Find("SignupBackground").SetActive(true);
    }




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
