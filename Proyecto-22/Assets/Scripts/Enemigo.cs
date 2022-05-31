using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Personaje
{
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vida = vidaMaxima;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("jugador"))
        {   
            Jugador s_jugador = collision.gameObject.GetComponent<Jugador>();
            s_jugador.vida -= daño;
        }
    }
}
