using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeControl : MonoBehaviour
{
    public static float playerLife;
    public static bool gameState;
    public Slider UILife;
    public GameObject fillArea;
    public Text playerLifeText;
    public GameObject exitgame;

    // Start is called before the first frame update
    void Start()
    {
        playerLife = 1;
        gameState = true;
    }

    // Update is called once per frame
    void Update()
    {
        UILife.value = LifeControl.playerLife;
        playerLifeText.text = (((int)Mathf.Round((UILife.value * 1000)))).ToString();
        if (LifeControl.playerLife <= 0)
        {
            fillArea.SetActive(false);
            exitgame.SetActive(true);
            gameState = false;
            UILife.value = 0;
        }
        else if (LifeControl.playerLife >= 1) LifeControl.playerLife = 1;
    }
}
