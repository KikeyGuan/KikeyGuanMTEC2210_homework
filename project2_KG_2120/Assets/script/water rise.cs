using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//little bit of help with loading scenes: https://www.youtube.com/watch?v=aNE0t0twhOE&ab_channel=UnityVideos%28JulienLynge%29
public class waterrise : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0.001f,0);
        
    }
    public void OnTriggerEnter (Collider collision){
        Debug.Log("game over");
        Destroy(player);
        StartCoroutine(deathtime());
        //SceneManager.LoadScene("SampleScene");
    }
    IEnumerator deathtime(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }

}
