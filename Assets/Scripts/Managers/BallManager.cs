using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] public Rigidbody rb;
    [SerializeField] public float power;

    

     void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
        ScoreSystem.score = 0;


    }
    
    public void SpaceShoot()
    {
        rb.AddForce(Vector3.forward * power);
            power = 0;
            GameManager.horizontalSpeed = 0;
    }


}
