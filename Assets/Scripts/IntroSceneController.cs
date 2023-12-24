using Flower;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSceneController : MonoBehaviour
{
    FlowerSystem fs;
    // Start is called before the first frame update
    void Start()
    {
        fs = FlowerManager.Instance.CreateFlowerSystem("default", false);
        fs.SetupDialog();
        fs.ReadTextFromResource("intro");   
        fs.RegisterCommand("lock_conversation",(List<string> _params) => {
            //EnterStage.canHit = false;
        } );
        fs.RegisterCommand("release_conversation", (List<string> _params) => {
            //EnterStage.canHit = true;
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            fs.Next();
        }
    }
}
