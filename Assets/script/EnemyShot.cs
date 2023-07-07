using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject shellPrefab;
    public AudioClip sound;
    private int count;

    void Start()
    {
        
    }


    void Update()
    {

        count += 1;

        if(count % 60 == 0)
        {
            GameObject shell = 
        }
    }
}
