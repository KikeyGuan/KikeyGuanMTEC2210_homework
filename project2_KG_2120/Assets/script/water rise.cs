using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
<<<<<<< HEAD
using TMPro;
=======
>>>>>>> 56d7b96120b6c90f8f7c05b08fb3cc9498a18e6d

//little bit of help with loading scenes: https://www.youtube.com/watch?v=aNE0t0twhOE&ab_channel=UnityVideos%28JulienLynge%29
public class waterrise : MonoBehaviour
{
    public GameObject player;
    public GameObject Capsule;
    public GameObject orientation;
    public GameObject cameraPos;
    public Text UIText;
<<<<<<< HEAD
    public float waterRise = 0.0001f;
    public float waterStop;
    public GameObject Text;
    public TextMeshPro deathText;
=======
    public float waterRise = 0.001f;
    
>>>>>>> 56d7b96120b6c90f8f7c05b08fb3cc9498a18e6d

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Capsule = GameObject.Find("Capsule");
        orientation = GameObject.Find("orientation");
        cameraPos = GameObject.Find("cameraPos");
<<<<<<< HEAD
        Text = GameObject.Find("Text");
        deathText = Text.GetComponent<TextMeshPro>();
        waterStop = GetComponent<Transform>().transform.position.y;
=======
        //UIText = Text.GetComponent<Text>();
        //UIText = GameObject.Find("Text");
        //playermove2 move= player.GetComponent<playermove2>().moveDirection;

>>>>>>> 56d7b96120b6c90f8f7c05b08fb3cc9498a18e6d
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,waterRise,0);
        Debug.Log(waterStop);
        if (waterStop ==2){
            waterRise = 0;
        }
        
    }
    public void OnTriggerEnter (Collider collision){
        Debug.Log("game over");
<<<<<<< HEAD
        //Destroy(player);
        player.GetComponent<playermove2>().moveDirection = new Vector3 (0,0,0);
        deathText.text = "Game Over";
=======
        Destroy(Capsule);
        Destroy(orientation);
        Destroy(cameraPos);
        
>>>>>>> 56d7b96120b6c90f8f7c05b08fb3cc9498a18e6d
        StartCoroutine(deathtime());
        //SceneManager.LoadScene("SampleScene");
    }
    IEnumerator deathtime(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }

}
