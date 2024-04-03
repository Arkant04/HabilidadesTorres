using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

[CreateAssetMenu]

public class Healing : Abilty
{
    //[SerializeField] int healing;
    PlayerHealth playerhealt;

    public override void PlayerTr(Transform playerTr)
    {
        //StartCoroutine(coolDownCouroutine());
        
    }

    public override void Trigger(Vector3 direction, MonoBehaviour peonCourutine)
    {

        if (elapsedCoolDown == 0)
        {
         
          //playerhealt = GetComponent<PlayerHealth>();
          //playerhealt.Heal(2);
          Debug.Log("tas curado");
          peonCourutine.StartCoroutine(coolDownCouroutine()); 
        }

        else if (elapsedCoolDown >= coolDown)
        {
            elapsedCoolDown = 0;
        }
    }
}
