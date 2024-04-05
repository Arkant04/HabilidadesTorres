using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ShieldAbility : Abilty
{
    [SerializeField] GameObject shieldPrefab;
    Transform shieldSpawnPoint;

    public override void PlayerTr(Transform playerTr)
    {
        shieldSpawnPoint = playerTr.Find("ShieldSpawn");
    }

    public override void Trigger(Vector3 direccion, MonoBehaviour peonCourutine)
    {
        if(elapsedCoolDown == 0)
        {
            GameObject shieldInstance = Instantiate(
                        shieldPrefab,
                        shieldSpawnPoint.position,
                        Quaternion.identity
                    );
            Destroy(shieldInstance, 3f);
            peonCourutine.StartCoroutine(coolDownCouroutine());
        }

        else if (elapsedCoolDown >= coolDown)
        {
            elapsedCoolDown = 0;
        }
    }
}
