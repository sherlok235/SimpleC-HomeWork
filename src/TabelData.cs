using System;
 
namespace Program
{ 
	struct an{
		public int z,l,a;
        public string anul;

        public string RturnAn(){
            anul=z.ToString()+'.'+l.ToString()+'.'+a.ToString();
            return anul;
        }

        public void InitData(){
            Console.WriteLine("Introduceti ziua luna si anul nasteri : ");
            Console.Write("ziua: ");
            this.z = Convert.ToInt32(Console.ReadLine());
            Console.Write("luna: ");
            this.l = Convert.ToInt32(Console.ReadLine());
            Console.Write("anul: ");
            this.a = Convert.ToInt32(Console.ReadLine());
        }
		public void DisplayData()
        {   
            Console.WriteLine($" {z}.{l}.{a}");
        }
	}
    struct elev
    {
        public string nume, prenume, gen,grupa,FormaDeFinantare;
		public an AnulNasteri;
        public int absente;
        public double balul_mediu;
        public void InitElev(){
            Console.Write("Numele: ");
            this.nume = Console.ReadLine();
            Console.Write("Prenumele: ");
            this.prenume = Console.ReadLine();
            AnulNasteri.InitData();
            Console.Write("Gen: ");
            this.gen = Console.ReadLine();
            Console.Write("Grupa: ");
            this.grupa=Console.ReadLine();
            Console.Write("Bal mediu: ");
            this.balul_mediu=Convert.ToDouble(Console.ReadLine());
            Console.Write("Forma de finantare: ");
            this.FormaDeFinantare = Console.ReadLine();
            Console.Write("Absentele: ");
            this.absente=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");
            
        }
        public void DisplayDataU(){
                Console.WriteLine($"{nume,-15} {prenume,-15} {gen,-15} {AnulNasteri.RturnAn(),-15} {grupa,-15} {balul_mediu,-15} {FormaDeFinantare,-25} {absente,-15} ");
        }
    }
 class tabel{
     public int n;
     public elev [] elevi;
    public tabel(){
        Console.Write("Introduceti numarul de elevi :");
            this.n=Convert.ToInt32(Console.ReadLine());
            elev []temp = new elev[n];
            elevi=temp;
    }
    public void Init(){
        for (int i =0;i<elevi.Length;i++){
                elevi[i].InitElev();
        }
        Console.Clear();
    }
    public void Display(){
        Console.WriteLine("{0,-15} {1,-15} {2,-15} {3,-15}{4,-15} {5,-15} {6,-25}{7,-15}","Nume","Prenume","Gen","Anul","Grupa","Balul_mediu","Forma de finantare","Absente");
        Console.WriteLine(" ");
        for(int i=0;i<elevi.Length;i++)
        elevi[i].DisplayDataU();
    }
     
 }
    class Program
    {
        static void Main()
        {
            
            tabel lista = new tabel();
            lista.Init();
            lista.Display();   
        }
    }
}