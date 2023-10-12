using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System;
using System.IO;


public class CreatNote : MonoBehaviour
{
    
    public GameObject note;
    public Transform canvasTransform;

    public string fileName = "/NoteTest.json";
    public NoteData[] songs;

    [SerializeField]
    NoteData notedata;

    [System.Serializable]
    public class NoteData
    {
        //音符種類、出現時機、音符長度、出現位置
        public string noteType;
        public float noteTime;
        public float noteHeight;
        public int noteLocation;
    }
    private void Start()
    {
            
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log(Application.dataPath);
            string filePath = Application.dataPath + "/NoteTest.json";
            if (File.Exists(filePath)) {
                string json = File.ReadAllText(filePath);
                songs = JsonUtility.FromJson<NoteData[]>(json);

                foreach (NoteData song in songs)
                {
                    Debug.Log("Type: " + song.noteType);
                    Debug.Log("Time: " + song.noteTime);
                    Debug.Log("長度: " + song.noteHeight);
                    Debug.Log("位置" + song.noteLocation);
                }
            }
            else
            {
                Debug.Log("not found");
            }

            Debug.Log("有喔");
        }       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
