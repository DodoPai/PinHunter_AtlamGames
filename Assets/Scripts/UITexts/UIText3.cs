using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIText3 : MonoBehaviour
{
    [SerializeField] public GameObject speaker3;


    private void Start()
    {
        speaker3.SetActive(false);
    }

    private void Update()
    {
        StartCoroutine(speakerImage());
    }


    IEnumerator speakerImage()
    {
        if (ScoreSystem.score == 700)
        {
            speaker3.SetActive(true);
            yield return new WaitForSeconds(3f);
            speaker3.SetActive(false);
            Destroy(gameObject);
        }


    }
}
