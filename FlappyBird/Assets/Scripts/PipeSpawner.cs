// Fem les importacions necessàries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Creem la clase de "PipeSpawner"
public class PipeSpawner : MonoBehaviour
{
    // Creem la variable per el "Prefab" del tub que es vol instanciar.
    public GameObject pipePrefab;

    // Creem la variable per definir l'interval de variació de l'altura i li donem el valor inicial de "0.5".
    public float heightRange = 0.5f;
    // Creem la variable per establir el temps màxim que pot passar abans de generar un nou tub i li donem ll valor inicial de "1.75" segons.
    public float maxTime = 1.75f;

    // Creem la variable del contador del temps recorregut i controlar la creació dels tubs.
    private float timer;

    // Costructor "Start"
    void Start()
    {
        // Cridem al metodè "SpawnPipe()".
        SpawnPipe();
    }

    // Costructor "Update"
    void Update()
    {
        // Incrementem el contador amb el temps recorregut.
        timer += Time.deltaTime;

        // Fem la comprovació de si el temps recorregut supera el temps màxim per generar un nou tub.
        if (timer > maxTime)
        {
            // Cridem al metodè "SpawnPipe()".
            SpawnPipe();

            // Reniciem el contador.
            timer = 0;
        }
    }

    // Creem un metodè per generar un nou tub en una posició aleatòria dins del rang.
    public void SpawnPipe()
    {
        // Fem el calcul de la posició de generació amb un desplaçament vertical aleatori.
        Vector3 spawnPosition = transform.position + new Vector3(0,Random.Range(-heightRange, heightRange));

        // Instanciem el tub a la posició calculada sense rotació.
        GameObject newPipe;
        newPipe = Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        // Destruim el tub després de 15 segons.
        Destroy(newPipe, 15f);
    }
}
