using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedJoystick : Joystick
{
    private string jText;
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(crash);
        if (collision.CompareTag("Crash!")) jText = "Crash!";
        else if (collision.CompareTag("Smash!")) jText = "Smash!";
        else if (collision.CompareTag("Bang!")) jText = "Bang!";
        else if (collision.CompareTag("Boo!")) jText = "Boo!";

        if (transform.GetChild(0).gameObject.CompareTag("LeftHandle") && crash == 1)
        {
            if (((collision.CompareTag("NormalHit") || collision.CompareTag("ColorHit"))))
            {
                if (jText != null)
                {
                    Combo.judgeText = jText;
                    AddCombo();
                    Destroy(collision.gameObject);
                }
            }            
        }
        else if (transform.GetChild(0).gameObject.CompareTag("RightHandle") && crash == 2)
        {
            if (collision.CompareTag("NormalHit") || collision.CompareTag("ColorHit"))
            {
                if (jText != null)
                {
                    Combo.judgeText = jText;
                    AddCombo();
                    Destroy(collision.gameObject);
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Boo!")) jText = "ouch";
    }

    private void AddCombo()
    {
        Combo.combonumber++;
        Debug.Log(Combo.combonumber);
    }
}