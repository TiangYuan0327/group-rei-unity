using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartPage : MonoBehaviour
{
    public GameObject toSignup;
    public GameObject toLogin;

    public void Login()
    {
        SceneManager.LoadScene("login");



    }

    public void Signup()
    {
        SceneManager.LoadScene("signup");



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
