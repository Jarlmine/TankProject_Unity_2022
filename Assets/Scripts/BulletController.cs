using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float life = 3;
    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    [SerializeField] protected float BulletSpeed = 10;
    public Rigidbody rb;


    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        

    }
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        BulletPrefab.GetComponent<Rigidbody>().velocity = transform.up * BulletSpeed; 

    }
}
