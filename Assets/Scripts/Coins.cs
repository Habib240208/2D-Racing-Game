using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public static int Score0 = 0;
    public Text Score;



    // Update is called once per frame
    void Update()
    {
        Score.text = "Score:" + Score0;
    }
}
