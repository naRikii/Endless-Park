using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transfer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(transfer());
    }
    IEnumerator transfer()
    {
        yield return new WaitForSeconds(5);
        FindObjectOfType<SceneLoader>().path24();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
