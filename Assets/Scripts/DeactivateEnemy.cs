using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(!other.isTrigger)
            other.gameObject.SetActive(false);
    }
}
