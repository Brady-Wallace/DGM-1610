using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    int i = 1;
    int x = 1;
    bool y = true;
    int health = 3;
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
            Debug.Log(x);
            x++;
        }
        while (x < 6);

        while (y)
        {
            Debug.Log("hello");
            if (y)
            {
                break;
            }
        }

        while (health > 0)
        {
            Debug.Log("Player has " + health + " health!");
            if (health == 1)
            {
                Debug.Log("Player is almost dead!!!");
            }
            health--;
        }
        Debug.Log("Game Over");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
