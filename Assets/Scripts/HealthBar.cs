using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image healthBar;
    public  static float currentHealth;
    [SerializeField] private float MaxHealth = 100f;
    GameManager over;
    

    private void Start()
    {
        currentHealth = MaxHealth;
        healthBar = GetComponent<Image>();
        




    }

    private void Update()
    {
        
        healthBar.fillAmount = currentHealth / MaxHealth;
        if(currentHealth <=0)
        {
            LevelManager.gameOver = true;
            Time.timeScale = 0;

        }
        
       
        
    }
    
    


}
