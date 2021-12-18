using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{

    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject gem;

    private void Start()
    {
        StartCoroutine(Spawn());

    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
        float varity = Random.Range(1, 10);
        if (varity < 2)
        {
            Instantiate(gem, pos, Quaternion.identity);
        }
        else
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
