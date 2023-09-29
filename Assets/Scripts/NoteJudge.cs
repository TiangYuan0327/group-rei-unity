using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteJudge : MonoBehaviour
{
    private string jText;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Joystick.crash == -1 && gameObject.CompareTag("LeftHandle"))
        {
            if (collision.CompareTag("Crash!") || collision.CompareTag("Smash!") || collision.CompareTag("Bang!") || collision.CompareTag("Boo!") || collision.CompareTag("Ouch!"))
            {
                jText = collision.gameObject.name;
            }

            if (((collision.CompareTag("NormalHit") || collision.CompareTag("ColorHit"))))
            {
                if (jText == "Crash!" || jText == "Smash!" || jText == "Bang!")
                {
                    AddCombo();
                    Destroy(collision.gameObject);
                }
                else if (jText == "Boo!" || jText == "Ouch!")
                {
                    ClearCombo();
                    Destroy(collision.gameObject);
                }
            }
        }
        else if (gameObject.CompareTag("RightHandle") && Joystick.crash == 1)
        {
            if (collision.CompareTag("Crash!") || collision.CompareTag("Smash!") || collision.CompareTag("Bang!") || collision.CompareTag("Boo!") || collision.CompareTag("Ouch!"))
            {
                jText = collision.gameObject.name;
            }

            if (((collision.CompareTag("NormalHit") || collision.CompareTag("ColorHit"))))
            {
                if (jText == "Crash!" || jText == "Smash!" || jText == "Bang!")
                {
                    AddCombo();
                    Destroy(collision.gameObject);
                }
                else if (jText == "Boo!" || jText == "Ouch!")
                {
                    ClearCombo();
                    Destroy(collision.gameObject);
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
    }
}
