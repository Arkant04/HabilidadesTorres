using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemypf;
    [SerializeField] List<Transform> SpawnPoints;
    /*[SerializeField] Transform enemySpawner1;
    [SerializeField] Transform enemySpawner2;
    [SerializeField] Transform enemySpawner3;
    [SerializeField] Transform enemySpawner4;*/

    void Start()
    {
        StartCoroutine(enemySpawner());
       /* spawner1();
        spawner2();
        spawner3();
        spawner4();*/
    }

    void Update()
    {
        
    }

    IEnumerator enemySpawner()
    {
        while (true)
        {
            Vector3 enemySpaw = SpawnPoints[(Random.Range(0, SpawnPoints.Count))].position;
            GameObject.Instantiate(enemypf, 
                enemySpaw, 
                Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }

  /* public void spawner1()
    {
        
        GameObject.Instantiate
        (enemypf,
        enemySpawner1.position,
        Quaternion.identity);
    }

    public void spawner2()
    {

        GameObject.Instantiate
        (enemypf,
        enemySpawner2.position,
        Quaternion.identity);
    }

    public void spawner3()
    {

        GameObject.Instantiate
        (enemypf,
        enemySpawner3.position,
        Quaternion.identity);
    }

    public void spawner4()
    {

        GameObject.Instantiate
        (enemypf,
        enemySpawner4.position,
        Quaternion.identity);
    }*/
}
