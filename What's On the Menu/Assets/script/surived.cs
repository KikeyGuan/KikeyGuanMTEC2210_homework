using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class surived : MonoBehaviour
{
    public TextMeshProUGUI surtalk;
    public GameObject Text;
    public int next = 0;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        //surtalk = Text.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z")){
                next = next++;
                //Debug.Log(next);
            }
        if (next == 1){
            surtalk.text = "You go back to the underworld.";
        }
        if (next == 2){
            surtalk.text = "Your bag heavy and full.";
        }
        if (next == 3){
            surtalk.text = "You combine the souls together, mixing all the flavors.";
        }
        if (next == 4){
            surtalk.text = "You serve it to your boss and they were delighted!";
        }
        if (next == 5){
            surtalk.text = "You survied another day! Until the next meal.";
        }
    }
}
