using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class eaten : MonoBehaviour
{
    public TextMeshProUGUI eattalk;
    //public GameObject Text;
    public int next = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Text = GameObject.Find("Text");
        //eattalk = Text.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(next);
        if (Input.GetKeyDown("z")){
                next++;
                //Debug.Log(next);
            }
        if (next == 0){
            eattalk.text = "You go back to the underworld.";
        }
        if (next == 1){
            eattalk.text = "Your pockets are light but your heart heavy.";
        }
        if (next == 2){
            eattalk.text = "You know what's coming.";
        }
        if (next == 3){
            eattalk.text = "Hiding is no use.";
        }
        if (next == 4){
            eattalk.text = "Held by one hand you hear a crunch.";
        }
        if (next == 5){
            eattalk.text = "Game Over, you were a delicious meal";
        }

    }
}
