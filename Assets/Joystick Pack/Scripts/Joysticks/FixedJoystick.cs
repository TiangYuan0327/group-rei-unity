using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJoystick : Joystick
{
    private bool isJudge = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(crash);
        if (collision.CompareTag("bang!"))
        {
            isJudge = true;
        }
        if (transform.GetChild(0).gameObject.CompareTag("LeftHandle") && crash == 1)
        {
            if (((collision.CompareTag("NormalHit") || collision.CompareTag("ColorHit"))))
            {
                if (isJudge)
                {
                    Combo.judgeText = "bang!";
                    AddCombo();
                    Destroy(collision.gameObject);
                } 
                                               
            }
        }
        else if (gameObject.CompareTag("RightJoystick") && crash == 2)
        {
            if ((collision.CompareTag("NormalHit") || collision.CompareTag("ColorHit")))
            {
                if (isJudge)
                {
                    Combo.judgeText = "bang!";
                    AddCombo();
                    Destroy(collision.gameObject);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bang!")) isJudge = false;
    }

    private void AddCombo()
    {
        Combo.combonumber++;
        Debug.Log(Combo.combonumber);
    }
}