using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "strawberry")
        {
            Invoke("NextLevel",3f);
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Benedetto");
    }


}
