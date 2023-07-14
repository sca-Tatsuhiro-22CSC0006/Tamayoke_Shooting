using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class test : MonoBehaviour
{

    Rigidbody rb;

    [SerializeField]
    float movespeed = 3.0f;

    [SerializeField]
    [Tooltip("�e�̔��ˏꏊ")]
    private GameObject firingPoint;

    [SerializeField]
    [Tooltip("�e")]
    private GameObject bullet;

    [SerializeField]
    [Tooltip("�e�̑���")]
    private float speed = 30f;

    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 10;
    int Hp;
    //Slider
    public Slider slider;

    void Start()
    {
        //Slider���ő�ɂ���B
        slider.value = 1;
        //HP���ő�HP�Ɠ����l�ɁB
        Hp = maxHp;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit"); // ���O��\������

        //HP����1������
        Hp = Hp - 1;

        //HP��Slider�ɔ��f�B
        slider.value = (float)Hp / (float)maxHp; ;
    }


    void Update()
    {

        if(Hp == 0)
        {
            Destroy(this.gameObject);
        }

        // transform���擾
        Transform myTransform = this.transform;

        Vector3 worldPos = myTransform.position;
        worldPos.x = 1.0f;    // ���[���h���W����ɂ����Ax���W��1�ɕύX
        worldPos.y = 1.0f;    // ���[���h���W����ɂ����Ay���W��1�ɕύX
        worldPos.z = 1.0f;    // ���[���h���W����ɂ����Az���W��1�ɕύX
        myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�

        if (Input.GetKey(KeyCode.D))
        {
            // ���Ɉړ�����
            //transform.position += movespeed * transform.right * Time.deltaTime;
            worldPos.x = -5.0f;
            worldPos.y = 0.0f;
            worldPos.z = 23.0f;
            myTransform.position = worldPos;
        }
        else if (!Input.GetKey(KeyCode.A))
        {
            worldPos.x = 0.0f;
            worldPos.y = 0.0f;
            worldPos.z = 23.0f;
            myTransform.position = worldPos;
        }

        if (Input.GetKey(KeyCode.A))
        {
            // �E�Ɉړ�����
            //transform.position += movespeed * -transform.right * Time.deltaTime;
            worldPos.x = 5.0f;
            worldPos.y = 0.0f;
            worldPos.z = 23.0f;
            myTransform.position = worldPos;
        }
        else if (!Input.GetKey(KeyCode.D))
        {
            worldPos.x = 0.0f;
            worldPos.y = 0.0f;
            worldPos.z = 23.0f;
            myTransform.position = worldPos;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.V) || Input.GetKeyDown(KeyCode.B))
        {
            // �e�𔭎˂���
            LauncherShot();
        }
        if (Input.GetKey(KeyCode.P))
        {
            // �e�𔭎˂���
            LauncherShot();
        }
    }

    private void LauncherShot()
    {
        // �e�𔭎˂���ꏊ���擾
        Vector3 bulletPosition = firingPoint.transform.position;
        // ��Ŏ擾�����ꏊ�ɁA"bullet"��Prefab���o��������
        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
        // �o���������{�[����forward(z������)
        Vector3 direction = newBall.transform.forward;
        // �e�̔��˕�����newBall��z����(���[�J�����W)�����A�e�I�u�W�F�N�g��rigidbody�ɏՌ��͂�������
        newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);
        // �o���������{�[���̖��O��"bullet"�ɕύX
        newBall.name = bullet.name;
        // �o���������{�[����0.8�b��ɏ���
        Destroy(newBall, 10.0f);
    }
}
