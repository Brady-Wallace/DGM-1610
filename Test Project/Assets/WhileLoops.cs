using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (i < 6)
        {
            Debug.Log(i);
            i++;
        }

        do
        {
            Debug.Log(i);
            i++;
        }
        while (i < 6);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
