using UnityEngine;
using UnityEngine.UI;


public class ScoreSystem : MonoBehaviour
{

    [SerializeField] public static float score;
    [SerializeField] private Text scoreText;

  

    private void Update()
    {
        scoreText.text = "Score:" + score;
        
    }
   




    


}
