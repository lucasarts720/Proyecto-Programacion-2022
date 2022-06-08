using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LvlMgr : MonoBehaviour
{
    public Text timer;
    public GameObject panelLose;
    public GameObject panelWin;
    public Jugador1 j1;
    float time;
    bool isPlaying;

    private void Start()
    {
        time = 0;
        isPlaying = true;
        j1 = FindObjectOfType<Jugador1>();
    }
    private void Update()
    {
        if (isPlaying == true)
        {
            time += Time.deltaTime;
            DisplayTime(time);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void LoseGame()
    {
        isPlaying = false;
        panelLose.gameObject.SetActive(true);
        Destroy(j1);
    }
    public void WinGame()
    {
        isPlaying = false;
        panelWin.gameObject.SetActive(true);
        Destroy(j1);
    }

    public void LoadLevel(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Salio del juego");
    }
}
