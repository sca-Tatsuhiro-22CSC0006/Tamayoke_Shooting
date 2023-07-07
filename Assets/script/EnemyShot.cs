using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject shellPrefab;
    public AudioClip sound;
    private int count;

    [SerializeField]
    int speed = 500;
    
    [SerializeField]
    int space = 640;

    void Start()
    {
        
    }

    void Update()
    {
        count += 1;

        if(count % space == 0)
        {

            GameObject Shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody ShellRb = Shell.GetComponent<Rigidbody>();

            ShellRb.AddForce(transform.forward * speed);//íeë¨

            Destroy(Shell, 2.0f);//2ïbå„Ç…ãÖè¡Ç¶ÇÈ

            AudioSource.PlayClipAtPoint(sound, transform.position);//âπ
        }


    }
}
