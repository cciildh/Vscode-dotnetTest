using System;

namespace NsqModel
{
    public class NsqInfo
    {
        public string EmpName { get; set; }
        public string SexName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public NsqInfo() { }
        public NsqInfo(string name, string sex, int age, string addr)
        {
            this.Address = addr;
            this.Age = age;
            this.EmpName = name;
            this.SexName = sex;
        }

        public static NsqInfo New(string name, string sex, int age, string addr) => new NsqInfo(name, sex, age, addr);
        public string ToJson() => Newtonsoft.Json.JsonConvert.SerializeObject(this);
    }
}
