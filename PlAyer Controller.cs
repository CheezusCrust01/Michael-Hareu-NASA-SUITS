using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlAyerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f; 

    public GameObject projectilePrefab; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.postion.y, transform.postion.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.postion.y, transform.postion.z);
        }

        horizontalInput = Input.GeTAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
        }
    }
}
