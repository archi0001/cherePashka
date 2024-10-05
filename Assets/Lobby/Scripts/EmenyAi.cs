using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmenyAi : MonoBehaviour
{

    public float speed = 5;
    private float waitTime;
    public float startWaitTime;
    public Transform[] moveSpots;
    private int randomSpot;
    // Start is called before the first frame update
    void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
    
        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }

            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
