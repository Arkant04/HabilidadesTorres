using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Healing : Abilty
{
    //[SerializeField] int healing;
    PlayerHealth playerhealt;
    public override void Trigger(Vector3 direction)
    {

        if (elapsedCoolDown == 0)
        {

            playerhealt = GetComponent<PlayerHealth>();
            playerhealt.Heal(2);
            print("tas curado");
            StartCoroutine(coolDownCouroutine());
        }

        else if (elapsedCoolDown >= coolDown)
        {
            elapsedCoolDown = 0;
        }
    }
}
