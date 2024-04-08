using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject prefabEnemy;
    // Start is called before the first frame update
    public void SpawnNew()
    {
        StartCoroutine(DelayCreate());
    }

    private IEnumerator DelayCreate()
    {
        yield return new WaitForSeconds(1);
        float x = Random.Range(-120f, 120f);
        float y = Random.Range(-120f, 120f);
        float z = -1f;
        Vector3 newPos= new Vector3(x, y, z);
        Transform currentTarget = Instantiate(prefabEnemy, transform.position + newPos, transform.rotation).transform;
        currentTarget.parent = transform;
    }
}
