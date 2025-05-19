using UnityEngine;
using System.Collections;

public class RandomZWalk : MonoBehaviour
{
    Animator anim;

    void OnEnable()
    {
        StartCoroutine(PlayRandomizedZWalk());
    }

    IEnumerator PlayRandomizedZWalk()
    {
        anim = GetComponent<Animator>();

        // Wait 1 frame for Animator to initialize properly
        yield return null;

        float randomOffset = Random.Range(0f, 1f);

        if (anim.HasState(0, Animator.StringToHash("ZWalk")))
        {
            anim.Play("ZWalk", 0, randomOffset);
        }
        else
        {
            Debug.LogError($"{gameObject.name}: 'ZWalk' state not found in Base Layer.");
        }
    }
}