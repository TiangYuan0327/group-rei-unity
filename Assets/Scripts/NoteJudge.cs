using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteJudge : MonoBehaviour
{
    private string jText;
    private float hitTime;
    private bool isLongEndPressed = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if ((Joystick.crash == -1 && gameObject.CompareTag("LeftHandle")) || (gameObject.CompareTag("RightHandle") && Joystick.crash == 1))
        {
            switch (collision.tag)
            {
                case "Crash!":
                case "Smash!":
                case "Bang!":
                case "Boo!":
                case "Ouch!":
                    jText = collision.tag;
                    break;
            }
            if (((collision.CompareTag("NormalHit") || collision.CompareTag("ColorHit"))))
            {
                AddCombo();
                Destroy(collision.gameObject);
            }
            else if (collision.CompareTag("LongStart"))
            {
                AddCombo();
                isLongEndPressed = true;
                Destroy(collision.gameObject);
            }
            else if (collision.CompareTag("LongContinue"))
            {
                hitTime += Time.deltaTime;
                isLongEndPressed = true;
                Debug.Log(hitTime);
                if (hitTime >= 1)
                {    
                    AddCombo();
                    hitTime = 0;
                }
            }
        }     
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("LongEnd") && isLongEndPressed)
        {
            AddCombo();
            Destroy(collision.gameObject);
            isLongEndPressed = false; // 重置标志
        }
    }

    private void AddCombo()
    {
        Debug.Log(jText);
        switch (jText)
        {
            case "Crash!":
            case "Smash!":
            case "Bang!":
                Debug.Log(jText);
                Combo.combonumber++;
                Combo.judgeText = jText;
                Debug.Log(Combo.combonumber);
                break;
            case "Boo!":
            case "Ouch!":
                Combo.combonumber = 0;
                Combo.judgeText = jText;
                Debug.Log (Combo.combonumber);
                break;
            default:
                break;
        }     
    }
}
