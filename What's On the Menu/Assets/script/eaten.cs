using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class eaten : MonoBehaviour
{
    public TextMeshPro eattalk;
    public GameObject Text;
    public int next = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        eattalk = Text.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z")){
                next = next++;
                //Debug.Log(next);
            }
        if (next == 1){
            eattalk.text = "You go back to the underworld.";
        }
        if (next == 2){
            eattalk.text = "Your pockets are light but your heart heavy.";
        }
        if (next == 3){
            eattalk.text = "You know what's coming.";
        }
        if (next == 4){
            eattalk.text = "Hiding is no use.";
        }
        if (next == 5){
            eattalk.text = "Held by one hand you hear a crunch.";
        }
        if (next == 6){
            eattalk.text = "Game Over, you were a delicious meal";
        }

    }
}
