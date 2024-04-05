using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pillermove : MonoBehaviour
{
    public float positionVal;
    public float switchval;
    public float switchval1;
    public float val;
    
    //public GameObject piller;
    // Start is called before the first frame update
    void Start()
    {
        //piller = GameObject.Find("Cylinder (3)");
        positionVal = transform.position.x;
        val = 0.01f;
        switchval = 0.01f;
        switchval1 = -0.01f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
        if (transform.position.x >= -8f){
            val = -0.01f;
            Debug.Log(val);
        }
        if (transform.position.x <= -15f) {
            Debug.Log("wew");
            val = 0.01f;
        }
        transform.Translate(val,0,0);
    }
}
