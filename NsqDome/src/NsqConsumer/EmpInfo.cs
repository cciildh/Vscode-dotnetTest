using System;
namespace NsqConsumer
{
    public class EmpInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SexName { get; set; }

        public EmpInfo() { }
        public EmpInfo(string name, int age, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.SexName = sex;
        }
        
        public static EmpInfo New(string name, int age, string sex)=>new EmpInfo( name,  age,  sex);

        public string Tojson()=>Newtonsoft.Json.JsonConvert.SerializeObject(this);
    }
}