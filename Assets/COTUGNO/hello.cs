using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello!");
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x, 2, 1);
    }


    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnApplicationPause(bool pause)
    {
        
    }

    private void OnMouseDown()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}
