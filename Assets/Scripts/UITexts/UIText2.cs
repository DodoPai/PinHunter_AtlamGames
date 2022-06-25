using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIText2 : MonoBehaviour
{
    [SerializeField] public GameObject speaker2;


    private void Start()
    {
        speaker2.SetActive(false);
    }

    private void Update()
    {
        StartCoroutine(speakerImage());
    }


    IEnumerator speakerImage()
    {
        if (ScoreSystem.score == 400)
        {
            speaker2.SetActive(true);
            yield return new WaitForSeconds(2f);
            speaker2.SetActive(false);
            Destroy(gameObject);
        }
        

    }
}
