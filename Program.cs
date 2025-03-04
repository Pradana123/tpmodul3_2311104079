using tpmodul3_2311104071;

class Program

{

    static void Main(string[] args)

    {

        KodePos kodePos = new KodePos();

        Console.WriteLine(kodePos.getKodePos("Margasari"));


        
        KodePos KodePos = new KodePos();
        Console.WriteLine("Kode Pos Margasari: " + kodePos.getKodePos("Margasari")); 

      
        DoorMachine door = new DoorMachine();
        door.BukaPintu();
        door.KunciPintu(); 


    }

}
