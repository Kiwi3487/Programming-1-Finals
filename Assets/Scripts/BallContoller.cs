using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    private bool isMovingOnX = true;
    private bool isOnPlatform = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Scenes/SampleScene");

        }
        if (Input.GetMouseButtonDown(0))
        {
            isMovingOnX = !isMovingOnX;

            if (isMovingOnX)
            {
                MoveLeft();
            }
            else
            {
                MoveRight();
            }
        }
    }
    

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            if (!isOnPlatform)
            {
                rb.useGravity = true;
                rb.velocity = new Vector3(0, -10, 0);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("diamond"))
        {
            Destroy(collision.gameObject);
        }
    }



    void MoveLeft()
    {
        float speed = 10;
        rb.velocity = new Vector3(speed, 0, 0);
    }

    void MoveRight()
    {
        float speed = 10;
        rb.velocity = new Vector3(0, 0, speed);
    }
}