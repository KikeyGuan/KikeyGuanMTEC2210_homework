using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//little bit of help with loading scenes: https://www.youtube.com/watch?v=aNE0t0twhOE&ab_channel=UnityVideos%28JulienLynge%29
public class waterrise : MonoBehaviour
{
    public GameObject player;
    public GameObject Capsule;
    public GameObject orientation;
    public GameObject cameraPos;
    public Text UIText;
    public float waterRise = 0.001f;
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        Capsule = GameObject.Find("Capsule");
        orientation = GameObject.Find("orientation");
        cameraPos = GameObject.Find("cameraPos");
        //UIText = Text.GetComponent<Text>();
        //UIText = GameObject.Find("Text");
        //playermove2 move= player.GetComponent<playermove2>().moveDirection;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0.001f,0);
        
    }
    public void OnTriggerEnter (Collider collision){
        Debug.Log("game over");
        Destroy(Capsule);
        Destroy(orientation);
        Destroy(cameraPos);
        
        StartCoroutine(deathtime());
        //SceneManager.LoadScene("SampleScene");
    }
    IEnumerator deathtime(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }

}
