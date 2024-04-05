using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public abstract class Abilty : ScriptableObject
{
    //[SerializeField] string abilityName;
    [SerializeField] public float coolDown;
    //[SerializeField] public List<Transform> spaw;
    public float elapsedCoolDown = 0;
    [SerializeField] public int abOrdenInList;
    public float fillIconCD;
    //[SerializeField] Image abIcon;
    // [SerializeField] public float Speed = 4f;
    public abstract void PlayerTr(Transform playerTr);
<<<<<<< HEAD
    public abstract void Trigger(
        Vector3 direccion, 
        MonoBehaviour peonCoroutine, 
        List<Image> abIcon, 
        IEnumerator iconCd, 
        ParticleSystem canNotShootPR); //abstrac es para heredar
=======
    public abstract void Trigger(Vector3 direccion, MonoBehaviour peonCoroutine); //abstrac es para heredar
>>>>>>> 21226fe87b7541493205799e41daaadbd7fd45e2

    public IEnumerator coolDownCouroutine()
    {
        while (elapsedCoolDown <= coolDown)
        {
            elapsedCoolDown += Time.deltaTime;
            //print(elapsedCoolDown);
            yield return null;
        }
    }

    
}
