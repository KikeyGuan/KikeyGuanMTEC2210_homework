using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


//little bit of help with loading scenes: https://www.youtube.com/watch?v=aNE0t0twhOE&ab_channel=UnityVideos%28JulienLynge%29
public class waterrise : MonoBehaviour
{
    public GameObject player;
    public GameObject Capsule;
    public GameObject orientation;
    public GameObject cameraPos;
    //public Text UIText;
    public float waterRise = 0.0001f;
    public float waterStop = 2;
    public GameObject Text;
    public TextMeshPro deathText;

    public float waterRiseLevel = 0.001f;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Capsule = GameObject.Find("Capsule");
        orientation = GameObject.Find("orientation");
        cameraPos = GameObject.Find("cameraPos");
        Text = GameObject.Find("Text");
        deathText = Text.GetComponent<TextMeshPro>();
        waterStop = gameObject.GetComponent<Transform>().transform.position.y;
        //UIText = Text.GetComponent<Text>();
        //UIText = GameObject.Find("Text");
        //playermove2 move= player.GetComponent<playermove2>().moveDirection;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,waterRiseLevel,0);
        Debug.Log(waterStop);
        if (waterStop ==2){
            waterRiseLevel = 0;
        }
        
    }
    public void OnTriggerEnter (Collider collision){
        Debug.Log("game over");

        //Destroy(player);
        //player.GetComponent<playermove2>().moveDirection = new Vector3 (0,0,0);
        deathText.text = "Game Over";
        player.GetComponent<playermove2>().speed = 0;
        //Destroy(Capsule);
        //Destroy(orientation);
        //Destroy(cameraPos);
        
        StartCoroutine(deathtime());
        //SceneManager.LoadScene("SampleScene");
    }
    IEnumerator deathtime(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }

}
