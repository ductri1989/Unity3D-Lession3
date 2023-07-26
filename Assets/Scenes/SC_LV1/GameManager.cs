using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
    [SerializeField] Transform tfPlayer;
    [SerializeField] Transform tfCameraPlayer;
    [SerializeField] int rotateSpeed = 120;




    void viewMyPlayer() { 
        if (transform.position != tfCameraPlayer.position)
            transform.position = Vector3.Lerp(tfCameraPlayer.position, tfCameraPlayer.position, 0.025f);//Camera di chuyển theo cam của nhân vật

        float camHorizontal = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        float camVertical = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
        tfPlayer.Rotate(0, camHorizontal, 0);//Xoay nhân vật theo con chuột

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, tfPlayer.localEulerAngles.y, 0);//Xoay Y của Camera
        transform.Rotate(-camVertical, 0, 0);//Xoay X của camera
    }

    void Update(){

        viewMyPlayer();
    }
}
