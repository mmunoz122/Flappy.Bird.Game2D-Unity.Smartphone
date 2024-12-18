// Fem les importacions necessàries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creem la clase de "Pipe"
public class Pipe : MonoBehaviour
{
    // Creem la variable per controlar la velocitat de l'objecte.
    public float speed = 0.75f;

    // Costructor "Update"
    void Update()
    {
        // Fem el moviment de l'objecte cap a l'esquerra segons la velocitat indicada.
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
