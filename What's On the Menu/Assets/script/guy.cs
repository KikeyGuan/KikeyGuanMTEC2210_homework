using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;



//https://docs.unity3d.com/2018.2/Documentation/ScriptReference/UI.Image-sprite.html


public class guy : MonoBehaviour
{
    public TextMeshProUGUI guytalk;
    public GameObject Text;
    public int next = 0;
    //Image m_Image;
    //public Sprite m_Sprite;
    public GameObject textBox;
    public GameObject table;
    public bool inTrigger;

    //talk =z, yes = x, no = c maybe
    //talk = z, yes = z, no = x

    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        table = GameObject.Find("table");
        guytalk = Text.GetComponent<TextMeshProUGUI>();
        //m_Image = GetComponent<Image>();
        textBox = GameObject.Find("textbox");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z") && inTrigger==true)
        {
            next++;
            Debug.Log(next);
            //guytalk.text = "'w-waterr...'";

        }

        if (next == 1)
        {
            //textBox = transform.Position(needs to be attached to camare)
            guytalk.text = "'w-waterr...'";
        }
        if (next == 2)
        {
            if (table.GetComponent<table>().water == true)
            {
                guytalk.text = "'Y-you, have w-water!'";
            }
            if (table.GetComponent<table>().water == false)
            {
                guytalk.text = " ";
                next = 0;
            }
        }
        if (next == 3)
        {
            guytalk.text = "'C-can I have it?'";
            
            if (Input.GetKeyDown("x"))
            {
                guytalk.text = "'Thankyou!'";
                //wait seconds
                next++;
            }
            if (Input.GetKeyDown("c"))
            {
                guytalk.text = "OOhh noOo..";

                next = 0;
            }
        }
        if (next == 4)
        {
            guytalk.text = " ";
            next = 0;
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

        Debug.Log("collision exit");
    }

    /*
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("collisionStay");
            //guytalk.text = "'w-waterr...'";
            if (Input.GetKeyDown("z")){
                next = next++;
                Debug.Log(next);
            }

            if (next == 1){
                //textBox = transform.Position(needs to be attached to camare)
                guytalk.text = "'w-waterr...'";
            }
            if (next == 2){
                if (table.GetComponent<table>().water == true){
                    guytalk.text = "'Y-you, have w-water!'";
                    if (next == 3 ){
                        guytalk.text = "'C-can I have it?'";
                        if (Input.GetKeyDown("z")){
                            guytalk.text = "'Thankyou!'";
                        }
                        if (Input.GetKeyDown("x")){
                            guytalk.text = " ";
                            next = 0;
                        }
                    }
                }
                if (table.GetComponent<table>().water == false){
                    guytalk.text = " ";
                    next = 0;
                }
            }
            
        }
    }
    */


}
