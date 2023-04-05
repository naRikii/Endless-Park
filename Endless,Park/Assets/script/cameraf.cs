using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

public class cameraf : MonoBehaviour
{
   
   stopautofilling
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        this.transform.position.z = -10;
        Camera.main.transform.position = FindObjectOfType<player>().transform.position;
     
    }
}
