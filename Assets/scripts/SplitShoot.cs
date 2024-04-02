using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitShoot : Abilty
{

    [SerializeField] float strenght;
    [SerializeField] string ShootName;
    [SerializeField] float speed;
    [SerializeField] GameObject bulletPrefab;
    //[SerializeField] Transform bulletSpawnPoint;
    bool cooldownActive = false;
    [SerializeField] List<Transform> spaw;
    [SerializeField] float bulletDestructionTime;

    public override void Trigger(Vector3 direccion)
    {
        if(elapsedCoolDown == 0)
        {
            for (int i = 0; i< spaw.Count; i++)
            {
                GameObject bulletInstance = Instantiate(
                    bulletPrefab,
                    spaw[i].position,
                    Quaternion.identity
                );
                BulletDirection bulletDirection = bulletInstance.GetComponent<BulletDirection>();
                bulletDirection.bulletShoot(direccion, speed);
                Destroy(bulletInstance, bulletDestructionTime);
                print("pasan cosas");
            }
            StartCoroutine(coolDownCouroutine());
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
