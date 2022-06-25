using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinManager : MonoBehaviour
{
    public float speed = 2f;
    

    public ParticleSystem deathPinParticle;
    private Animator anim;

    #region Health Bar
    public float health;
    public float maxHealth = 1000f;
    public GameObject healthBarUI;

    public Slider slider;
    #endregion

    private void Start()
    {
        anim = GetComponent<Animator>();
        health = maxHealth;
        slider.value = CalculateHealth();
    }



    private void Update()
    {
        Movement();
        slider.value = CalculateHealth();
        if(health < maxHealth)
        {
            healthBarUI.SetActive(true);
        }
        if(health <=0)
        {

            speed = 0;
            anim.SetTrigger("dead");

            
            Destroy(gameObject,1.5f);

        }




    }
     float CalculateHealth()
    {
        return health / maxHealth;
    }






    void Movement()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        {
            health -= 50;
            Instantiate(deathPinParticle, transform.position, Quaternion.identity);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Box"))
        {
            Destroy(gameObject);
            Instantiate(deathPinParticle, transform.position, Quaternion.identity);

        }
    }
}
