using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{

    [SerializeField]
    int rnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rnd = Random.Range(1, 4);�@// �� 1�`9�͈̔͂Ń����_���Ȑ����l���Ԃ�

        // transform���擾
        Transform myTransform = this.transform;

        // ���[���h���W����ɁA���W���擾
        Vector3 worldPos = myTransform.position;

        if(rnd == 1)
        {
            worldPos.x = 5.0f;    // ���[���h���W����ɂ����Ax���W��1�ɕύX
            worldPos.y = 0.0f;    // ���[���h���W����ɂ����Ay���W��1�ɕύX
            worldPos.z = 1.0f;    // ���[���h���W����ɂ����Az���W��1�ɕύX
            myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�
        }

        if (rnd == 2)
        {
            worldPos.x = 0.0f;    // ���[���h���W����ɂ����Ax���W��1�ɕύX
            worldPos.y = 0.0f;    // ���[���h���W����ɂ����Ay���W��1�ɕύX
            worldPos.z = 1.0f;    // ���[���h���W����ɂ����Az���W��1�ɕύX
            myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�
        }

        if (rnd == 3)
        {
            worldPos.x = -5.0f;    // ���[���h���W����ɂ����Ax���W��1�ɕύX
            worldPos.y = 0.0f;    // ���[���h���W����ɂ����Ay���W��1�ɕύX
            worldPos.z = 1.0f;    // ���[���h���W����ɂ����Az���W��1�ɕύX
            myTransform.position = worldPos;  // ���[���h���W�ł̍��W��ݒ�
        }

    }
}
