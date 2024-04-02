using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    [SerializeField] List<Abilty> abilities;
    int selectedAbilityIndex = 0;
    Vector3 globalMousePos;
    Vector3 directionToMouse;
    [SerializeField] Transform cameraPosZ;

    void Update()
    {
        /////Abilidades/////
        if (Input.GetKeyDown(KeyCode.Alpha1))
            selectedAbilityIndex = 0;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            selectedAbilityIndex = 1;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            selectedAbilityIndex = 2;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            selectedAbilityIndex = 3;
        if (Input.GetKeyDown(KeyCode.Alpha5))
            selectedAbilityIndex = 4;
       ///////
        
       //////Mouse//////
       globalMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       globalMousePos.z = transform.position.z;
       directionToMouse = (globalMousePos - transform.position).normalized;
       transform.up = directionToMouse.normalized;

        if (Input.GetMouseButtonDown(0))
            abilities[selectedAbilityIndex].Trigger(directionToMouse); 

        /////
    }
}
