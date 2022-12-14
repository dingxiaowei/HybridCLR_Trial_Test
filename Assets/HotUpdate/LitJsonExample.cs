using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using LitJson;
using System.Text;

public class LitJsonExample : MonoBehaviour
{
    void Start()
    {
        PersonToJson();
        JsonToPerson();
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public bool Sex { get; set; }
    }
    public void PersonToJson()
    {
        Person HaiLan = new Person();

        HaiLan.Name = "²ËÄñº£À½";
        HaiLan.Age = 51;
        HaiLan.Birthday = new DateTime(2018, 05, 17);
        HaiLan.Sex = true;
        string JsonStr = JsonMapper.ToJson(HaiLan);

        Debug.Log(JsonStr);
    }

    public void JsonToPerson()
    {
        string json = @"
            {
                ""Name""     : ""²ËÄñº£À½"",
                ""Age""      : 2018,
                ""Birthday"" : ""05/17/2018 00:00:00"",
                ""Sex"" : true
            }";

        Person HaiLan = JsonMapper.ToObject<Person>(json);

        Debug.Log("JsonToPerson Is Name:" + HaiLan.Name + " Sex:" + HaiLan.Sex);
    }
}