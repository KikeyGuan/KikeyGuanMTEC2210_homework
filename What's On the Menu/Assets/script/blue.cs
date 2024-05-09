using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class blue : MonoBehaviour
{
    public TextMeshProUGUI bluetalk;
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
        //bluetalk = Text.GetComponent<TextMeshProUGUI>();
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
                bluetalk.text = "'Hello there! Are you visitng?'";
            }
            if (next == 2){
                bluetalk.text = "'Blue is the tastiest around here!'";
            }
            if (next == 3){
                bluetalk.text = "'...apples ofcouse.'";
            }
            if (next == 4){
                bluetalk.text = "Take soul?";
                if (Input.GetKeyDown("z")){
                    bluetalk.text = "Rolling tasty death...";
                    int Num = Random.Range(1,10);
                    if(Num >=5){
                        
                        soul = true;
                        StartCoroutine(wait5());
                        Destroy(sr);
                        Destroy(box);
                        next = 0 ;
                        //remove sprite, remove box collider
                    }
                    else{
                        
                        sus = true;
                        StartCoroutine(wait6());
                        Destroy(sr);
                        Destroy(box);
                        next = 0 ;
                        //remove sprute and box collider
                        //inscrese suspicous level
                    }
                }
                if (Input.GetKeyDown("x")){
                    next = 0;
                    bluetalk.text = " ";
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
        bluetalk.text = " ";
        next = 0 ;

    }

    IEnumerator wait5()
    {
        yield return new WaitForSecondsRealtime(1);
        bluetalk.text = "Soul harvested!";
        yield return new WaitForSecondsRealtime(2);
        //next ++;
        bluetalk.text = " ";
    }
    IEnumerator wait6()
    {
        yield return new WaitForSecondsRealtime(1);
        bluetalk.text = "'You did not just! You're dangerous.'";
        yield return new WaitForSecondsRealtime(2);
        //next ++;
        bluetalk.text = " ";
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
                bluetalk.text = "'Hello there! Are you visitng?'";
            }
            if (next == 2){
                bluetalk.text = "'Blue is the tastiest around here!'";
            }
            if (next == 3){
                bluetalk.text = "'...apples ofcouse.'";
            }
            if (next == 4){
                bluetalk.text = "Take soul?";
                if (Input.GetKeyDown("z")){
                    bluetalk.text = "Rolling tasty death...";
                    int Num = Random.Range(1,10);
                    if(Num >=5){
                        bluetalk.text = "Soul harvested!";
                        soul = true;
                        Destroy(sr);
                        Destroy(box);
                        //remove sprite, remove box collider
                    }
                    else{
                        bluetalk.text = "'You did not just! You're dangerous.'";
                        sus = true;
                        Destroy(sr);
                        Destroy(box);
                        //remove sprute and box collider
                        //inscrese suspicous level
                    }
                    if (next == 7){
                        bluetalk.text = " ";
                    }
                }
                if (Input.GetKeyDown("x")){
                    next = 0;
                    bluetalk.text = " ";
                }
            }
            
        }
    }
    */
}
