using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    private void Awake()
    {
        
    }
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (collision.gameObject.tag == "lava")
            SceneManager.LoadScene(currentScene);
        else if (collision.gameObject.tag == "win")
        {
            SceneManager.LoadScene(currentScene += 1);
        }
        else if (collision.gameObject.tag == "load")
        {
            SceneManager.LoadScene(36);
        }
        else if (collision.gameObject.tag == "secrets")
        {
            FindObjectOfType<SceneLoader>().customSceneLoadByIndex();
        }
        else if (collision.gameObject.tag == "WYSI")
        {
            SceneManager.LoadScene(45);
        }
        else
        {
            Debug.Log("yor");
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentScene);
        }
        
    }
}
