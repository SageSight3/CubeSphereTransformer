using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionCrontroller : MonoBehaviour //camera motion
{
    [SerializeField] private float speed;
    [SerializeField] private float sensitivity;

    // Update is called once per frame
    void Update()
    {
        //gets player movement input from axes
        Vector3 playerMotionInput = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Height"), Input.GetAxis("Vertical"));
        Vector3 motion = playerMotionInput.x * transform.right + playerMotionInput.y * transform.up + playerMotionInput.z * transform.forward;

        transform.position += motion.normalized * speed * Time.deltaTime;

        if (Input.GetAxis("Rotation") > 0.05) //detect and respongd to mouse movement with the right mouse button pushed
        {

            //lock and hide cursor when right mouse buttons pushed for ease of controlling movement
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            Vector2 playerRotationInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            Vector2 rotationDelta = playerRotationInput * sensitivity * Time.deltaTime;

            transform.rotation = Quaternion.Euler( //turns a Vector3 into a rotation
                transform.rotation.eulerAngles.x - rotationDelta.y,
                transform.rotation.eulerAngles.y + rotationDelta.x,
                0
            );
        } 
        else
        {
            Cursor.lockState = CursorLockMode.None; //free and show cursor when right mouse button isn't being pressed
            Cursor.visible = true; 
        }
    }
}
