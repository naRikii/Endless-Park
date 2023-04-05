using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    float xM;
    float xMx;
    float yM;
    float yMx;
    [SerializeField] float pdmv = 1f;

    // Start is called before the first frame update
    void Start()
    {
        boundaries();

    }
    private void boundaries()
    {
        Camera gmCar = Camera.main;
        xM = gmCar.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + pdmv;
        xMx = gmCar.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - pdmv;
        yM = gmCar.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + pdmv;
        yMx = gmCar.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - pdmv;
    }
    public void Move()
    {
        {
            float changeX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
            float newX = Mathf.Clamp(transform.position.x + changeX, xM, xMx);
            float changeY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
            float newY = Mathf.Clamp(transform.position.y + changeY, yM, yMx);
            transform.position = new Vector2(newX, newY);
        }
    }
    // Update is called once per frame
    void Update()
    {
        Move();

    }
}
