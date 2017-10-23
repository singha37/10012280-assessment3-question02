using System;

namespace Create_Classes
{
   private string _Name;
   private string _Species;
   private string _Sex;
   private int _Weight;
   private int _BandNumber;
}
   public string Name 
   {
       set
       {
       _Name = value;
       }
   }
    public string Species 
   {
       set
       {
       _Species = value;
       }
   }
    public string Sex 
   {
       set
       {
       _Sex = value;
       }
   }
    public string Weight 
   {
       set
       {
       _Weight = value;
       }
   }
    public string BandNumber 
   {
       set
       {
       _BandNumber = value;
       }
   }
        public Falcon(string _Name, string _Species, string _Sex, int _Weight, int _BandNumber)
        {
        Name = _Name;
        Species = _Species;
        Sex = _Sex;
        Weight = _Weight;
        BandNumber = _BandNumber;
        }
        public string DisplayFalcon()
        {
            var showmyFalcon = "Falcon data output is:\n\n";
            showFalcon += $"Name : {_Name}\n";
            showFalcon += $"Species : {_Species}\n";
            showFalcon += $"Sex : {_Sex}\n";
            showFalcon += $"Weight : {_Weight}\n";
            showFalcon += $"BandNumber : {_BandNumber}\n";

            return showmyFalcon;
        }
     

    class Program
    {
        static void Main(string[] args)
        {
            var Name = new Name("Hisan");
            var Species = new Species("NZ Falcon");
            var Sex = new Sex("Male");
            var Weight = new Weight("240grams");
            var BandNumber = new BandNumber("H39878");
        
            Console.WriteLine(Name.DisplayName());
            Console.WriteLine(Species.DisplaySpecies());
            Console.WriteLine(Sex.DisplaySex());
            Console.WriteLine(Weight.DisplayWeight());
            Console.WriteLine(BandNumber.DisplayBandNumber());
        
        }
    }
}
