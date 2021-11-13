using System;

namespace P2_1_1204004
{
    public class DVD_1204004 : Product_1204004
    {
        protected string duration;

        public DVD_1204004(string title, string duration){
            this.MyTitle = title;
            this.duration = duration;
            this.MyType = "DVD";

            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration{
            get => duration;
            set => duration = value;
        }
    }
}
