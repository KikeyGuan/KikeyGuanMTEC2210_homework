using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    public TextMeshProUGUI birdtalk;
    public GameObject Text;
    public SpriteRenderer sr;
    public BoxCollider2D box;
    public int next = 0;
    public bool inTrigger;
    
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        birdtalk = Text.GetComponent<TextMeshProUGUI>();
        
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
                birdtalk.text = "'Oh a new face. you traveling?'";
            }
            if (next == 2){
                birdtalk.text = "'Hmm this vibe...'";
            }
            if (next == 3){
                birdtalk.text = "'You're just like me! :>'";
            }
            if (next == 4){
                birdtalk.text = "'Well enjoy your stay!'";
            }
            if (next == 5){
                birdtalk.text = " ";
                next =0;
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
        birdtalk.text = " ";
        next = 0 ;

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
                birdtalk.text = "'Oh a new face. you traveling?'";
            }
            if (next == 2){
                birdtalk.text = "'Hmm this vibe...'";
            }
            if (next == 3){
                birdtalk.text = "'You're just like me! :>'";
            }
            if (next == 4){
                birdtalk.text = "'Well enjoy your stay!'";
            }
            if (next == 5){
                birdtalk.text = " ";
                next =0;
            }    
        }
    }
    */
}
