using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r : MonoBehaviour
{

    [SerializeField] float rotatespeed = 0.12f;
    Vector3 spe;
    float place = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotatepls();
    }

    public void rotatepls()
    {
      //spe = new Vector3(transform.rotation.x, transform.rotation.y, place);
      //place += rotatespeed;

        transform.Rotate(Vector3.forward * (rotatespeed * Time.deltaTime));


    }
}
