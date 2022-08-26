using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoins : MonoBehaviour
{

    public AudioSource CollectCoinSound;
    void OnCollisionEnter2D(Collision2D coin)
    {
        if(coin .collider.name == "Player")
        {
            Coins.Score0 += 1;
            Destroy(this.gameObject);
            CollectCoinSound.Play();
        }
    }
}
