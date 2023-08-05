using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //MP

    //魔法用の関数
    public void Magic()
    {
        
        if (mp >=5)
        {
            mp -= 5;

            Debug.Log("魔法攻撃をした" + this.mp);

            }

        else
        {
            Debug.Log("MPが足りないため、魔法が使えない");
        }


    }

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)

    {
        Debug.Log(damage + "の被害を受けた");
        // 残りのhpを減らす
        this.hp -= damage;
    }

}

public class Test: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 12, 231, 53, 32, 41 };

        for (int i = 4; i > -1; i--)
        {
            Debug.Log(array[i]);

        }
       
        Array.Reverse(array);
        for (int i = 0; i< 5; i++)
        {
            Debug.Log(array[i]);
           
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        for (int i = 0; i < 10; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
