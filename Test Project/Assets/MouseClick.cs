using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
   private Rigidbody rb;
   
   private void Awake()
   {
       rb = GetComponent<Rigidbody>();
   }
   
   void OnMouseDown ()
   {
       rb.AddForce(-transfomr.foward * 500f);
       rb.useGravity = true;
   }
}
        

