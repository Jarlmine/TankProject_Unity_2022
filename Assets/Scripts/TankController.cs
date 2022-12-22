using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class TankController : BaseController
{
    [SerializeField] private float speed = 2f;




    protected void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);


        }


    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Q))

        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * 60 * Time.deltaTime, 0);
        }
    }
}
    
