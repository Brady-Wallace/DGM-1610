using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButtonandGetKey : MonoBehaviour
{
   public Image graphic;
   public Sprite standard;
   public Sprite downgfx;
   public Sprite upgfx;
   public Sprite heldgfx;
   public Text boolDisplay1;
   public Text boolDisplay2;
   public Text boolDisplay3;
   
   void Start()
   {
       grapic.sprite = standard;
   }
    
        

    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held =  Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KEyCode.Space);
        
        if(down)
        {
            grapic.sprite = downgfx;
        }
        else if (held)
        {
            grapic.sprite = heldgfx;
        }
        else if (up)
        {
            grpaic.sprite = upgfx;
        }
        else 
        {
            grpaic.sprite = standard;
        }
        
        boolDispaly1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDispaly3.text = " " + held;
  }
}
        
    }
}
