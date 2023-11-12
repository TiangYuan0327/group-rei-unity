using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Networking;

public class CreatNote : MonoBehaviour
{
    public GameObject NoteType1Prefab;
    public GameObject NoteType2Prefab;
    public GameObject NoteType3Prefab;
    public GameObject NoteType4Prefab;

    public Transform canvasTransform;
    private void Start()
    {
        StartCoroutine(GetTextForStreamingAssets(Application.streamingAssetsPath + "/Song" + "/Test.txt"));
    }
    void Update()
    {
        
    }
    public IEnumerator CreateNoteDelayed(string noteKind, float noteStart, float noteEnd, string noteLocation)
    {
        float delay = noteStart;
        yield return new WaitForSeconds(delay);
        
        if(noteStart != noteEnd)
        {
            while(Time.time < noteEnd)
            {
                GameObject newNote = CreateNote(noteKind, noteLocation);
                if (newNote != null)
                {
                    newNote.transform.SetParent(canvasTransform, false);
                }

                yield return new WaitForSeconds(0.1f);
            }
            
        }
        else
        {
            GameObject newNote = CreateNote(noteKind, noteLocation);
            if (newNote != null)
            {
                newNote.transform.SetParent(canvasTransform, false);
            }
        }
        
    }

    public GameObject CreateNote(string noteKind, string noteLocation)
    {
        GameObject newNote = null;
        Vector2 noteVect = Vector2.zero;
        switch (noteLocation)
        {
            case "1":
                noteVect = new Vector2(-500,450);
                break;
            case "2":
                noteVect = new Vector2(-412.5f, 450);
                break;
            case "3":
                noteVect = new Vector2(-325, 450);
                break;
            case "4":
                noteVect = new Vector2(325, 450);
                break;
            case "5":
                noteVect = new Vector2(412.5f, 450);
                break;
            case "6":
                noteVect = new Vector2(500, 450);
                break;
        }
        switch (noteKind)
        {
            case "1":
                newNote = Instantiate(NoteType1Prefab, noteVect, Quaternion.identity);
                break;
            case "2":
                newNote = Instantiate(NoteType2Prefab, noteVect, Quaternion.identity);
                break;
            case "3":
                newNote = Instantiate(NoteType3Prefab, noteVect, Quaternion.identity);
                break;
            case "4":
                newNote = Instantiate(NoteType4Prefab, noteVect, Quaternion.identity);
                break;
        }
        return newNote;
    }

    public IEnumerator GetTextForStreamingAssets(string path)
    {
        using(UnityWebRequest www = UnityWebRequest.Get(path))
        {
            yield return www.SendWebRequest();
            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Failed to download file. Error: " + www.error);
            }
            else
            {
                string textContent = www.downloadHandler.text;
                string[] noteText = textContent.Split('\n');

                foreach (string line in noteText)
                {
                    if (line.Length >= 10)
                    {
                        string noteKind = line.Substring(0, 1);
                        float noteStart = float.Parse(line.Substring(1, 4)) / 10f;
                        float noteEnd = float.Parse(line.Substring(5, 4)) / 10f;
                        string noteLocation = line.Substring(9, 1);

                        StartCoroutine(CreateNoteDelayed(noteKind, noteStart, noteEnd, noteLocation));
                    }
                    else
                    {
                        Debug.Log("讀取結束");
                    }
                }
            }
        }
    }
}
