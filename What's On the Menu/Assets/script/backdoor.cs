using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class backdoor : MonoBehaviour
{
    public int suspicousLevel = 0;
    public int soulCollected = 0;
    public bool sus1;
    public bool sus2;
    public bool sus3;
    public bool soul1;
    public bool soul2;
    public bool soul3;
    public TextMeshProUGUI bDoortalk;
    public int next = 0 ;
    public bool inTrigger;
    public Image box;

    // Start is called before the first frame update
    void Start()
    {
        //bDoortalk = Text.GetComponent<TextMeshProUGUI>();
        sus1 = GameObject.Find("Red").GetComponent<red>().sus;
        sus2 = GameObject.Find("Blue").GetComponent<blue>().sus;
        sus3 = GameObject.Find("pink").GetComponent<pink>().sus;
        soul1 = GameObject.Find("Red").GetComponent<red>().soul;
        soul2 = GameObject.Find("Blue").GetComponent<blue>().soul;
        soul3 = GameObject.Find("pink").GetComponent<pink>().soul;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sus1 == true){
            suspicousLevel++;
        }
        if (sus2 == true){
            suspicousLevel++;
        }
        if (sus3 == true){
            suspicousLevel++;
        }
        if (soul1 == true){
            soulCollected++;
        }
        if (soul2 == true){
            soulCollected++;
        }
        if (soul3 == true){
            soulCollected++;
        }
        if (Input.GetKeyDown("z") && inTrigger == true)
        {
            next++;
            //Debug.Log(next);
        }
        if (next == 1){
            box.enabled = true;
                bDoortalk.text = "Go back? (game will end) ";
                if (Input.GetKeyDown("x")){
                    if (suspicousLevel == 3){
                        SceneManager.LoadScene("Died");
                        //goto killed
                    }
                    if (soulCollected == 3){
                        SceneManager.LoadScene("Surived");
                        //goto Surived
                    }
                    if (soulCollected !=3){
                        SceneManager.LoadScene("Eat");
                        //goto eaten
                    }
                }
                if (Input.GetKeyDown("c")){
                    bDoortalk.text = " ";
                    next = 0;
                    box.enabled = false;
            }
            
        }
        if(next == 2){
                bDoortalk.text = " ";
                next = 0;
                box.enabled = false;
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
        bDoortalk.text = " ";
        next = 0 ;
        box.enabled = false;

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
                bDoortalk.text = "Go back? (game will end) ";
                if (Input.GetKeyDown("x")){
                    if (suspicousLevel == 3){
                        SceneManager.LoadScene("Died");
                        //goto killed
                    }
                    if (soulCollected == 3){
                        SceneManager.LoadScene("Surived");
                        //goto Surived
                    }
                    if (soulCollected !=3){
                        SceneManager.LoadScene("Eat");
                        //goto eaten
                    }
                }
                if (Input.GetKeyDown("c")){
                    bDoortalk.text = " ";
                    next = 0;
            }
            
        }
    }

}
*/
}
