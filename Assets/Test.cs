using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* Lesson4 �ۑ�
        int[] array = {10, 20, 30, 40, 50};

        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }
        for (int i = array.Length -1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        */

        //��lesson4 ���W�ۑ�
        Boss boss = new Boss();
 
        for (int i = 0; i < 10; i++) {
            boss.Magic();
        }

        boss.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Boss {
    private int mp = 53;

    public void Magic() {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        } else {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
    }
}
