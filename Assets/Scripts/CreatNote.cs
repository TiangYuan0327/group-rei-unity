using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml.Serialization;
using System;
using System.IO;
using UnityEditor.Experimental.RestService;

public class CreatNote : MonoBehaviour
{
    
    public GameObject note;
    public Transform canvasTransform;

    [SerializeField]
    NoteData notedata;

    [System.Serializable]
    public class NoteData
    {
        public string noteText;
        public int notenumber;
    }
    private void Start()
    {
        FileStream fs = new FileStream(Application.dataPath + "/SaveTest.txt", FileMode.Open);
        StreamReader sr = new StreamReader(fs);
        notedata.noteText = sr.ReadLine();
        notedata.notenumber = int.Parse(sr.ReadLine());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            PlayerPrefs.SetInt("notenumber", notedata.notenumber);
            FileStream fs = new FileStream(Application.dataPath + "/SaveTest.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(notedata.noteText);
            sw.WriteLine(notedata.notenumber);        
            sw.Close();
            fs.Close();
            Debug.Log("有喔");
        }       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (notedata.notenumber == 1)
            {
                GameObject createNote = Instantiate(note, new Vector2(0,0), Quaternion.identity);
                createNote.transform.SetParent(canvasTransform, false);
            }
        }
    }
}
