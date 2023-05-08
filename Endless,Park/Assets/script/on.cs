using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class on : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            Debug.Log("yor");
        }
        else
        {
            FindObjectOfType<SceneLoader>().customSceneLoadByIndex();
        }
            

    }


}
