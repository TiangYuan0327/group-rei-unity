using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.SceneManagement;



public class LoginRequest : MonoBehaviour
{
    InputField outputArea;
    public InputField account;
    public InputField password;
    // Start is called before the first frame update
    void Start()
    {

        GameObject.Find("Login").GetComponent<Button>().onClick.AddListener(PostData);

    }

    // Update is called once per frame
    void Update()
    {

    }

    async void PostData()
    {
        StartCoroutine(PostRequest());

    }

    IEnumerator PostRequest()
    {
        string url = "http://127.0.0.1:5000/account/login";
        string jsonData = "{\"uid\": \"" + account.text + "\", \"password\": \"" + password.text + "\" }";
        byte[] postData = System.Text.Encoding.UTF8.GetBytes(jsonData);

        using (UnityWebRequest request = UnityWebRequest.Post(url, "Post"))
        {
            request.uploadHandler = new UploadHandlerRaw(postData);
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log("登入失敗");

            }
            else
            {
                Debug.Log("登入成功");
                SceneManager.LoadScene("Main");

            }
        }
    }
    public void back()
    {
        SceneManager.LoadScene("StartPage");



    }
}
