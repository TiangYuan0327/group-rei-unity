using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource music;
    public bool startPlaying;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoteHit() {
        Debug.Log("擊中");
    }
    public void NoteMissed() {
        Debug.Log("Miss");
    }
}
