using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perecislenie : MonoBehaviour
{
    public enum studentsAge : int
    {
        AlexK = 40,
        AlexR = 31,
        Veronika = 14,
    }
    void Start()
    {
        studentsAge = studentsAge.Veronika; // ��������� ���������
        print(studentsAge.Veronika); 
    }

    
    void Update()
    {
        
    }
}
//   //����������_������� enum ��� : ���
//{
//    ���1 = ��������1,
//    ���2 = ��������2,
//}