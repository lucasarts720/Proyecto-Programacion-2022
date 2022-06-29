using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    LvlMgr LM;
    private void Start()
    {
        LM = FindObjectOfType<LvlMgr>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("jugador"))
        {
            LM.WinGame();
        }
    }
}
