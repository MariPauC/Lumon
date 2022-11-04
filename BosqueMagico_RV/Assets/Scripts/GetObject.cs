using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetObject : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("comida"))
        {
            Destroy(other.gameObject);
        }
    }
}
