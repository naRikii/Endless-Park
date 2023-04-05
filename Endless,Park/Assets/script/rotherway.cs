using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotherway : MonoBehaviour
{
    [SerializeField] float backgroundscrollspeed = 0.12f;
    Material myMaterial;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(backgroundscrollspeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
