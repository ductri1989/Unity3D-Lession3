using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MariaController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5;
    [SerializeField] float turningSpeed = 5;

    


    
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 moveVector = new Vector2(horizontal, vertical);
        GetComponent<Animator>().SetFloat("Moving", moveVector.magnitude);//magnitude : lấy độ dài của vector

        transform.Translate(horizontal * turningSpeed * Time.deltaTime, 0, vertical * movementSpeed * Time.deltaTime);//Di chuyển nhân vật





        if (Input.GetMouseButtonDown(0))
            GetComponent<Animator>().Play("Attacking");

        if (Input.GetKeyDown(KeyCode.Space)){  
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
            GetComponent<Animator>().Play("Jumping");
            //AnimationClip[] clips = GetComponent<Animator>().runtimeAnimatorController.animationClips; //this gets all your clips in your animator. ALL.
            //for (int i = 0; i < clips.Length; i++)
            //    Debug.Log(clips[i].name); //you should create a list to store all of these.
        }

    }
}
