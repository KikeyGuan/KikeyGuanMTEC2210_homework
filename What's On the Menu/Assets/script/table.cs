using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class table : MonoBehaviour
{
    public TextMeshPro tabletalk;
    public GameObject Text;
    public int next = 0;
    public bool water = false;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        tabletalk = Text.GetComponent<TextMeshPro>();
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
}
