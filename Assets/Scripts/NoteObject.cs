using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteObject : MonoBehaviour
{
    public Animator player;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ColorHit") || collision.CompareTag("NormalHit") || collision.CompareTag("LongContinue") || collision.CompareTag("UpHit"))
        {
            Combo.combonumber = 0;
            Combo.judgeText = "Ouch!";
            player.SetTrigger("Hurt");
            if(collision.CompareTag("LongContinue")) LifeControl.playerLife += 0.05f;
             LifeControl.playerLife -= 0.1f;
            Destroy(collision.gameObject);
        }
    }
}
