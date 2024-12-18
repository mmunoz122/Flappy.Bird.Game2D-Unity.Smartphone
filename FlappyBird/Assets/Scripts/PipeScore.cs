using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScore : MonoBehaviour
{
    // Creem la variable per representar la selecció de l'audio.
    public AudioSource audioSource; 

    // Creem el metodè per quan l'objecte que representa el jugador toqui
    // una moneda s'ho comuniqui al "Score" i s'incrementeixi la puntuació del jugador.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Fem la comprovació de si ha sigut el personatge, el qual te el "Tag:Player" ha passat per el mig dels dos tubs/"pipe" per incrementar el "Score".
        if ( collision.CompareTag("Player"))
        {
            // Actualitzem la puntuació i cridem al metodè "UpdateScore()" de l'objecte "Score".
            FindAnyObjectByType<Score>().UpdateScore();

            // Reproduïm l'àudio afegit al component "AudioSource".
            audioSource.Play();
        }
    }
}
 