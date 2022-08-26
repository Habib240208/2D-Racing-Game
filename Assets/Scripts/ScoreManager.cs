using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    int score;
    public Text scoretTxt;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Coin")
        {      
            //Adding 1 to the score
            score++;
            //Destroying the coin
            Destroy(coll.gameObject);
            //Transforming our score value to a text
            scoretTxt.text = score.ToString();
        }      
    }
}
