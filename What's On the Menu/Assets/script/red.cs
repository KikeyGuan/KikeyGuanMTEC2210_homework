using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class red : MonoBehaviour
{
    public TextMeshProUGUI redtalk;
    //public GameObject Text;
    public SpriteRenderer sr;
    public BoxCollider2D box;
    public int next = 0;
    public bool sus = false;
    public bool soul = false;
    public bool inTrigger;
    // Start is called before the first frame update
    void Start()
    {
        //Text = GameObject.Find("Text");
        //redtalk = Text.GetComponent<TextMeshProUGUI>();
        sr = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z") && inTrigger == true)
        {
            next++;
            //Debug.Log(next);
        }
        if (next == 1){
            redtalk.text = "'Hmpf, you're not from around here. Leave.'";
            }
        if (next == 2){
            redtalk.text = "Take soul?";
                if (Input.GetKeyDown("x")){
                    redtalk.text = "Rolling lucky death...";
                    int Num = Random.Range(1,10);
                    if(Num >=5){
                        soul = false;
                        StartCoroutine(wait3());
                        Destroy(sr);
                        Destroy(box);
                        next = 0;
                        //remove sprite, remove box collider
                        //timer
                    }
                    else{
                        
                        sus = true;
                        StartCoroutine(wait4());
                        Destroy(sr);
                        Destroy(box);
                        next = 0;
                        //remove sprute and box collider
                        //inscrese suspicous level
                    }
                }
                if (Input.GetKeyDown("x")){
                    next = 0;
                    redtalk.text = " ";
                }
            }

        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inTrigger = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        inTrigger = false;
        redtalk.text = " ";
        next = 0 ;

        //Debug.Log("collision exit");
    }
    IEnumerator wait3()
    {
        yield return new WaitForSecondsRealtime(1);
        redtalk.text = "Soul collected!";
        yield return new WaitForSecondsRealtime(2);
        //next ++;
        redtalk.text = " ";
    }
    IEnumerator wait4()
    {
        yield return new WaitForSecondsRealtime(1);
        redtalk.text = "'You're crazy!'";
        yield return new WaitForSecondsRealtime(2);
        //next ++;
        redtalk.text = " ";
    }


/*
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
    */
}
