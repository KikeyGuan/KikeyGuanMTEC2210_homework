using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class Door : MonoBehaviour
{
    public TextMeshPro doortalk;
    public GameObject Text;
    public int next = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        doortalk = Text.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
                doortalk.text = "There is a note on the door";
            }
            if (next == 2){
                doortalk.text = "'hello little chef! I'm quite hungry today.'";
            }
            if (next == 3){
                doortalk.text = "'I know you're off work today, but I'll love to have a meal'";
            }
            if (next == 4){
                doortalk.text = "'I'll have three souls and if there is one soul less you're on the platter.'";
            }
            if (next == 5){
                doortalk.text = "'sign, your amazing boss! : )";
            }
            if (next == 6){
                doortalk.text = "...why me";
            }
            if (next == 7){
                doortalk.text = "Go to the human realm?";
                if (Input.GetKeyDown("z")){
                    SceneManager.LoadScene("Human");
                }
                if (Input.GetKeyDown("x")){
                    doortalk.text = " ";
                }
            }
            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("exit");
        next = 0;
    }
}
