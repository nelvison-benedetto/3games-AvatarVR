using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppleCollector : MonoBehaviour
{
    private int collectedApples = 0;
    public int totApples = 5;
    public void CollectApple()
    {
        collectedApples++;
        if (collectedApples >= totApples)
        {
            SceneManager.LoadScene("Cotugno");
        } 
    }
}
