using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{

    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;

    private void Start()
    {
        StartCoroutine(Spawn());

    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, pos, Quaternion.identity);
        Repeat();
     
    }

    void Repeat() 
    {
        StartCoroutine(Spawn());
    }



    void Update()
    {
        
    }
}
