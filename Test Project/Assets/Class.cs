using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
      }
      
      
      public Stuff myStuff = new Stuff(10, 7, 25);
      public float speed;
      public float turnSPeed;
      public Rigidbody bulletPrefab;
      public Transfrm firePosition;
      public float bulletSpeed;
      
      
      
      void Update ()
      {
          Movement();
          Shoot();
      }
      
      
      void Moevement ()
      {
          float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
          float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
          
          transform.Translate(Vector3.forward * forwardMovement);
          transfomr.Rotate(Vector3.up * turnMovement);
          
      }
      
      
      void Shoot ()
      {
          if(Input.GetButtonDOwn("Fire1") && myStuff.bullets > 0)
          {
              Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
              bulletInstance.AddForce(firePostition.forward * bulletSpeed);
              myStuff.bullets--;
           }
       }
}
        
public class Inventory : MonoBehavior
{
    public class Stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;
        
        public Stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
        
        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
         }
         
         // Constructor 
         public Stuff ()
         {
             bullets = 1;
             grenades = 1;
             rockets = 1;
         }
     }
      
      
      // Creating an Instance (an Object) of the Stuff class
      public Stuff myStuff = new Stuff(50, 5, 5);
      
      public Stuff myOtherStuff = new Stuff(50, 1.5f);
      
      void Start()
      {
          Debug.Log(myStuff.bullets);
      }
}

public class MovementControls: MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    
    
    
    void UPdate ()
    {
        Movement():
    }
    
    
    
    void MOvement ()
    {
        float fowardMovement = INput.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}

public class Shooting : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    
    
    
    pirvate Inventor invetory;
    
    
    
    void Awake()
    {
        inventory = GetComponet<INventor>();
    }
    
    
    
    void Update ()
    {
        Shoot();
    }
    
    
    void Shoot ()
    {
        if(INput,GetButtonDown("Fire1") && inventor.myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletINstance.AddForce(firePosition.forward * bulletSpeed);
            inventory.myStuff.bullets--;
         }
     }
}
       