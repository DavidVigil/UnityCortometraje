using UnityEngine;
using System.Collections;

public class RandomZCrawl : MonoBehaviour
{
    Animator anim;

    void OnEnable()
    {
        StartCoroutine(PlayRandomizedZCrawl());
    }

    IEnumerator PlayRandomizedZCrawl()
    {
        anim = GetComponent<Animator>();

        // Wait 1 frame for Animator to initialize properly
        yield return null;

        float randomOffset = Random.Range(0f, 1f);

        if (anim.HasState(0, Animator.StringToHash("ZCrawl")))
        {
            anim.Play("ZCrawl", 0, randomOffset);
        }
        else
        {
            Debug.LogError($"{gameObject.name}: 'ZCrawl' state not found in Base Layer.");
        }
    }
}