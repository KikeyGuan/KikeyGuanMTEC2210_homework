using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;



//https://docs.unity3d.com/2018.2/Documentation/ScriptReference/UI.Image-sprite.html


public class guy : MonoBehaviour
{
    public TextMeshPro guytalk;
    public GameObject Text;
    public int next = 0;
    //Image m_Image;
    //public Sprite m_Sprite;
    public GameObject textBox;
    public GameObject table;

    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        table = GameObject.Find("table");
        guytalk = Text.GetComponent<TextMeshPro>();
        //m_Image = GetComponent<Image>();
        textBox = GameObject.Find("textbox");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            if (Input.GetKeyDown("z")){
                next = next++;
                Debug.Log(next);
            }

            if (next == 1){
                //textBox = transform.Position(needs to be attached to camare)
                guytalk.text = "w-waterr...";
            }
            if (next == 2){
                if (table.GetComponent<table>().water == true){
                    guytalk.text = "Y-you, have w-water!";
                    if (next == 3 ){
                        guytalk.text = "C-can I have it?";
                        if (Input.GetKeyDown("z")){
                            guytalk.text = "Thankyou!";
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

    public void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("exit");
    }
}
