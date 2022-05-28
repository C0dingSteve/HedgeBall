using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeLimit = 10.0f;
    private float timer = 0;

    private void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeLimit;
            Debug.Log("Game Over");
        }
    }
}
