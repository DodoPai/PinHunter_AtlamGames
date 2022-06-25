using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] EnemyCounter pinLength;
    [SerializeField] private GameObject zombiPinWave1;
    [SerializeField] private GameObject zombiPinWave2;
    [SerializeField] private GameObject pinBoss;






    private void Start()
    {
        zombiPinWave1.SetActive(false);
        zombiPinWave2.SetActive(false);
        pinBoss.SetActive(false);


    }

    public void Wave1()
    {
        zombiPinWave1.SetActive(true);
    }
   
    public void Wave2()
    {
        zombiPinWave2.SetActive(true);
    }
    public void Boss()
    {
        pinBoss.SetActive(true);
    }



}
