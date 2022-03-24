using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogRate = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        
        if (Input.GetKeyDown(KeyCode.Space) && Time.fixedTime >= dogRate) 
            {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogRate = Time.fixedTime + 0.5f;
            }
        
    }
}
