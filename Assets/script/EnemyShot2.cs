using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyShot2 : MonoBehaviour
{
    public GameObject shellPrefab;
    public AudioClip sound;

    [SerializeField]
    int speed = 500;

    void Start()
    {
        InvokeRepeating("Shot",0.0f,0.4f);//0秒から1秒ごとに発射
    }

    void Shot()
    {

        GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
        Rigidbody shellRb = shell.GetComponent<Rigidbody>();

        shellRb.AddForce(transform.forward * speed);//弾速

        Destroy(shell, 3.0f);//3秒後破壊

        AudioSource.PlayClipAtPoint(sound, transform.position);//音

    }

    
    void Update()
    {

    }
}
