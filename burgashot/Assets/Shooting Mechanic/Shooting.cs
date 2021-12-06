using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bullet;
    public GameObject bulletSpawn;
    public float fireRate;

    private Transform _bullet;






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Fire();


    }

    public void Fire()
    {
        _bullet = Instantiate(bullet.transform, bulletSpawn.transform.position, Quaternion.identity);

    }

}// class
