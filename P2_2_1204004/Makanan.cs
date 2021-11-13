namespace P2_2_1204004
{
    public class Makanan : Barang
    {
        protected string kalori;

        public Makanan(string nama, string kalori) : base(nama,"Makanan"){
            this.kalori = kalori;
        }

        public string Kalori{
            get => kalori;
            set => kalori = value;
        }

    }
}