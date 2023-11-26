using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tail : MonoBehaviour
{
    public GameObject TailRoot;
    public GameObject prevTailRoot;
    public GameObject lookAtObject;

    public float followSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, TailRoot.transform.position, Time.deltaTime * followSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, prevTailRoot.transform.rotation, Time.deltaTime * followSpeed);

        

    }
}
