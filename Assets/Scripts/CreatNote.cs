using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System;
using System.IO;
using UnityEngine.UI;

public class CreatNote : MonoBehaviour
{
    public GameObject NoteType1Prefab;
    public GameObject NoteType2Prefab;
    public GameObject NoteType3Prefab;
    public GameObject NoteType4Prefab;

    public Transform canvasTransform;
    private void Start()
    {
        string filePath = Application.dataPath + "/Test.txt";
        if (File.Exists(filePath))
        {
            string[] readText = File.ReadAllLines(filePath);

            foreach (string line in readText)
            {
                if (line.Length >= 10)
                {
                    string noteKind = line.Substring(0, 1);
                    float noteStart = float.Parse(line.Substring(1, 4));
                    float noteEnd = float.Parse(line.Substring(5, 4));
                    string noteLocation = line.Substring(9, 1);
                    Debug.Log("種類:" + noteKind);
                    Debug.Log("開始時間:" + noteStart);
                    Debug.Log("結束時間:" + noteEnd);
                    Debug.Log("生成位置:" + noteLocation);

                    GameObject newNote = CreateNote(noteKind, noteStart, noteEnd, noteLocation);
                    if (newNote != null)
                    {
                        newNote.transform.SetParent(canvasTransform, false);
                        newNote.transform.localPosition = Vector3.zero;
                    }
                }
                else
                {
                    Debug.Log("資料長度不對");
                }
            }
        }
        else
        {
            Debug.Log("檔案不存在");
        }
    }
    void Update()
    {
        
    }
    public GameObject CreateNote(string noteKind, float noteStart, float noteEnd, string noteLocation)
    {
        GameObject newNote = null;

        switch (noteKind)
        {
            case "1":
                newNote = Instantiate(NoteType1Prefab, Vector3.zero, Quaternion.identity);
                break;
            case "2":
                newNote = Instantiate(NoteType2Prefab, Vector3.zero, Quaternion.identity);
                break;
            case "3":
                newNote = Instantiate(NoteType3Prefab, Vector3.zero, Quaternion.identity);
                break;
            case "4":
                newNote = Instantiate(NoteType4Prefab, Vector3.zero, Quaternion.identity);
                break;
        }
        /*
        if (noteKind == "1")
        {
            newNote = Instantiate(NoteType1Prefab, Vector3.zero, Quaternion.identity);
            
        }
        else if (noteKind == "2")
        {
            newNote = Instantiate(NoteType2Prefab, Vector3.zero, Quaternion.identity);
        }
        else if (noteKind == "3")
        {
            newNote = Instantiate(NoteType3Prefab, Vector3.zero, Quaternion.identity);
        }
        else if (noteKind == "4")
        {
            newNote = Instantiate(NoteType4Prefab, Vector3.zero, Quaternion.identity);
        }
        */

        return newNote;
    }
}
