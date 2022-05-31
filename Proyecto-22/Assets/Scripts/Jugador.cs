using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje
{
    public bool OnTrigger = false;
    public GameObject Trigger;
    public SpriteRenderer sr;
    public float magnitudSalto = 5;
    public int contadorSaltos = 2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        vida = vidaMaxima;
    }


    void Update()
    {
        #region Atacar
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.K))
        {
            Atacar();
        }
        #endregion
        #region Saltar
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)){
            Saltar();
        }
        #endregion
        #region Mover
        Movimiento();
        #endregion
        #region Interactuar
        if (Input.GetKeyDown(KeyCode.E) && OnTrigger)
        {
            Interactuar();
        }
        #endregion
        #region Morir
        if (vida <= 0)
        {
            Morir();
        }
        #endregion
    }

    void Atacar()
    {
        ///codigo para atacar
    }
    void Saltar()
    {
        if (contadorSaltos > 0)
        {
            rb.velocity = new Vector2(0,magnitudSalto);
            contadorSaltos--;
        }
    }
    void Movimiento()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector3 movimiento = new Vector3(inputX, 0, 0);
        rb.transform.Translate(movimiento * velocidad * Time.deltaTime);

        if (inputX > 0)
        {
            sr.flipX = false;
        }
        if (inputX < 0)
        {
            sr.flipX = true;
        }
    }
    void Interactuar()
    {
        /// codigo
    }
    void Morir()
    {

    }
}

       

