using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SwordController : MonoBehaviour
{
    public GameObject sww;
    public float timerr = 0.4f;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sww.SetActive(true);
            timer = timerr;
        }
        
        if (timer < 0)
        {
        sww.SetActive(false);
        }
        
        timer -= Time.deltaTime;
    }
}
