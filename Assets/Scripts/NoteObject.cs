using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteObject : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ColorHit") || collision.CompareTag("NormalHit") || collision.CompareTag("LongContinue") || collision.CompareTag("UpHit"))
        {
            Combo.combonumber = 0;
            Combo.judgeText = "Ouch!";
            if(collision.CompareTag("LongContinue")) NoteJudge.playerLife += 0.05f;
            NoteJudge.playerLife -= 0.1f;
            Destroy(collision.gameObject);
        }
    }
}
