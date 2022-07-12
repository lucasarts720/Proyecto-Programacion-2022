using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : Personaje
{
    public LvlMgr LM;
    public GameObject Trigger;
    public Salto s_piernas;
    public SpriteRenderer sr;
    public Sprite yellow, blue, green;
    public float magnitudSalto = 5;
    public int contadorSaltos;
    public int contadorDashes;
    public int dashVel = 2;
    public bool OnTrigger = false;

    protected override void Awake()
    {
        s_piernas = gameObject.GetComponentInChildren<Salto>();
        sr = GetComponent<SpriteRenderer>();
        LM = FindObjectOfType<LvlMgr>();
        vida = vidaMaxima;
        vidaBarra.maxValue = vidaMaxima;
        vidaBarra.value = vida;
        vidaNumero.text = vida.ToString();
        sr.sprite = yellow;

        base.Awake();
    }

    void Update()
    {
        #region Atacar
        if (Input.GetKeyDown(KeyCode.K))
        {
            Atacar();
        }
        #endregion
        #region Saltar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
        #endregion
        #region Mover
        Movimiento();
        #endregion
        #region Levelear
        levelear();
        #endregion
        #region Interactuar
        if (Input.GetKeyDown(KeyCode.O) && OnTrigger)
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
            rb.velocity = new Vector2(0, magnitudSalto);
            contadorSaltos--;
        }
    }
    void Movimiento()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && contadorDashes>0)
        {
            if (Input.GetKey(KeyCode.A))
            {
                rb.velocity = new Vector2(-dashVel, magnitudSalto/4);
                contadorDashes--;
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.velocity = new Vector2(dashVel, magnitudSalto/4);
                contadorDashes--;
            }

        }

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

    public void levelear()
    {
        if (s_piernas.maxSaltos == 2){
            sr.sprite = blue;
        }
        else if (s_piernas.maxSaltos == 3)
        {
            sr.sprite = green;
        }

    }
    void Interactuar()
    {
        /// codigo
    }
    void Morir()
    {
        LM.LoseGame();
    }
    public void RecibirDMG(int dmg1)
    {
        vida = vida - dmg1;
        vidaBarra.value = vida;
        if (vida > 0) vidaNumero.text = vida.ToString(); else vidaNumero.text = 0.ToString();
    }
}




