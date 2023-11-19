using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    private Rigidbody2D rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rigidbody.velocity = new Vector3(0, 7, 0);
        }

        if (Input.GetKeyDown("up"))
        {
            rigidbody.velocity = new Vector3(0, 7, 0);
        }
        
        if (Input.GetKeyDown("left"))
        {
            rigidbody.velocity = new Vector3(-7, 0, 0);
        }
        if (Input.GetKeyDown("right"))
        {
            rigidbody.velocity = new Vector3(7, 0, 0);
        }
    }
}
