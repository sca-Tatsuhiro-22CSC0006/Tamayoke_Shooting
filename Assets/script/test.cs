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
    [Tooltip("弾の発射場所")]
    private GameObject firingPoint;

    [SerializeField]
    [Tooltip("弾")]
    private GameObject bullet;

    [SerializeField]
    [Tooltip("弾の速さ")]
    private float speed = 30f;

    //最大HPと現在のHP。
    int maxHp = 10;
    int Hp;
    //Slider
    public Slider slider;

    void Start()
    {
        //Sliderを最大にする。
        slider.value = 1;
        //HPを最大HPと同じ値に。
        Hp = maxHp;
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit"); // ログを表示する

        //HPから1を引く
        Hp = Hp - 1;

        //HPをSliderに反映。
        slider.value = (float)Hp / (float)maxHp; ;
    }


    void Update()
    {

        if(Hp == 0)
        {
            Destroy(this.gameObject);
        }

        // transformを取得
        Transform myTransform = this.transform;

        Vector3 worldPos = myTransform.position;
        worldPos.x = 1.0f;    // ワールド座標を基準にした、x座標を1に変更
        worldPos.y = 1.0f;    // ワールド座標を基準にした、y座標を1に変更
        worldPos.z = 1.0f;    // ワールド座標を基準にした、z座標を1に変更
        myTransform.position = worldPos;  // ワールド座標での座標を設定

        if (Input.GetKey(KeyCode.D))
        {
            // 左に移動する
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
            // 右に移動する
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
            // 弾を発射する
            LauncherShot();
        }
        if (Input.GetKey(KeyCode.P))
        {
            // 弾を発射する
            LauncherShot();
        }
    }

    private void LauncherShot()
    {
        // 弾を発射する場所を取得
        Vector3 bulletPosition = firingPoint.transform.position;
        // 上で取得した場所に、"bullet"のPrefabを出現させる
        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
        // 出現させたボールのforward(z軸方向)
        Vector3 direction = newBall.transform.forward;
        // 弾の発射方向にnewBallのz方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
        newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);
        // 出現させたボールの名前を"bullet"に変更
        newBall.name = bullet.name;
        // 出現させたボールを0.8秒後に消す
        Destroy(newBall, 10.0f);
    }
}
