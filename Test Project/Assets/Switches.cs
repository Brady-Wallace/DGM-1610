using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    int day = 2;
    int day_of_the_week = 3;
    string name = "Dave";
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
        switch (day_of_the_week)
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
        switch (name)
        {
            case "Bill":
                Debug.Log("Name is Bill");
                break;
            case "Bob":
                Debug.Log("Name is Bob");
                break;
            case "Dave":
                Debug.Log("Name is Dave");
                break;
        }
        for (int i = 0; i < 4; i++)
        {
        switch (i)
            {
                case 0:
                    Debug.Log("i is equal to 0");
                    break;
                case 1:
                    Debug.Log("i is equal to 1");
                    break;
                case 2:
                    Debug.Log("i is equal to 2");
                    break;
                case 3:
                    Debug.Log("i is equal to 3");
                    break;
            }

        }
    
    
    
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
