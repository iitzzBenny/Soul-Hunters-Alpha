using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthAndDamage : MonoBehaviour
{
    public float ghoulHealth = 100f;
    public float arrowDamage = 25f;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "arrow")
        {
            ghoulHealth = ghoulHealth - arrowDamage;
        }
        if (ghoulHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
