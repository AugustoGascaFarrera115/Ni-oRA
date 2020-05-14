using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBehaviour : MonoBehaviour
{
    public GameObject bullet;
    //public float speed = 100f;
    private void Start()
    {
        bullet = Resources.Load("projectile") as GameObject;
    }



    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
        //    Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
        //    instBulletRigidbody.AddForce(Vector3.forward * speed);
        //}

        if(Input.GetMouseButtonDown(1))
        {
            GameObject projectile = Instantiate(bullet) as GameObject;

        }

    }
}
