namespace PraktikumAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Civitas hilman = new Mahasiswa("Universitas Jember", "Hilman", "192410102043");

            hilman.cetakNamaInstitusi();

            MahasiswaFasilkom fakhrii = new MahasiswaFasilkom(
                "UNEJ",
                "Fakhrii",
                "192410103076",
                new string[]
                {
                    "Python",
                    "C#",
                    "PHP",
                    "Golang"
                }
            );

            MahasiswaFasilkom rauf = new MahasiswaFasilkom("UNEJ", "Rauf", "192410103069");

            

            try
            {
                fakhrii.sedangNgoding();
                rauf.sedangNgoding();
            }
            catch (GakBisaNgodingException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("OH NO!!!!!!!!!");
            }


        }
    }
}