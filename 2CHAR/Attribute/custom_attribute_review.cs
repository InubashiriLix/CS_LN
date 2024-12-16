using System;

namespace namespace_attribute_review
{
    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Field,
        AllowMultiple = true
    )]
    public class Debug : Attribute
    {
        private int index;
        private string dev;
        private string lastdata;
        private string comment;
        public int Index
        {
            get { return index; }
        }

        public string Dev
        {
            get { return dev; }
        }

        public string Lastdata
        {
            get { return lastdata; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public Debug(int index, string dev, string lastdata, string comment)
        {
            this.index = index;
            this.dev = dev;
            this.lastdata = lastdata;
            this.comment = comment;
        }
    }

    public class CustomReview
    {
        [Debug(10, "inubashiri", "10/10/10", "this is a test ")]
        public void run()
        {
            Console.WriteLine("int custom review ");
        }
    }
}
