using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;          // MP

    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
     
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {

        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] points = new int[5];
        points[0] = 10;
        points[1] = 20;
        points[2] = 30;
        points[3] = 40;
        points[4] = 50;
        //for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }
        //for文を使い、配列の各要素の値を逆順に表示してください
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(points[i]);
        }


        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す

        for (int j = 0; j < 11; j++)
        {
            lastboss.Magic();
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}

