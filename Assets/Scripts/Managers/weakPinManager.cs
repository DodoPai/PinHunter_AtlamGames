using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weakPinManager : MonoBehaviour
{
    [SerializeField] public ParticleSystem weakPinParticle;
    [SerializeField] public Rigidbody rb;


      private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(destroyParticle());
        }

    }
    

    IEnumerator destroyParticle()
    {
        yield return new WaitForSeconds(1.65f);
        Destroy(gameObject);
        Instantiate(weakPinParticle, transform.position, Quaternion.identity);


    }



}
