using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// help from: https://www.youtube.com/watch?v=f473C43s8nE&t=200s&ab_channel=Dave%2FGameDevelopment

public class cameramove : MonoBehaviour
{
    // Start is called before the first frame update
    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;
    void Start()
    {
        //lock mouse in place and trun invisi
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f);
        //rotate cam
        transform.rotation = Quaternion.Euler (xRotation,yRotation,0);
        orientation.rotation = Quaternion.Euler(0, yRotation,0);
    }
}
