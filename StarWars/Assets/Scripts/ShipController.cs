using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    Vector3 targetPosition;
    Vector3 lookAtTarget;
    Quaternion playerRot;
    float rotSpeed = 5;
    float speed = 2;
    bool moving = false;
    bool Stop = false;
    Animator anim;

    Touch touch;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {

            //touch = Input.GetTouch(0);

            SetTargetPosition();


        }

        if (moving)
        {
            Move();

        }


    }
    void SetTargetPosition()
    {
        touch = Input.GetTouch(0);
        Ray ray = Camera.main.ScreenPointToRay(touch.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1000))
        {
            if(hit.collider is BoxCollider)
            {
                targetPosition = hit.point;
                //this.transform.LookAt(targetPosition);
                lookAtTarget = new Vector3(targetPosition.x - transform.position.x, 0, targetPosition.z - transform.position.z);
                playerRot = Quaternion.LookRotation(lookAtTarget);
                moving = true;
            }

            


        }

    }
    void Move()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, playerRot, rotSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    Destroy(this.gameObject);
    //}


}
