using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterwalk : MonoBehaviour
{

    //camera follow credit: https://www.youtube.com/watch?v=2KWHMSCxibA&ab_channel=AIA
    public float speed = 2f;
    //private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float xmove = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        float ymove = Input.GetAxis("Vertical") * speed*Time.deltaTime;
        Vector2 move = new Vector2(xmove, ymove);
        transform.Translate(move);

        //animator.SetFloat("x", xmove);
        //animator.SetFloat("y", ymove);
    }
}
