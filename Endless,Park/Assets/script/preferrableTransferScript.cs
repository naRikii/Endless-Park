using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class preferrableTransferScript : MonoBehaviour
{
    [SerializeField] float seconds;
    [SerializeField] int sceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(youmu());
    }
    IEnumerator youmu()
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(sceneIndex);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
