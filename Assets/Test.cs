using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53; //MP

    //���@�p�̊֐�
    public void Magic()
    {
        
        if (mp >=5)
        {
            mp -= 5;

            Debug.Log("���@�U��������" + this.mp);

            }

        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }


    }

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    // �h��p�̊֐�
    public void Defence(int damage)

    {
        Debug.Log(damage + "�̔�Q���󂯂�");
        // �c���hp�����炷
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

        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
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
