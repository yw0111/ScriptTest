using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // マナ

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //魔法攻撃の関数
    public void Magic()
    {

        //残りMPを減らす
        if (mp >= 5)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
            this.mp -= 5;
        }
        //MP<5
        else
        {
            Debug.Log("Cannot cast");
        }        
    }
    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //　魔法攻撃用の関数を呼び出す
        lastboss.Magic();
        // Cast 10 times
        for (int i=0; i < 10; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}