// Fem les importacions necessàries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creem la clase de "FlappyBird"
public class FlappyBird : MonoBehaviour
{
    // Creem la variable per definir la velocitat de moviment de l'objecte, li donarem un valor inicial de 2.
    public float velocity = 2;

    // Creem la variable per el component "Rigidbody2D" que controlara la física en "2D".
    public Rigidbody2D rb2D;

    // Creem la variable per establir la velocitat de rotació de l'objecte, li donarem un valor inicial de 25.
    public float rotationSpeed = 25;

    // Creem la variable per el component "AudioSource" per gestionar els sons de l'objecte.
    public AudioSource audioSource;

    // Creem la variable per el component "Animator" per controlar les animacions de l'objecte.
    private Animator animator; 

    // Costructor "Start"
    void Start()
    {
        // Declarem l'obtenció de la animació del personatge "FlappyBird".
        animator = GetComponent<Animator>(); 
    }

    // Costructor "Update"
    void Update()
    {
        // Fem la comprovació del que farà el personatge si es prem el botó esquerre del ratolí.
        if (Input.GetMouseButtonDown(0))
        {
            // Realitzem el moviment cap amunt amb la velocitat indicada.
            rb2D.velocity = Vector2.up * velocity;
        }

        // Fem la rotació de l'objecte al voltant de l'eix "Z" segons la seva velocitat "Vertical".
        transform.rotation = Quaternion.Euler(0, 0, rb2D.velocity.y * rotationSpeed * Time.deltaTime * 100);
    }
 
    // Creem el metodè del control de la colisió del personatge amb els elements que tenen colisió "2D"
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Finalitzem el joc cridant al mètode "GameOver()" del "GameManager".
        FindAnyObjectByType<GameManager>().GameOver();

        // Reproduïm l'àudio afegit al component "AudioSource".
        audioSource.Play();

        // Cridem a l'animació de la caiguda mitjançant el trigger "Hit".
        animator.SetTrigger("Hit");

    }
}
