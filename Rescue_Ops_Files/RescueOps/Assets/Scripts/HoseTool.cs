using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoseTool : MonoBehaviour
{

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float sprayAmount = 20;


    public IEnumerator InstanceBullet()
    {
        for (int i = 0; i < sprayAmount; i++)
        {
            yield return new WaitForSeconds(0.025f);

            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(InstanceBullet());
        }


        
    }
}
