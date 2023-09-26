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
        GameObject.Find("PostButton").GetComponent<Button>().onClick.AddListener(PostData); //按鈕觸發函式
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
        byte[] postData = System.Text.Encoding.UTF8.GetBytes(jsonData); //轉成utf-8的json格式
        //form.AddField("password", "ybcdefg");
        using (UnityWebRequest request = UnityWebRequest.Post(url, "Post")) 
        {
            request.uploadHandler = new UploadHandlerRaw(postData); //標頭
            request.SetRequestHeader("Content-Type", "application/json");

            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError) //請求失敗
            {
                outputArea.text = request.error;
            }
            else //請求成功
            {
                outputArea.text = request.downloadHandler.text; 
            }
        }
    }
}

