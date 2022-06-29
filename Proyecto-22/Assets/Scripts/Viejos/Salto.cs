using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    private static Jugador1 s_jugador;
    public int maxSaltos, maxDashes;
    private void Start()
    {
        s_jugador = FindObjectOfType<Jugador1>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("piso") || collision.gameObject.CompareTag("enemigo"))
        {
            s_jugador.contadorSaltos = maxSaltos;
            s_jugador.contadorDashes = maxDashes;
        }
    }
}
