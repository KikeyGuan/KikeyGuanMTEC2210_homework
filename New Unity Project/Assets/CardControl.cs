using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControl : MonoBehaviour
{
    // Start is called before the first frame update
    //public Vector3 ScaleInitial;

    //public Vector3 ScaleOver;

    //public Vector3 ScaleCurrent;

    //public Vector3 mousePos;
    public Vector3 gamemouse;
    public Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale = Vector3.Lerp(transform.localScale, ScaleCurrent, .01f);
    }

    void OnMouseDown()
    {
        Debug.Log("click");
    }
    void OnMouseOver()
    {
        Debug.Log("Over");
    }
    void OnMouseDrag()
    {
        //mousePos = Input.mousePosition;
        gamemouse = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(gamemouse.x, gamemouse.y, 0);
        Debug.Log(gamemouse);
    }

    /*

    void OnMouseEnter()
    {
      ScaleCurrent = ScaleOver;
    }

    void OnMouseExit()
    {
      ScaleCurrent = ScaleInitial;
    }



    IEnumerator FlipCard()
    {
        yield return null;
    }
    */

}
