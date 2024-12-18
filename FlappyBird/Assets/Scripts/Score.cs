// Fem les importacions necessàries
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Creem la clase de "Score"
public class Score : MonoBehaviour
{
    // Creem la variable per gestionar la puntuació actual.
    public TextMeshProUGUI scoreText;

    // Creem la variable per gestionar la millor puntuació en la interfície de l'usuari.
    public TextMeshProUGUI bestScoreText;

    // Creem la variable per la puntuació actual del jugador.
    private int score;

    // Costructor "Start"
    void Start()
    {
        // Actualitzem el text del "Score" per mostrar la puntuació actual.
        scoreText.text=score.ToString();

        // Obtenim i mostrem la millor puntuació guardada amb PlayerPrefs.
        bestScoreText.text=PlayerPrefs.GetInt("BestScore",0).ToString();
    }

    // Creem un metodè per actualitzar la millor puntuació si la puntuació actual és superior.
    public void UpdateBestScore()
    {
        // Fem la comprovació de si la puntuació actual és superior a la millor puntuació guardada.
        if ( score > PlayerPrefs.GetInt("BestScore"))
        {
            // Actualitzem la millor puntuació guardada amb la puntuació actual si és superior.
            PlayerPrefs.SetInt("BestScore", score);

            // Actualitzem el text del "Score" per mostrar la puntuació actual.
            bestScoreText.text = score.ToString();
        }
    }

    // Creem un metodè per incrementar la puntuació actual i actualitzar l'interfície.
    public void UpdateScore()
    {
        // Incrementem el "score".
        score++;

        // Actualitzem el text del "Score" per mostrar la puntuació actual.
        scoreText.text = score.ToString();

        // Cridem al metodè "UpdateBestScore()".
        UpdateBestScore();
    }
}
