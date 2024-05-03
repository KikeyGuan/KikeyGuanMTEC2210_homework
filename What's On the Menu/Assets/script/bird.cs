using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class bird : MonoBehaviour
{
    public TextMeshPro birdtalk;
    public GameObject Text;
    public SpriteRenderer sr;
    public BoxCollider2D box;
    public int next = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        birdtalk = Text.GetComponent<TextMeshPro>();
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
}
