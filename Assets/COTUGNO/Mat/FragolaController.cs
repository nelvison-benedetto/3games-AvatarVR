using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragolaController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("collision!");
        startExplosion();
    }

    private void OnCollisionEnter(Collision collision)
    {
        startExplosion();
    }


    public void startExplosion()
    {
        //animazione esplosione
        this.transform.GetComponent<Animator>().SetTrigger("IN");
    }

}
