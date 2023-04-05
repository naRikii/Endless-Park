using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveMeAGun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(takeoff());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator takeoff()
    {
        yield return new WaitForSeconds(3);
        FindObjectOfType<SceneLoader>().takeoff();
    }
}
