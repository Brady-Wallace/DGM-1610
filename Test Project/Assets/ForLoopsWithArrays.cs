using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    int[] nums = { 1, 2, 3, 4, 5 };
    // Start is called before the first frame update
    void Start()
    {
        for (int i = nums[0]; i < nums[4]; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
