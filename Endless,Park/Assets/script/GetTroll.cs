using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void functionkey()
    {
        if (Input.GetKeyDown(KeyCode.F7))
            {
            FindObjectOfType<SceneLoader>().path23();
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        functionkey();
    }
}
