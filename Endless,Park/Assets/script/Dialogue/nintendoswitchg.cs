using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nintendoswitchg : MonoBehaviour
{
    public void ast()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            FindObjectOfType<SceneLoader>().resetreset();
        }

    }
    void Update()
    {
       ast();
    }
}
