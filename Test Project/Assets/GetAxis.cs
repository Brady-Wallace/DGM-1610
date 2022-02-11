using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAxis : MonoBehaviour
{
    public float range;
    public Text textOUtput;
    

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;
        
        
        transfrom.position =  new Vector3(xPos, 2f, 0);
        textOutput.text = "Value Returned : " + h.ToString("F2");
    }
}

public class AxisRawExample : MonoBehaviour
{

    public flaot range;
    public Text textOutput;
    
    
    void Update ()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;
        
        tranform.position = new Vector3(xPos, 2f, 0);
        textOUtput.text  = "Value Returned: " + h.ToString("F2");
    }
}

public class DualAxisExapmle : MonoBehaviour
{
    public Text horizontalValueDisplayText;
    public Text verticalValueDIsplayText;
    public float hRange;
    public float vRange;
    
    void Update ()
    {
        float h  = input.GetAxis("Horizontal");
        float v = input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;
        
        transform.postion = new Vector3(xPos, 0, vPos);
        horizontalValueDispalyText.text = h.ToString("F2");
        verticalValueDispalyText.text = v.ToString("F2");
    }
}
    
