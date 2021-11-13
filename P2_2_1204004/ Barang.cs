namespace P2_2_1204004
{
    public class  Barang
    {
        private string nama;
        private string tipe;

        public Barang(string nama, string tipe){
            this.nama = nama;
            this.tipe = tipe;
        }

        public string Nama{
            get => nama;
            set => nama = value;
        }
        
        public string Tipe{
            get => tipe;
            set => tipe = value;
        }
    }
}