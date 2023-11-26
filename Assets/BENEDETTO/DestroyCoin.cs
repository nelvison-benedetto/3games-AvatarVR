using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin: MonoBehaviour
{
    public GameObject objecttodestroy;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.gameObject.GetComponent<CoinCollector>().CollectCoin();
            Destroy(gameObject);
        }
    }
}
