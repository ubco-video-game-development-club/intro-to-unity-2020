using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject cubePrefab;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello from Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Get horizontal user input (-1 to 1)
        float xInput = Input.GetAxis("Horizontal");

        // Change the position on the x axis based on the user input
        transform.position += new Vector3(xInput * speed * Time.deltaTime, 0, 0);

        // Get left click input
        bool isMouseDown = Input.GetButtonDown("Fire1");
        if (isMouseDown)
        {
            // Spawn a cube!
            Instantiate(cubePrefab, new Vector3(0, 5, 0), Quaternion.AngleAxis(45f, Vector3.forward));
        }
    }
}
