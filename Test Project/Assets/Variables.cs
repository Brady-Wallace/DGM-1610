using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    int myNum = 50;
    string myName = "John";
    int x = 5;
    int y = 10;
    int a = 5, b = 6, c = 50;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(x + y)
        Debug.Log(a + b + c);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
