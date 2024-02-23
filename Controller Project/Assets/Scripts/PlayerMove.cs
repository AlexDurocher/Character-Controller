using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 fixedPos;
    
    public bool crouched;
    public float distanceToGround;
    public bool grounded;
    public float halfPlayerHeight;
    public bool sliding;
    
    // Start is called before the first frame update
    void Start()
    {
        crouched = false;
        grounded = false;
        halfPlayerHeight = transform.localScale.y;
        sliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        halfPlayerHeight = transform.localScale.y;
        VerticalMove();
    }

    void Height()
    {
        //Crouch
        //Prone
    }

    void VerticalMove()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            distanceToGround = hit.distance;
            GameObject objectHit = hit.collider.gameObject;
            float fixedHeight = transform.position.y + (halfPlayerHeight - hit.distance);
            if (distanceToGround < halfPlayerHeight + 0.1)
            {
                grounded = true;
                fixedPos = new Vector3(transform.position.x, fixedHeight, transform.position.z);
                transform.position = fixedPos;
            }
            else
            {
                grounded = false;
            }
        }

        float playerGravity;
        if (grounded == true)
        {
            playerGravity = 0;
        }
        else
        {
            playerGravity = 9.81f;
        }
        transform.Translate(Vector3.down * playerGravity * Time.deltaTime);

        //Jump
    }

    void HorizontalMove()
    {
        //WASD move
        //Slide or Dash
    }
}
