using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
    public string Name { get; set; }
    public void Debug<T>(T t)
    {
        UnityEngine.Debug.Log($"Name:{Name}  打印:" + t);
    }
}

public class CreateByCode : MonoBehaviour
{
    void Start()
    {
        Debug.Log("这个脚本是通过代码AddComponent直接创建的-----更新");

        Person p = new Person();
        p.Name = "person";
        p.Debug<int>(1);

        gameObject.AddComponent<LitJsonExample>();

        var obj = GameObject.Instantiate(Resources.Load<GameObject>("Cube"));
    }
}
