using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TurnOnGravityAndDestroy());
        }
    }

    IEnumerator TurnOnGravityAndDestroy()
    {
        yield return new WaitForSeconds(0.5f);

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.constraints = RigidbodyConstraints.None;
            rb.useGravity = true;
        }

        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}