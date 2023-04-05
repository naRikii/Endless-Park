using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class on : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collide)
    {
        FindObjectOfType<SceneLoader>().rrtyui();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
