using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Personaje : MonoBehaviour
{
    #region Variables
    public float velocidad = 1;
    public int vida, vidaMaxima, dmg;
    public Rigidbody2D rb;
    #endregion

    #region Barras
    public Text vidaNumero;
    public Slider vidaBarra;
    #endregion
    private void Start()
    {
        #region Set de Barras
        vidaBarra.maxValue = vidaMaxima;
        #endregion
    }
}