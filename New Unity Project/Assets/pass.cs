using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pass : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //swtich layer
        //int block = LayerMask.NameToLayer("block");
        //gameObject.layer = block;
        //int allow = LayerMask.NameToLayer("allow");
        //gameObject.layer = allow;
        //gameObject.layer = 7;
        //Debug.Log("hit0");
        if (collision.gameObject.tag == "card"){
            Debug.Log("hit");
            gameObject.layer = 7;
        }
        else{
            gameObject.layer = 6;
        }
        
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        //change back layers
        Debug.Log("exit0");
        gameObject.layer=6;
        if (collision.gameObject.tag == "card"){
            Debug.Log("exit");
            gameObject.layer = 6;
        }
        else{
            gameObject.layer = 7;
        }
    }

}
