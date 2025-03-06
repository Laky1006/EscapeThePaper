using System.Collections;
using UnityEngine;

public class BounceEffect : MonoBehaviour
{
    public float bouceHeight = 0.3f;
    public float bouncDuration = 0.4f;
    public int bounceCount = 2;

    public void StartBounce()
    {
        StartCoroutine(BounceHandler());
    }

    private IEnumerator BounceHandler()
    {
        Vector3 startPosition = transform.position;
        float localHeight = bouceHeight;
        float localDuration = bouncDuration;

        for (int i = 0; i < bounceCount; i++)
        {
            yield return Bounce(startPosition, localHeight, localDuration/2);
            localHeight *= 0.5f;
            localDuration *= 0.8f;
        }

        transform.position = startPosition; 
    }

    private IEnumerator Bounce(Vector3 start, float height, float duration)
    {
        Vector3 peak = start + Vector3.up * height;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            transform.position = Vector3.Lerp(start, peak, elapsed/duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

    }
}
