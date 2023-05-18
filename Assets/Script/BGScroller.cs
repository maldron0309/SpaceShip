using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;
    [SerializeField] private float titleSize;
    float newPosition;

    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        newPosition = Mathf.Repeat(Time.time * scrollSpeed,titleSize);
        transform.position = startPosition + Vector3.forward * newPosition;
    }
}
