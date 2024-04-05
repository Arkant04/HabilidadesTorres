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
    public abstract void Trigger(
        Vector3 direccion, 
        MonoBehaviour peonCoroutine, 
        List<Image> abIcon, 
        IEnumerator iconCd, 
        ParticleSystem canNotShootPR); //abstrac es para heredar

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
