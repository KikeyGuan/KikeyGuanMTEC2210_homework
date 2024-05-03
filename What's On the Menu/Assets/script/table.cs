using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class table : MonoBehaviour
{
    public TextMeshProUGUI tabletalk;
    public GameObject Text;
    public int next = 0;
    public bool water = false;
    public bool inTrigger;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        tabletalk = Text.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z") && inTrigger == true)
        {
            next++;
            Debug.Log(next);
        }
        if (next == 1)
        {
            tabletalk.text = "Take the water?";
            if (Input.GetKeyDown("z"))
            {
                tabletalk.text = "You got water!";
                water = true;
                //add time to close the text
            }
            if (Input.GetKeyDown("x"))
            {
                water = false;
                next = 0;
                tabletalk.text = " ";
            }
            
        }
        if (next == 2)
        {
            tabletalk.text = " ";
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
    /*
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            if (Input.GetKeyDown("z")){
                next = next++;
                Debug.Log(next);
            }
            if (next == 1){
                tabletalk.text = "Take the water?";
                if (Input.GetKeyDown("z")){
                    tabletalk.text = "You got water!";
                    water = true;
                }
                if (Input.GetKeyDown("x")){
                    water = false;
                    next = 0;
                    tabletalk.text = " ";
                }
            }
            
        }
    }
    */
    public void OnTriggerExit2D(Collider2D collision)
    {
        inTrigger = false;

        //Debug.Log("collision exit");
    }
}
