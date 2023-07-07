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
        
        rnd = Random.Range(1, 4);　// ※ 1～9の範囲でランダムな整数値が返る

        // transformを取得
        Transform myTransform = this.transform;

        // ワールド座標を基準に、座標を取得
        Vector3 worldPos = myTransform.position;

        if(rnd == 1)
        {
            worldPos.x = 5.0f;    // ワールド座標を基準にした、x座標を1に変更
            worldPos.y = 0.0f;    // ワールド座標を基準にした、y座標を1に変更
            worldPos.z = 1.0f;    // ワールド座標を基準にした、z座標を1に変更
            myTransform.position = worldPos;  // ワールド座標での座標を設定
        }

        if (rnd == 2)
        {
            worldPos.x = 0.0f;    // ワールド座標を基準にした、x座標を1に変更
            worldPos.y = 0.0f;    // ワールド座標を基準にした、y座標を1に変更
            worldPos.z = 1.0f;    // ワールド座標を基準にした、z座標を1に変更
            myTransform.position = worldPos;  // ワールド座標での座標を設定
        }

        if (rnd == 3)
        {
            worldPos.x = -5.0f;    // ワールド座標を基準にした、x座標を1に変更
            worldPos.y = 0.0f;    // ワールド座標を基準にした、y座標を1に変更
            worldPos.z = 1.0f;    // ワールド座標を基準にした、z座標を1に変更
            myTransform.position = worldPos;  // ワールド座標での座標を設定
        }

    }
}
