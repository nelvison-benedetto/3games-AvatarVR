using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public GameObject thisobject;
    public float velocityCoinRot;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up, velocityCoinRot);
    }
}
