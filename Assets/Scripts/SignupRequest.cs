using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using UnityEngine.UI;
using System.Net.Http;
using UnityEngine.SceneManagement;



public class SignupRequest : MonoBehaviour
{
    public InputField uid;
    public InputField name;
    public InputField email;
    public InputField phone;
    public InputField birthday;
    public InputField password;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Register").GetComponent<Button>().onClick.AddListener(PostData);

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
        string url = "http://127.0.0.1:5000/account/signup";
        string jsonData = "{\"uid\": \"" + uid.text + "\", " +
			"\"name\": \"" + name.text + "\", " +
			"\"email\": \"" + email.text + "\", " +
			"\"phone\": \"" + phone.text + "\", " +
			"\"password\": \"" + birthday.text + "\", " +
			"\"birthday\": \"" + password.text + "\" }";
        byte[] postData = System.Text.Encoding.UTF8.GetBytes(jsonData);

        using (UnityWebRequest request = UnityWebRequest.Post(url, "Post"))
        {
            request.uploadHandler = new UploadHandlerRaw(postData);
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
            {

            }
            else
            {

            }
        }
    }
    public void back()
    {
        SceneManager.LoadScene("StartPage");



    }
}
