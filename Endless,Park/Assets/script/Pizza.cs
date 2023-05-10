using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pizza : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (collision.gameObject.tag == "floor")
        {
            SceneManager.LoadScene(currentScene);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
