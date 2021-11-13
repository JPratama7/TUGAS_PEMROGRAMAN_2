namespace P2_2_1204004
{
    public class Elektronik : Barang
    {
        protected string tipe_listrik;

        public Elektronik(string nama, string tipe_listrik): base(nama,"Elektronik")
        {
            this.tipe_listrik = tipe_listrik;
        }

        public string Tipe_Listrik{
            get => tipe_listrik;
            set => tipe_listrik = value;
        }
    }
}