using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldAbility : Abilty
{
    [SerializeField] GameObject shieldPrefab;
    [SerializeField] Transform shieldSpawnPoint;
    public override void Trigger(Vector3 direccion)
    {
        if(elapsedCoolDown == 0)
        {
            GameObject shieldInstance = Instantiate(
                        shieldPrefab,
                        shieldSpawnPoint.position,
                        Quaternion.identity
                    );
            Destroy(shieldInstance, 3f);
            StartCoroutine(coolDownCouroutine());
        }

        else if (elapsedCoolDown >= coolDown)
        {
            elapsedCoolDown = 0;
        }
    }
}
