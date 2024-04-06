using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;
using UnityEngine.UI;

[CreateAssetMenu]

public class Healing : Abilty
{
    //[SerializeField] int healing;
    PlayerHealth playerhealt;

    public override void PlayerTr(Transform playerTr)
    {
        //StartCoroutine(coolDownCouroutine());

    }
    public override void Trigger(
        Vector3 direccion,
        MonoBehaviour peonCoroutine,
        List<Image> abIcon,
        IEnumerator iconCd,
        ParticleSystem canNotShootPR)
    {

        if (elapsedCoolDown == 0)
        {

            playerhealt = peonCoroutine.GetComponent<PlayerHealth>();
            playerhealt.Heal(2);
            peonCoroutine.StartCoroutine(coolDownCouroutine());
            peonCoroutine.StartCoroutine(iconCd);
        }

        else if (elapsedCoolDown >= coolDown)
        {
            elapsedCoolDown = 0;
        }
    }
}
