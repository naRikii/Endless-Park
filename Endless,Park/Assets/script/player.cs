using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{        
    [SerializeField] float moveSpeed = 10f;


    // Start is called before the first frame update
    void Start()
    {


    }

    public void Move()
    {
        {
            float changeX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            float newX = transform.position.x + changeX;
            float changeY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            float newY = transform.position.y + changeY;
            transform.position = new Vector2(newX, newY);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Move();

    }
}
