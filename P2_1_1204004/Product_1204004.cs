namespace P2_1_1204004
{
    public class Product_1204004
    {
        private string myType;
        private string myTitle;

        public Product_1204004()
        {
            
        }

        public Product_1204004(string mytype, string mytitle)
        {
            this.myType = mytype;
            this.myTitle = mytitle;
        }
        
        
        public string MyType
        {
            get => myType;
            set => myType = value;
        }

        public string MyTitle
        {
            get => myTitle;
            set => myTitle = value;
        }
    }
}