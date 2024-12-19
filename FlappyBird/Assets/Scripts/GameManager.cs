// Fem les importacions necessàriesusing System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Creem i declarem les variables per als Canvas de "GameOver" i "Start"
    public GameObject gameoverCanvas;
    public GameObject startCanvas;

    // Creem i declarem una referència al Rigidbody2D del jugador per al salt
    public Rigidbody2D playerRb;
    public float jumpForce = 5f; // Creem i declarem la força del salt

    void Start()
    {
        // Pausem el temps al començar perquè el joc estigui aturat fins que es premi el botó d'inici.
        Time.timeScale = 0;

        // Creem un condicional per activar el canvas d'inici.
        if (startCanvas != null)
        {
            startCanvas.SetActive(true);
        }

        // Creem un condicional per assegurar que el canvas de "GameOver" estigui desactivat al començament.
        if (gameoverCanvas != null)
        {
            gameoverCanvas.SetActive(false);
        }
    }

    void Update()
    {
        // Creem un condicional per si es detecta un clic o pessionada la tecla "X" per fer el salt
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.X))
        {
            Jump();
        }
    }

    // Creem la funció per iniciar el joc
    public void StartGame()
    {
        // Desactivem el Canvas d'inici.
        if (startCanvas != null)
        {
            startCanvas.SetActive(false);
        }

        // Descongelem el joc.
        Time.timeScale = 1;
    }

    // Creem la funció per acabar la partida
    public void GameOver()
    {
        // Activem el Canvas de "GameOver".
        if (gameoverCanvas != null)
        {
            gameoverCanvas.SetActive(true);
        }

        // Pausem el joc.
        Time.timeScale = 0;
    }

    // Creem la funció per reiniciar la partida
    public void Restart()
    {
        // Recarreguem l'escena actual.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Creem la funció per fer el salt
    void Jump()
    {
        // Verifiquem que el Rigidbody del jugador no sigui null abans d'aplicar el salt
        if (playerRb != null)
        {
            // Actualitzem la velocitat del Rigidbody per incloure la força del salt en l'eix Y
            playerRb.velocity = new Vector2(playerRb.velocity.x, jumpForce);
        }
    }
}
