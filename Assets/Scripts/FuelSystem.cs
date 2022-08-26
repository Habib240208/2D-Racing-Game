using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelSystem : MonoBehaviour
{
    public float startFuel;
    public float maxFuel;
    public float fuelComsumptionRate;

    

    public Slider fuelIndicatorSld;
    public Text fuelIndicatorTxt;

    void Start()
    {
        if (startFuel > maxFuel)
        {
            startFuel = maxFuel;

            fuelIndicatorSld.maxValue = maxFuel;
            UpdateUI();

        }
    }


    public void ReduceFuel()
    {
        startFuel -= Time.deltaTime * fuelComsumptionRate;
        UpdateUI();
    }

    void UpdateUI()
    {
        fuelIndicatorSld.value = startFuel;
        fuelIndicatorTxt.text = "Fuel Left:" + startFuel.ToString("0") + " %";

        if (startFuel <= 0)
        {
            startFuel = 0;
            fuelIndicatorTxt.text = "Out of Gas!";
        }
    }
}
