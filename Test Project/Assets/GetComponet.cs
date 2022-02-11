using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponet : MonoBehaviour
{
   public GameObject otherGameObject;
   
   
   private AnotherScript anotherScript;
   private YetAnotherScript yetAnotherScript;
   priavate BoxCollider boxCol;
   
   
   void Awake ()
   {
       anotherScript = GetComponet<AnotherScript>();
       yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
       boxCol = otherGameOBject.GetComponent<BoxCollider>();
   }
   
   
   void Start()
   {
       boxCol.size = new Vector3(3,3,3,);
       Debug.Log("The player's score is " + anotherScript.playerScore);
       Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
        
