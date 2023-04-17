using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateoppositeway : MonoBehaviour
{
    [SerializeField] float rotatespeed = 0.12f;

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
      

        transform.Rotate(Vector3.back * (rotatespeed * Time.deltaTime));


    }
}
