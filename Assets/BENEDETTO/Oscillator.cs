using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startPos;
    [SerializeField] Vector3 movemVec;  //direzione oscillazione
    [SerializeField][Range(0, 1)] float movemFact; //forza oscillazione
    [SerializeField] float period = 2f;  //tempo di socillazione

    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (period <= Mathf.Epsilon) { return; }
        float cycles = Time.time / period;  //ottiene numero oscillazioni complete avvenute
        const float tau = Mathf.PI * 2;  //formula per ottenere costante matematica tau (cost value of 6.283)

        float rawSinWave = Mathf.Sin(cycles * tau);  //going from -1 to 1
        if (rawSinWave > 0.5f) Debug.Log(rawSinWave);

        movemFact = (rawSinWave + 1f) / 2f; //recalculated to go from 0 to 1 so its cleaner

        Vector3 offset = movemVec * movemFact; // Corrected "offeset" to "offset"
        transform.position = startPos + offset;  //aggiorna la pos dell'obj crando cosi il movimento oscillatorio
    }
}



