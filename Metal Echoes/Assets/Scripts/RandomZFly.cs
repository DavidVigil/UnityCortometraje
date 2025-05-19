using UnityEngine;
using System.Collections;

public class RandomZFly : MonoBehaviour
{
    Animator anim;

    void OnEnable()
    {
        StartCoroutine(PlayRandomizedZFly());
    }

    IEnumerator PlayRandomizedZFly()
    {
        anim = GetComponent<Animator>();

        // Wait 1 frame for Animator to initialize properly
        yield return null;

        float randomOffset = Random.Range(0f, 1f);

        if (anim.HasState(0, Animator.StringToHash("Fly")))
        {
            anim.Play("Fly", 0, randomOffset);
        }
        else
        {
            Debug.LogError($"{gameObject.name}: 'ZFly' state not found in Base Layer.");
        }
    }
}