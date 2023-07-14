using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CharacterStatusScript : MonoBehaviour
{
    Animator anim;
    public UnityEvent onDieCallback = new UnityEvent();

    public int life = 100;//Hp

    public Slider HPBar;//UIと連動

    void Start()
    {
        anim = GetComponent<Animator>();

        if (HPBar != null)
        {
            HPBar.value = life;
        }
    }

    public void Damage(int damage)//ダメージ処理
    {
        if (life <= 0) return;

        life -= damage;
        if (HPBar != null)
        {
            HPBar.value = life;
        }
        if (life <= 0)
        {
            OnDie();
        }
    }

    void OnDie()//HP0
    {
        anim.SetBool("Die", true);
        onDieCallback.Invoke();
    }
}