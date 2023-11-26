using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCube : MonoBehaviour
{
    public GameObject playerGO;
    float followSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerGO.transform.position, Time.deltaTime * followSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, playerGO.transform.rotation, Time.deltaTime * followSpeed);



    }
}
