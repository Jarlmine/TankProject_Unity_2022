using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurretController : BaseController
{

    public Transform Head;
    public float seekSpeed = 50f;
    public float rotateAngle = 70f;

    Vector3 originalRotation;


    protected void Start()
    {
        originalRotation = Head.localRotation.eulerAngles;

    }
    protected void Fire()
    {
        Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);

    }

    void Update()
    {
        Head.localRotation = Quaternion.Euler(originalRotation.x, Mathf.PingPong(Time.time * seekSpeed, rotateAngle * 2) - rotateAngle, 1f);

        //Layer enculé 
        RaycastHit hit;
        if (Physics.Raycast(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up, out hit))
        {
            Debug.DrawRay(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up * 20f);
            Fire();
        }
    }
    
}
