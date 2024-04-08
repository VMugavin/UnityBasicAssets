using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDesroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
            transform.parent.GetComponent<Enemy>().SpawnNew();
            //Destroy(GameObject);
        }
    }
}
