using System;

namespace namespace_checking_metadata
{
    [AttributeUsage(AttributeTargets.All)]
    public class HelperAttribute : System.Attribute
    {
        public readonly string Url;

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public HelperAttribute(string url, string topic)
        {
            this.Url = url;
            this.topic = topic;
        }

        private string topic;
    }

    [HelperAttribute("http://www.microsoft.com", "C#")]
    class MyClass
    {
        public MyClass() { }
    }
}

namespace namespace_attributeApp1
{
    public class Tester
    {
        public static void main()
        {
            System.Reflection.MemberInfo info = typeof(namespace_checking_metadata.MyClass);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
        }
    }
}
