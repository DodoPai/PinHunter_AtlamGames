using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIText : MonoBehaviour
{
    [SerializeField] public GameObject speaker;


    private void Start()
    {
        speaker.SetActive(false);
    }

    private void Update()
    {
        StartCoroutine(speakerImage());
    }


    IEnumerator speakerImage()
    {
        if (ScoreSystem.score == 300)
        {
            speaker.SetActive(true);
            yield return new WaitForSeconds(2f);
            speaker.SetActive(false);
            Destroy(gameObject);
        }
        

    }
}
