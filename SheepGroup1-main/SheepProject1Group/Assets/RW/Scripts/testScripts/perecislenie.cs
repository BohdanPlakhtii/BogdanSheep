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
        studentsAge = studentsAge.Veronika; // назначить состояние
        print(studentsAge.Veronika); 
    }

    
    void Update()
    {
        
    }
}
//   //модификтор_доступа enum имя : тип
//{
//    имя1 = значение1,
//    имя2 = значение2,
//}