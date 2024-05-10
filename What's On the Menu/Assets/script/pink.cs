using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class pink : MonoBehaviour
{
    public TextMeshProUGUI pinktalk;
    public GameObject Text;
    public SpriteRenderer sr;
    public BoxCollider2D box;
    public int next = 0;
    public bool sus = false;
    public bool soul = false;
    public bool inTrigger;
    public Image Textbox;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        pinktalk = Text.GetComponent<TextMeshProUGUI>();
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
            Textbox.enabled = true;
                pinktalk.text = "'HIHihi, new smell! barbark!'";
            }
            if (next == 2){
                pinktalk.text = "Kidnap soul?";
                if (Input.GetKeyDown("x")){
                    pinktalk.text = "Rolling trust levels...";
                    int Num = Random.Range(1,10);
                    if(Num >=5){
                        
                        soul = true;
                        StartCoroutine(wait7());
                        //Destroy(sr);
                        //Destroy(box);
                        next = 0;
                        //remove sprite, remove box collider
                    }
                    else{
                        
                        sus = true;
                        StartCoroutine(wait8());
                        //Destroy(sr);
                        //Destroy(box);
                        next = 0;
                        //remove sprute and box collider
                        //inscrese suspicous level
                    }
                }
                if (Input.GetKeyDown("c")){
                    next = 0;
                    pinktalk.text = " ";
                    Textbox.enabled = false;
                }
            }
            if(next == 3){
                pinktalk.text = " ";
                next = 0;
                Textbox.enabled = false;
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
        pinktalk.text = " ";
        next = 0 ;
        Textbox.enabled = false;

    }

    IEnumerator wait7()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        Textbox.enabled = true;
        pinktalk.text = "Rolling trust levels...";
        yield return new WaitForSecondsRealtime(2);
        pinktalk.text = "Soul adpoted!";
        yield return new WaitForSecondsRealtime(2);
        //next ++;
        pinktalk.text = " ";
        Textbox.enabled = false;
        Destroy(sr);
        Destroy(box);
    }
    IEnumerator wait8()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        Textbox.enabled = true;
        pinktalk.text = "Rolling trust levels...";
        yield return new WaitForSecondsRealtime(1);
        pinktalk.text = "'You're a bad person, wofwof.'";
        yield return new WaitForSecondsRealtime(2);
        //next ++;
        pinktalk.text = " ";
        Textbox.enabled = false;
        Destroy(sr);
        Destroy(box);
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
                pinktalk.text = "'HIHihi, new smell! barbark!'";
            }
            if (next == 2){
                pinktalk.text = "Kidnap soul?";
                if (Input.GetKeyDown("z")){
                    pinktalk.text = "Rolling trust levels...";
                    int Num = Random.Range(1,10);
                    if(Num >=5){
                        pinktalk.text = "Soul adpoted!";
                        soul = true;
                        Destroy(sr);
                        Destroy(box);
                        //remove sprite, remove box collider
                    }
                    else{
                        pinktalk.text = "'You're a bad person, wofwof.'";
                        sus = false;
                        Destroy(sr);
                        Destroy(box);
                        //remove sprute and box collider
                        //inscrese suspicous level
                    }
                    if (next == 4){
                        pinktalk.text = " ";
                    }
                }
                if (Input.GetKeyDown("x")){
                    next = 0;
                    pinktalk.text = " ";
                }
            }
            
        }
    }
    */
}
