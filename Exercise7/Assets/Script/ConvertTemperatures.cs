using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Program will convert Temps from F to C and vice versa
/// </summary>
public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        const int FreezingPoint = 32;
        const int Nine = 9;
        const int Five = 5;

        int tempInF = 0;
        int calcCelcius = 0;
        int calcFahrenheit = 0;

        Debug.Log("This is my Fahrenheit temp: " + tempInF);

        calcCelcius = (tempInF - FreezingPoint) / (Nine / Five);

        Debug.Log("This is the conversion from F to C " + calcCelcius + "°C");
        
        
    }


}
