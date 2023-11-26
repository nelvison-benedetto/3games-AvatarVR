using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollector : MonoBehaviour
{
    private int collectedCoins = 0;
    public int totCoins = 4;
    public void CollectCoin()
    {
        collectedCoins++;
        if (collectedCoins >= totCoins)
        {
            SceneManager.LoadScene("Silva");
        }
    }
}
