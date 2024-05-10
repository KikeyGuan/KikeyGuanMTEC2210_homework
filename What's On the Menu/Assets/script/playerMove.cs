using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed = 800;
    public float minspeed = 400;
    public float xMove;
    public float yMove;
    Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator moving;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        moving.SetFloat("yspeed", Mathf.Abs(yMove));
        moving.SetFloat("xspeed", Mathf.Abs(xMove));
        xMove = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        yMove = Input.GetAxis("Vertical")*speed*Time.deltaTime;
        //Vector2 move = new Vector2(xMove,yMove);
        //transform.Translate(move);
        
    }

    private void FixedUpdate()
    {
        Vector2 move = new Vector2(xMove,yMove);
        rb.velocity = move;
        if (xMove > 0)
        {
            sr.flipX = true;
        }
        if(xMove < 0)
        {
            sr.flipX = false;
        }
    }
}
