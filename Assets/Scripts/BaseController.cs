using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseController : MonoBehaviour
{
    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    [SerializeField] protected float BulletSpeed = 10;
    public Rigidbody rb;
    protected int LifePoint = 1;
    protected float DelayValue = 2;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   

    void Update()
    {
       
        
    }
}
