using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public class SplitShoot : Abilty
{

    [SerializeField] float strenght;
    [SerializeField] string ShootName;
    [SerializeField] float speed;
    [SerializeField] GameObject bulletPrefab;
    Transform bulletSpawnPoint;
    bool cooldownActive = false;
    [SerializeField] int spawnsNumber;
    List<Transform> spawn;
    [SerializeField] float bulletDestructionTime;
    

    public override void PlayerTr(Transform playerTr)
    {
        bulletSpawnPoint = playerTr.Find("BulletSpawns");
        spawn = new List<Transform>();
        for (int i = 0; i < bulletSpawnPoint.childCount; i++)
            spawn.Add(bulletSpawnPoint.GetChild(i));

    }
    public override void Trigger(
        Vector3 direccion,
        MonoBehaviour peonCoroutine,
        List<Image> abIcon,
        IEnumerator iconCd,
        ParticleSystem canNotShootPR)
    {
        if(elapsedCoolDown == 0)
        {
            for (int i = spawnsNumber; i< spawn.Count; i++)
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
            peonCoroutine.StartCoroutine(coolDownCouroutine());
            peonCoroutine.StartCoroutine(iconCd);
        }

        else if (elapsedCoolDown >= coolDown)
        {
           elapsedCoolDown = 0;
        }

        else if (elapsedCoolDown !<= coolDown)
            canNotShootPR.Play();


    }

    

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
