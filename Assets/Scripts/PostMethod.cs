using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.Profiling.Memory.Experimental;
using UnityEngine.PlayerLoop;
using System.Net;
//using UnityEditor.PackageManager.Requests;

public class PostMethod : MonoBehaviour
{
    InputField outputArea;
    public InputField account;
    public InputField password;
    //PlayerData data;
    void Start()
    {
        outputArea = GameObject.Find("OutputArea").GetComponent<InputField>();
        GameObject.Find("PostButton").GetComponent<Button>().onClick.AddListener(PostData); //���sĲ�o�禡
    }

    void PostData()
    {
        StartCoroutine(PostData_Coroutine());
    }

    IEnumerator PostData_Coroutine()
    {
        outputArea.text = "Loading...";
        string url = "http://localhost:5000/account/login";

        //string jsonData = "{\"uid\": \"botoUdon\", \"password\": \"ybcdefg\"}";
        string jsonData = "{\"uid\": \"" + account.text + "\", \"password\": \"" + password.text + "\" }";
        byte[] postData = System.Text.Encoding.UTF8.GetBytes(jsonData); //�নutf-8��json�榡
        //form.AddField("password", "ybcdefg");
        using (UnityWebRequest request = UnityWebRequest.Post(url, "Post")) 
        {
            request.uploadHandler = new UploadHandlerRaw(postData); //���Y
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError) //�ШD����
            {
                outputArea.text = request.error;
            }
            else //�ШD���\
            {
                outputArea.text = request.downloadHandler.text; 
            }
        }
    }
}

