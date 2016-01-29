using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jumpHeight;
    private Rigidbody2D rBody;

    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rBody.velocity = new Vector2(rBody.velocity.x, jumpHeight);
        }

        rBody.velocity = new Vector2(moveSpeed* Input.GetAxis("Horizontal"), rBody.velocity.y);

        //if (Input.GetKey(KeyCode.D))
        //{
        //    rBody.velocity = new Vector2(moveSpeed, rBody.velocity.y);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    rBody.velocity = new Vector2(-moveSpeed, rBody.velocity.y);
        //}
    }
}
