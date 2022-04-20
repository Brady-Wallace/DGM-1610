using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAppear : MonoBehaviour
{

    [SerializeField] private GameObject myCube;
    public GameObject mySphere;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ActivateCube()
    {
        myCube.SetActive(true);
    }

    
    public void ActivateSphere()
    {
        Debug.Log("Make Sphere Appear");
        mySphere.SetActive(true);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
