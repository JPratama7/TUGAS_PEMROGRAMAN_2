namespace P2_1_1204004
{
    public class Book_1204004 : Product_1204004
    {
        protected string pageCount;

        public Book_1204004(string mytype, string mytitle, string pagecount) : base(mytype,mytitle)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get => pageCount;
            set => pageCount = value;
        }

    }
}