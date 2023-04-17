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
    public void OnCollisionEnter2D(Collision2D collide)
    {

        FindObjectOfType<SceneLoader>().customSceneLoadByIndex();
    }


}
