using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

	void OnCollisionEnter(Collision collision)
	{
		// �Փ˂��������Player�^�O���t���Ă���Ƃ�
		if (collision.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
		}
	}

}