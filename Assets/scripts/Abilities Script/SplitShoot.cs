using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class SplitShoot : Abilty
{

    [SerializeField] float strenght;
    [SerializeField] string ShootName;
    [SerializeField] float speed;
    [SerializeField] GameObject bulletPrefab;
    //[SerializeField] Transform bulletSpawnPoint;
    [SerializeField] int spawnsCuantity;
    bool cooldownActive = false;
    Transform bulletSpawnPoint;
    List<Transform> spawn;
    [SerializeField] float bulletDestructionTime;

    public override void PlayerTr(Transform playerTr)
    {
        bulletSpawnPoint = playerTr.Find("BulletSpawns");
        spawn = new List<Transform>();
        for (int i = 0; i < bulletSpawnPoint.childCount; i++)
            spawn.Add(bulletSpawnPoint.GetChild(i));

    }

    public override void Trigger(Vector3 direccion, MonoBehaviour peonCourutine)
    {
        if (elapsedCoolDown == 0)
        {
            for (int i = spawnsCuantity; i< spawn.Count; i++)
            {
                GameObject bulletInstance = Instantiate(
                    bulletPrefab,
                    spawn[i].position,
                    Quaternion.identity
                );
                BulletDirection bulletDirection = bulletInstance.GetComponent<BulletDirection>();
                bulletDirection.bulletShoot(direccion, speed);
                Destroy(bulletInstance, bulletDestructionTime);
                //print("pasan cosas");
            }
            peonCourutine.StartCoroutine(coolDownCouroutine());
            //StartCoroutine(coolDownCouroutine());
        }

        else if (elapsedCoolDown >= coolDown)
        {
           elapsedCoolDown = 0;
        }


    }

    

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
