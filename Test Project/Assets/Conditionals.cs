using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    int x = 50;
    int y = 10;
    int a = 50;
    int b = 30;
    int c = 40;
    int time = 20;
    string name = "Bob";
    // Start is called before the first frame update
    void Start()
    {
        if (x > y)
        {
        Debug.Log("Hello World");
        }
        if (x == a)
        {
        Debug.Log("Hello World");
        }
        if (x == y)
        {
        Debug.Log("yes");
        }
        else
        {
        Debug.Log("no");
        }   
        if (b == c)
        {
        Debug.Log("1");
        }
        else if (b > c)
        {
        Debug.Log("2");
        }
        else
        {
        Debug.Log("3");
        }
        string result = (time < 18) ? "Good day." : "Good evening.";
        Debug.Log(result);
        if (20 > 18)
        {
        Debug.Log("20 is greater than 18.");
        }
        if ("Bob" == name)
        {
        Debug.Log("Bob is in the variable name.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
