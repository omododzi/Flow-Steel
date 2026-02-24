using System;
using UnityEngine;

public class Camera_Rotation : MonoBehaviour
{

    public float sensitivity = 1.5f;
    public float speedFollowing = 5f;
    public float offsetTarget = 5f;
    public float Yoffset = 3f;


    private float smooth = 10f;
    private float xRotation = 0f;
    private float yRotation = 0f;
    private float smoothTime = 0.2f;

    public Transform character;

     private Vector3 currentRotation;
     private Vector3 smoothRotation = Vector3.zero;
     private Vector3 characterPos;




    void Update()
    {
        if(character == null){return;}
        
        Camerarotation();
        Rotatecatracter();
    }



    private void Camerarotation()
    {
         yRotation += Input.GetAxis("Mouse X") * sensitivity;
         xRotation -= Input.GetAxis("Mouse Y") * sensitivity;


         xRotation = Math.Clamp(xRotation,-90,90);


         Vector3 nextRot = new Vector3(xRotation,yRotation);

         characterPos = new Vector3(character.position.x,character.position.y + Yoffset, character.position.z);
         currentRotation = Vector3.SmoothDamp(currentRotation,nextRot, ref smoothRotation, smoothTime);

         transform.position = characterPos - transform.forward * offsetTarget;
    }


    private void Rotatecatracter()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(xRotation,yRotation,0), Time.deltaTime * smooth);
        character.rotation = Quaternion.Lerp(character.rotation,Quaternion.Euler(0,yRotation,0), Time.deltaTime * smooth);
    }
}
