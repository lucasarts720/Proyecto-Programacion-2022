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
            Jugador1 j1 = collision.gameObject.GetComponent<Jugador1>();
            j1.contadorSaltos = j1.contadorSaltos++;
            j1.contadorDashes = j1.contadorDashes++;
            s_piernas.maxSaltos++;
            s_piernas.maxDashes++;
            Destroy(this.gameObject);
        }
    }
}
