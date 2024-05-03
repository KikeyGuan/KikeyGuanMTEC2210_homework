using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class red : MonoBehaviour
{
    public TextMeshPro redtalk;
    public GameObject Text;
    public SpriteRenderer sr;
    public BoxCollider2D box;
    public int next = 0;
    public bool sus = false;
    public bool soul = false;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        redtalk = Text.GetComponent<TextMeshPro>();
        sr = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            if (Input.GetKeyDown("z")){
                next = next++;
                //Debug.Log(next);
            }
            if (next == 1){
                redtalk.text = "'Hmpf, you're not from around here. Leave.'";
            }
            if (next == 2){
                redtalk.text = "Take soul?";
                if (Input.GetKeyDown("z")){
                    redtalk.text = "Rolling lucky death...";
                    int Num = Random.Range(1,10);
                    if(Num >=5){
                        redtalk.text = "Soul collected!";
                        soul = false;
                        Destroy(sr);
                        Destroy(box);
                        //remove sprite, remove box collider
                    }
                    else{
                        redtalk.text = "'You're crazy!'";
                        sus = true;
                        Destroy(sr);
                        Destroy(box);
                        //remove sprute and box collider
                        //inscrese suspicous level
                    }
                    if (next == 4){
                        redtalk.text = " ";
                    }
                }
                if (Input.GetKeyDown("x")){
                    next = 0;
                    redtalk.text = " ";
                }
            }
            
        }
    }
}
