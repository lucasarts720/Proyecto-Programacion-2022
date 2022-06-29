using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermaBoost : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("jugador"))
        {
            Salto s_piernas = collision.gameObject.GetComponentInChildren<Salto>();
            s_piernas.maxSaltos++;
            s_piernas.maxDashes++;
            Destroy(this.gameObject);
        }
    }
}
