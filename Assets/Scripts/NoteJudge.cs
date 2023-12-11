using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteJudge : MonoBehaviour
{
    private string jText;
    private float hitTime;
    private bool isLongEndPressed = false;
    private bool gameState;

    public AudioClip hitnote;
    public Animator player;
    
    

    private void Start()
    {
        
        gameState = true;
    }

    private void Update()
    {

    }

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
                player.SetTrigger("Attack");
                Destroy(collision.gameObject);
            }
            else if (collision.CompareTag("LongContinue"))
            {
                if (jText == "Boo!" || jText == "Ouch!") LifeControl.playerLife += 0.05f;
                AddCombo();
                player.SetTrigger("Slide");
                Destroy(collision.gameObject);            
            }
            else if (collision.CompareTag("UpHit"))
            {
                player.SetTrigger("UpAttack");
                if (jText == "Crash!")
                {
                    jText = "Bang!";
                    AddCombo();
                    Destroy(collision.gameObject) ;
                }
                else if(jText == "Bang!")
                {
                    jText = "Crash!";
                    AddCombo();
                    Destroy(collision.gameObject);
                }
                else
                {
                    AddCombo();
                    Destroy(collision.gameObject);
                }
            }
        }            
    }

    private void AddCombo()
    {
        Debug.Log(jText);
        GetComponent<AudioSource>().PlayOneShot(hitnote);
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
                LifeControl.playerLife -= 0.1f;
                Debug.Log (Combo.combonumber);
                player.SetTrigger("Hurt");
                break;
            default:
                break;
        }     
    }
}
