// Fem les importacions necessàries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

// Creem la clase de "GameManager"
public class GameManager : MonoBehaviour
{
    // Creem la variable del component "GameObject" que gestionara el "Canvas".
    public GameObject gameoverCanvas;

    // Costructor "Start"
    void Start()
    {
        // Restablim la velocitat del temps al valor normal de "1".
        Time.timeScale = 1;
    }

    // Costructor "Update"
    void Update()
    {
        // Constructor buit.
    }

    // Costructor "GameOver" el qual ens permetrà finalitzar la partida al perdre, osigui al caure
    public void GameOver()
    {
        // Activem el "Canvas" de "GameOver".
        gameoverCanvas.SetActive(true);

        // Pausem el temps del joc.
        Time.timeScale = 0;
    }

    // Costructor "Restart" el qual ens permetrà reniciar la partida
    public void Restart()
    {
        // Recarreguem l'escena actual per reiniciar la partida.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
