using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class win : MonoBehaviour
{
    public GameObject Text;
    public TextMeshPro winText;
    // Start is called before the first frame update
    void Start()
    {
        Text = GameObject.Find("Text");
        winText = Text.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter (Collider collision){
        Debug.Log ("You Surived!");
        winText.text = "You Surived!";
        Time. timeScale = 0;
        StartCoroutine(restart());
    }

    IEnumerator restart(){
        yield return new WaitForSecondsRealtime(3);
        Time. timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
