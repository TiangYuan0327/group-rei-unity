using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteObject : MonoBehaviour
{
    /*private string jText;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Crash!")) jText = "Crash!";
        else if (collision.CompareTag("Smash!")) jText = "Smash!";
        else if (collision.CompareTag("Bang!")) jText = "Bang!";
        else if (collision.CompareTag("Boo!")) jText = "Boo!";
        else if (collision.CompareTag("Ouch!")) jText = "Ouch!";

        if (collision.CompareTag("LeftHandle") && Joystick.crash == 1)
        {
            if (((gameObject.CompareTag("NormalHit") || gameObject.CompareTag("ColorHit"))))
            {
                if (jText != null && (jText == "Crash!" || jText == "Smash!" || jText == "Bang!"))
                {
                    AddCombo();
                    Destroy(gameObject);
                }
                else if (jText != null && (jText == "Boo!" || jText == "Ouch!"))
                {
                    ClearCombo();
                    Destroy(gameObject);
                }
            }
        }
        else if (collision.CompareTag("RightHandle") && Joystick.crash == 2)
        {
            if (gameObject.CompareTag("NormalHit") || gameObject.CompareTag("ColorHit"))
            {
                if (jText != null && (jText == "Crash!" || jText == "Smash!" || jText == "Bang!"))
                {
                    AddCombo();
                    Destroy(gameObject);
                }
                else if (jText != null && (jText == "Boo!" || jText == "Ouch!"))
                {
                    ClearCombo();
                    Destroy(gameObject);
                }
            }
        }
    }

    private void AddCombo()
    {
        Combo.combonumber++;
        Combo.judgeText = jText;
        Debug.Log(Combo.combonumber);
    }

    private void ClearCombo()
    {
        Combo.combonumber = 0;
        Combo.judgeText = jText;
        Debug.Log(Combo.combonumber);
    }*/
}
