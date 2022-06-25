using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class EnemyCounter : MonoBehaviour
{
    
    [SerializeField] private GameObject[] enemies;
    public Text enemyNumber;
    public GameObject winGamePanel;
    [SerializeField] private Spawner enemy;

    private bool showSpeaker;

    private void Start()
    {
        winGamePanel.SetActive(false);           
        Time.timeScale = 1;

    }

    private void Update()
    {

        enemies = GameObject.FindGameObjectsWithTag("Pin");

        enemyNumber.text = "Pin:" + enemies.Length.ToString();

        GamePanel();



    }
    public void GamePanel()
    {
        StartCoroutine(Delay());
    }
    



    IEnumerator Delay()
    {
        if (enemies.Length ==0)
        {
            enemy.Wave1();
            yield return new WaitForSeconds(2f);

             if (enemies.Length ==0)
            {
                enemy.Wave2();
                yield return new WaitForSeconds(2f);


                if(enemies.Length ==0)
                {
                    enemy.Boss();
                    yield return new WaitForSeconds(1f);
                    if (enemies.Length == 0)
                    {
                        winGamePanel.SetActive(true);
                        Time.timeScale = 0;
                    }
                }
            }
            
           

        }
        
    }
   



}
