using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//i want to build a seprate cam y follow but i dont know how to remove y from cameramove.
public class camy : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform orientation;
    float xRotation;
    float yRotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f);
        transform.rotation = Quaternion.Euler (xRotation,0,0);
    }
}
