using System; 

class URI {

    static void Main(string[] args) { 

            double a, b, mediaP;

            Console.WriteLine("Informe a nota A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a nota B: ");
            b = Convert.ToDouble(Console.ReadLine());
            
            mediaP = ((a*3.5) + (b* 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));

    }

}
