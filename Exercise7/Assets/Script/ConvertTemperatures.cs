using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Program will convert Temps from F to C and vice versa
/// </summary>
public class ConvertTemperatures : MonoBehaviour
{
    const int FreezingPoint = 32;
    const int Nine = 9;
    const int Five = 5;
    // Start is called before the first frame update
    void Start()
    {


        int tempInF = 0;
        int calcCelcius = 0;
        int calcFahrenheit = 0;

        float tempInFf = 0;
        float calcCelciusF = 0;
        float calcFahrenheitF = 0;

        Debug.Log("This is my Fahrenheit temp: " + tempInF);

        calcCelcius = ConvertToCelcius(tempInF);
        Debug.Log("This is the conversion from F to C " + calcCelcius + "°C");
        
        ConvertToFanreinheit(calcCelcius);
        Debug.Log("This is the conversion from C to F " + calcFahrenheit + "°F");


        Debug.Log("");
        Debug.Log("----------------------------------------------------");
        tempInF = 32;
        Debug.Log("This is my Fahrenheit temp: " + tempInF);

        calcCelcius = ConvertToCelcius(tempInF);
        Debug.Log("This is the conversion from F to C " + calcCelcius + "°C");

        ConvertToFanreinheit(calcCelcius);
        Debug.Log("This is the conversion from C to F " + calcFahrenheit + "°F");

        Debug.Log("");
        Debug.Log("----------------------------------------------------");
        tempInF = 212;
        Debug.Log("This is my Fahrenheit temp: " + tempInF);

        calcCelcius = ConvertToCelcius(tempInF);
        Debug.Log("This is the conversion from F to C " + calcCelcius + "°C");

        ConvertToFanreinheit(calcCelcius);
        Debug.Log("This is the conversion from C to F " + calcFahrenheit + "°F");


        Debug.Log("This is my Fahrenheit temp: " + tempInF);

        calcCelcius = ConvertToCelcius(tempInF);
        Debug.Log("This is the conversion from F to C " + calcCelcius + "°C");

        ConvertToFanreinheit(calcCelcius);
        Debug.Log("This is the conversion from C to F " + calcFahrenheit + "°F");


        Debug.Log("");
        Debug.Log("----------------------------------------------------");
        tempInFf = 32;
        Debug.Log("This is my Fahrenheit temp (float): " + tempInFf);

        calcCelciusF = ConvertToCelciusFloat(tempInFf);
        Debug.Log("This is the conversion from F to C " + calcCelciusF + "°C");

        ConvertToFanreinheitFloat(calcCelciusF);
        Debug.Log("This is the conversion from C to F (float) " + calcFahrenheitF + "°F");

        Debug.Log("");
        Debug.Log("----------------------------------------------------");
        tempInF = 212;
        Debug.Log("This is my Fahrenheit temp: " + tempInF);

        calcCelcius = ConvertToCelcius(tempInF);
        Debug.Log("This is the conversion from F to C " + calcCelciusF + "°C");


        double doubleOriginalFahrenheit;
        double doubleCelsius;
        double doubleCalculatedFahrenheit;

        // calculate and display for 0 degrees using double
        doubleOriginalFahrenheit = 0;
        print("Double Original Fahrenheit: " + doubleOriginalFahrenheit);
        doubleCelsius = (doubleOriginalFahrenheit - 32) / 9 * 5;
        print("Double Calculated Celsius: " + doubleCelsius);
        doubleCalculatedFahrenheit = (doubleCelsius * 9) / 5 + 32;
        print("Double Calculated Fahrenheit: " + doubleCalculatedFahrenheit);


    }


    /// <summary>
    /// Convert to Celcius
    /// </summary>
    /// <param name="tempInF"></param>
    /// <returns></returns>
    private int ConvertToCelcius(int tempInF)
    {
        int  celcius = ((tempInF - FreezingPoint) / Nine) * Five;

        return celcius;
    }

    /// <summary>
    /// Fanreinheit
    /// </summary>
    /// <param name="calcCelcius"></param>
    /// <returns></returns>
    private int ConvertToFanreinheit(int calcCelcius)
    {
       int fanrenheit =  (Nine * calcCelcius)/5 + FreezingPoint;

        return fanrenheit;
    }

    /// <summary>
    /// Float convert Fanrenheit
    /// </summary>
    /// <param name="calcCelciusF"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private float ConvertToFanreinheitFloat(float calcCelciusF)
    {
        float fanrenheit = (Nine * calcCelciusF) / 5 + FreezingPoint;

        return fanrenheit;
    }


    /// <summary>
    /// Float convert Celcius
    /// </summary>
    /// <param name="tempInFf"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private float ConvertToCelciusFloat(float tempInFf)
    {
        float celcius = ((tempInFf - FreezingPoint) / Nine) * Five;

        return celcius;
    }
}
