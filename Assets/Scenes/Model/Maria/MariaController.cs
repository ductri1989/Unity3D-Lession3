using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MariaController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5;
    [SerializeField] float turningSpeed = 5;

    [SerializeField] int rotateSpeed = 120;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 moveVector = new Vector2(horizontal, vertical);
        GetComponent<Animator>().SetFloat("Moving", moveVector.magnitude);//magnitude : lấy độ dài của vector

        transform.Translate(horizontal * turningSpeed * Time.deltaTime, 0, vertical * movementSpeed * Time.deltaTime);//Di chuyển nhân vật


        float camHorizontal = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        float camVertical = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, camHorizontal, 0);//Xoay nhân vật theo con chuột
    }
}
