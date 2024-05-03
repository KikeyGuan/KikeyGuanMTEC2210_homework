using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class pink : MonoBehaviour
{
    public TextMeshPro pinktalk;
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
        pinktalk = Text.GetComponent<TextMeshPro>();
        sr = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
        
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
}
