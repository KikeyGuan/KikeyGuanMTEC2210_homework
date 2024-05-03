using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class dead : MonoBehaviour
{
    public TextMeshPro dedtalk;
    public GameObject Text;
    public int next = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        dedtalk = Text.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z")){
                next = next++;
                //Debug.Log(next);
            }
        if (next == 1){
            dedtalk.text = "When you are about to go into the door, someone stops you";
        }
        if (next == 2){
            dedtalk.text = "'I thought we were the same'";
        }
        if (next == 3){
            dedtalk.text = "'How foolish I was, and now you're goona pay'";
        }
        if (next == 4){
            dedtalk.text = "A bright light swallows you whole";
        }
        if (next == 5){
            dedtalk.text = "You disintegrated into the soil.";
        }
        if (next == 6){
            dedtalk.text = "Game Over, empty town.";
        }
    }
}
