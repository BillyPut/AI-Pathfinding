using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameManager gameManager;

    public Rigidbody rb;

    public float zMove;
    public float xMove;
    public bool dead;
    public bool goDown, goUp, goLeft, goRight = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(xMove, 0f, zMove);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (goUp == false)
            {
                zMove = 12;
                xMove = 0;
            }

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (goDown == false)
            {
                zMove = -12;
                xMove = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (goLeft == false)
            {
                xMove = -12;
                zMove = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (goRight == false)
            {
                xMove = 12;
                zMove = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            gameManager.dead = true;
        }
    }



}
