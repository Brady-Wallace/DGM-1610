using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
    int[] nums = { 1, 2, 3, 4, 5 };
    string[] movies = { "Iron Giant", "Forrest Gump", "Wallace and Groment" };
    // Start is called before the first frame update
    void Start()
    {
        foreach (string i in cars)
        {
            Debug.Log(i);
        }

        foreach (int i in nums)
        {
            if (i == 4)
            {
                break;
            }
            else
            {
               Debug.Log(i * nums[i + 1]);
            }

        }

        foreach (string i in movies)
        {
            if (i == "Iron Giant")
            {
                Debug.Log("Iron Giant");
            }

            if (i == "Forrest Gump")
            {
                Debug.Log("Forrest Gump");
            }

            if (i == "Wallace and Groment") 
            {
                Debug.Log("Wallace and Groment");
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
