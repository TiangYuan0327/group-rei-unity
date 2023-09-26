using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    public bool canBePressed;
    public Text comboNumberText;
    public Text comboJudgeText;
    public static int combonumber;
    public static string judgeText;
    // Start is called before the first frame update
    void Start()
    {
        combonumber = 0;
        judgeText = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        comboNumberText.text = combonumber.ToString();
        comboJudgeText.text = judgeText;
    }
}
