using UnityEngine;
using DG.Tweening;

public class TweenCoin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 randomPosition = transform.position;
        + new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
