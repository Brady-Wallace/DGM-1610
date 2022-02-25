using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    int day = 2;
    int day_of_the_week = 3;
    void Start()
    {
        switch (day)
        {
            case 1:
                Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
        }
        switch(day_of_the_week)
        {
            case 1:
                Debug.Log("Today is Saturday");
                break;
            case 2:
                Debug.Log("Today is Sunday");
                break;
            default:
                Debug.Log("Looking forward to the Weekend");
                break;
        }
    
    
    
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
