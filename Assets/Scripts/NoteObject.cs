using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteObject : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ouch!"))
        {
            Combo.combonumber = 0;
            Combo.judgeText = "Ouch!";
            Destroy(gameObject);
        }
    }
}
