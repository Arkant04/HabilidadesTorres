using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityHolder : MonoBehaviour
{
    [SerializeField] List<Abilty> abilities;
    [SerializeField] List<GameObject> abalitiesBI;
    [SerializeField] List<Image> abilitiesIC;
    [SerializeField] ParticleSystem canNotShootPR;
    int selectedAbilityIndex = 0;
    Vector3 globalMousePos;
    Vector3 directionToMouse;
    [SerializeField] Transform cameraPosZ;

    void Start()
    {
        canNotShootPR.Pause();
        for (int i = 0; i < abilities.Count; i++)
          abilities[i].PlayerTr(transform);

        abalitiesBI[0].SetActive(true);
        abalitiesBI[1].SetActive(false);
        abalitiesBI[2].SetActive(false);
        abalitiesBI[3].SetActive(false);
        abalitiesBI[4].SetActive(false);
        
    }

    void Update()
    {
        /////Abilidades/////
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedAbilityIndex = 0;
            abalitiesBI[0].SetActive(true);
            abalitiesBI[1].SetActive(false);
            abalitiesBI[2].SetActive(false);
            abalitiesBI[3].SetActive(false);
            abalitiesBI[4].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            selectedAbilityIndex = 1;
            abalitiesBI[0].SetActive(false);
            abalitiesBI[1].SetActive(true);
            abalitiesBI[2].SetActive(false);
            abalitiesBI[3].SetActive(false);
            abalitiesBI[4].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            selectedAbilityIndex = 2;
            abalitiesBI[0].SetActive(false);
            abalitiesBI[1].SetActive(false);
            abalitiesBI[2].SetActive(true);
            abalitiesBI[3].SetActive(false);
            abalitiesBI[4].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            selectedAbilityIndex = 3;
            abalitiesBI[0].SetActive(false);
            abalitiesBI[1].SetActive(false);
            abalitiesBI[2].SetActive(false);
            abalitiesBI[3].SetActive(true);
            abalitiesBI[4].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            selectedAbilityIndex = 4;
            abalitiesBI[0].SetActive(false);
            abalitiesBI[1].SetActive(false);
            abalitiesBI[2].SetActive(false);
            abalitiesBI[3].SetActive(false);
            abalitiesBI[4].SetActive(true);
        }
       ///////
        
       //////Mouse//////
       globalMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       globalMousePos.z = transform.position.z;
       directionToMouse = (globalMousePos - transform.position).normalized;
       transform.up = directionToMouse.normalized;

       Transform playerTrans = gameObject.GetComponent<Transform>();

        if (Input.GetMouseButtonDown(0))
        {
            abilities[selectedAbilityIndex].Trigger(directionToMouse, this, abilitiesIC, iconFilling(), canNotShootPR);

            if (abilitiesIC[selectedAbilityIndex].fillAmount >= 1)
                abilitiesIC[selectedAbilityIndex].fillAmount = 0;

            
            
        }

        /////
        
        //while (abilitiesIC[selectedAbilityIndex].fillAmount == 0)
        //{
        //    abilitiesIC[selectedAbilityIndex].fillAmount = 0.1f;
        //}
    }

    public IEnumerator iconFilling()
    {
        while (abilitiesIC[selectedAbilityIndex].fillAmount >= 0)
        {
            abilitiesIC[selectedAbilityIndex].fillAmount += Time.deltaTime;
            yield return null;
        }
    }

    
}
