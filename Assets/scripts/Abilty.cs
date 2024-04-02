using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Abilty : MonoBehaviour
{
    //[SerializeField] string abilityName;
    [SerializeField] public float coolDown;
    public float elapsedCoolDown = 0;
    // [SerializeField] public float Speed = 4f;

    public abstract void Trigger(Vector3 direccion); //abstrac es para heredar
    public IEnumerator coolDownCouroutine()
    {
        while (elapsedCoolDown <= coolDown)
        {
            elapsedCoolDown += Time.deltaTime;
            print(elapsedCoolDown);
            yield return null;
        }
    }
}
