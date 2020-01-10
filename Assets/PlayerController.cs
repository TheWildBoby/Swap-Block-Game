using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float movementX;
    float movementZ;
    Rigidbody rb;
    public float speed;
    public float fallSpeed;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementZ = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(movementX, -fallSpeed, movementZ) * speed;
    }
}
