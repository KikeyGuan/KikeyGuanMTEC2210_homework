using UnityEngine;
using System.Collections;

//taken from unity documentation
public class playermove2 : MonoBehaviour {
    private CharacterController controller;
    public float speed = 10.0F;
    public float jumpSpeed = 20.0F;
    public float gravity = 50.0F;
    private Vector3 moveDirection = Vector3.zero;
    public int jumpcount = 0;
    //public Transform target;
    //public Transform CamRotate;
    //public float angleBetween = 0.0f;
    //Rigidbody rb;
    //public GameObject player;

    void Start(){
        //rb = GetComponent<Rigidbody>();
    }
    void Update() {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) {
            jumpcount = 0;
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //(x,y,z)
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            //code works now, but nothing has changed in code 
            //Just added the oritation(cameramove) to the player
            //so transform.TransformDirection has a z and y to work with


            //tried to rotate player
            //player.transform.Rotate(CamRotate,Space.Self);


            /*
            //maybe transform.foward to each key comparing to unity help
            if (Input.GetKey(KeyCode.W)){
                rb.velocity = transform.forward * speed;
            }
            if (Input.GetKey(KeyCode.S)){
                rb.velocity = -transform.forward * speed;
            }
            */
    
            //i dont know what transform forward is anymore
            //moveDirection = transform.TransformDirection(moveDirection);
            //moveDirection.x =CharacterController.transform.forward;
            //moveDirection.z =CharacterController.transform.forward;

            //idk if this is of help unity"
            // Computes the angle between the target transform and this object
            //Vector3 targetDir = target.position - transform.position;
            //angleBetween = Vector3.Angle(transform.forward,targetDir);
            //moveDirection = moveDirection * speed *angleBetween;
            
        }
        if (Input.GetButton("Jump") /*&& jumpcount <=2*/){
                jumpcount = jumpcount + 1 ;
                moveDirection.y = jumpSpeed+moveDirection.x +moveDirection.z;
                
                Debug.Log ("jumpcount: " + jumpcount);
            }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
