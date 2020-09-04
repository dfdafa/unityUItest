﻿using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// 지역변수 / 멤버변수 구분

// c#은 전역변수가 없어서 싱글톤 클래스로 대치한다.

// "c# 자료형 크기" 구글검색



public class Test003Secne : MonoBehaviour
{
    public Text m_ResultText1 = null;
    public Text m_ResultText2 = null;
    public Text m_ResultText3 = null;
    public Text m_ResultText4 = null;
    public Text m_ResultText5 = null;
    public Text m_ResultText6 = null;
    public Text m_ResultText7 = null;

    // Start is called before the first frame update
    void Start()
    {
        TestVariable();
        TestFunction();
        TestFunction2();
        TestIf();
        TestSwitch();
        TestArray();
        TestCollection();
        TestLogic();
        TestClass();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void TestVariable()
    {
        // byte=1byte(8bit), short= 2byte(16bit)

        byte aByte = 3;
        Debug.Log("byte = " + aByte);

        int nSize = sizeof(byte);
        Debug.Log("byte size = " + nSize);


        // 정수형 : int 4byte(32bit), long = 8byte(64bit). Decimal = 96비트
        int a = 10;
        int b = 20;

        int c = a + b;

        Debug.Log("c = " + c);


        //------------------------------------


        // 소수형 :  float 4byte   double = 8byte
        float fA = 10.85f;
        float fB = 20.52f;

        float fC = fA + fB;

        Debug.Log("fC = " + fC);

        //------------------------------------

        string txt1 = "안녕하세요 ";
        string txt2 = "반가워요 ";

        string txt3 = txt1 + " " + txt2;
        Debug.Log("txt = " + txt3);

        //------------------------------------


        bool isCheck = false;
        Debug.Log("isCheck = " + isCheck);
        m_ResultText1.text = string.Format("byte = {0}, byte size = {1} , c = {2}, fC = {3}, txt = {4}, isCheck = {5} ",
                                            aByte, nSize, c, fC, txt3, isCheck);


        //------------------------------------

    }

    // 함수 개념잡기
    public void TestFunction()
    {
        int nSum = Sum(10, 20);
        Debug.Log("sum = " + nSum);


        int a = 100;
        int b = 200;

        Debug.Log("a = " + a + ", b = " + b);

        Swap(ref a, ref b);
        Debug.Log("a = " + a + ", b = " + b);


        m_ResultText2.text = string.Format("Sum = {0}, a = {1}, b = {2}", nSum, a, b);
    }

    // call by value 와 call by reference
    public void TestFunction2()
    {
        int a = 100;
        int b = 200;

        Debug.Log("a = " + a + ", b = " + b);


        SwapTest(a, b);
        Debug.Log("a = " + a + ", b = " + b);

        Swap(ref a, ref b);
        Debug.Log("a = " + a + ", b = " + b);

    }



    public int Sum(int a, int b)
    {
        return a + b;
    }

    public void SwapTest(int a, int b)
    {
        int c = a;
        a = b;
        b = c;
    }

    public void Swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;
    }


    //// 제너릭 함수
    //public void Swap<T>( ref T a, ref T b )  {
    //    T c = a;
    //    a = b;
    //    b = c;
    //}



    public void TestIf()
    {
        int a = 10;
        int b = 10;

        if (b > a)
        {
            m_ResultText3.text = "b 가 a 보다 큽니다.";
            Debug.Log("b 가 a 보다 큽니다.");

        }
        else if (a > b)
        {
            m_ResultText3.text = "a 가 b 보다 큽니다.";
            Debug.Log("a 가 b 보다 큽니다.");

        }
        else
        {
            m_ResultText3.text = "a 와 b 는 같다.";
            Debug.Log("a 와 b 는 같다.");

        }

        // &&, || 설명


    }

    public void TestSwitch()
    {
        const int apple = 1;
        const int orange = 2;
        const int banana = 3;

        int a = orange;

        switch (a)
        {
            case apple:
                m_ResultText4.text = "사과입니다.";
                Debug.Log("사과입니다.");

                break;
            case orange:
                m_ResultText4.text = "오렌지입니다.";
                Debug.Log("오렌지입니다.");

                break;
            case banana:
                m_ResultText4.text = "바나나입니다.";
                Debug.Log("바나나입니다.");

                break;
        }

    }

    public void TestArray()
    {
        int[] aTemp = new int[3];
        aTemp[0] = 100;
        aTemp[1] = 200;
        aTemp[2] = 300;


        for (int i = 0; i < aTemp.Length; i++)
        {
            m_ResultText5.text = string.Format("Temp[{0}] = {1}", i, aTemp[i]);
            Debug.Log(m_ResultText5);
            
        }
    }

    public void TestCollection()
    {
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);

        for (int i = 0; i < list.Count; i++)
        {
            m_ResultText6.text = string.Format("list[{0}] = {1}", i, list[i]);
            Debug.Log(m_ResultText6);
        }


        Dictionary<int, string> dic = new Dictionary<int, string>();

        dic.Add(1, "사과");
        dic.Add(2, "배");
        dic.Add(3, "수박");

        foreach (KeyValuePair<int, string> item in dic)
        {
            int key = item.Key;
            string value = item.Value;

            m_ResultText6.text = string.Format("dic[{0}] = {1}", key, value);
            Debug.Log(m_ResultText6);

        }

        dic[1] = "맛있는 사과";
        dic[2] = "맛있는 배";

        m_ResultText6.text = string.Format("dic[1] = {0}, dic[2] = {1}", dic[1], dic[2]);
        Debug.Log(dic[1]);
        Debug.Log(dic[2]);
    }


    public void TestClass()
    {
        Animal kAnimal = null;

        Dog kDog = new Dog();
        kDog.Initialize();
        kDog.PrintName();

        kAnimal = kDog;

        kAnimal.PrintName();
        kAnimal.m_Name = "강아지 22";

        kDog.PrintName();
        kAnimal.PrintName();


        Cat kCat = new Cat();
        kCat.Initialize();
        kCat.PrintName();


        kAnimal = kCat;
        kAnimal.PrintName();

    }


    // 이진 논리 연산자
    public void TestLogic()
    {
        // 첫번째 : 부호비트
        // 실제 : 31비트 사용
        // 0000 0000 0000 0000 0000 0000 0000 0000 

        int a = 11;     // =  1011   = 0xb
        int b = 9;      // =  1001   = 0x9

        int c = a & b;    // and  
        int d = a | b;    // or  
        int e = ~a;       // not      = -(a+1)
        int f = a ^ b;    // xor     서로다른것만 참, 서로같으면 거짓
        int g = b >> 2;   // 우측으로 2비트 이동      1001 -> 0010    
        int h = b << 2;   // 좌측으로 2비트 이동      1001 -> 100100  


        m_ResultText7.text = string.Format("c={0}, d={1}, e={2}, f={3}, g={4}, h={5}", c, d, e, f, g, h);
        Debug.Log(m_ResultText7);

    }


    // 1. 변수
    // 2. 함수 개념잡기
    // 3. 제어문
    // 4. 반복문
    // 5. 배열
    // 6. collection
    // 7. 클래스

}


public class Animal
{
    public int m_Type;
    public string m_Name;

    virtual public void Initialize()
    {
    }

    public void PrintName()
    {
        Debug.Log("Name = " + m_Name);
    }
}


public class Dog : Animal
{
    public override void Initialize()
    {
        m_Type = 1;
        m_Name = "강아지";
    }
}

public class Cat : Animal
{
    public override void Initialize()
    {
        m_Type = 2;
        m_Name = "고양이";
    }
}


