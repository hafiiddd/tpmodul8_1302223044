using System.ComponentModel;


internal class Program
{
    private static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();    
        uiconfig uiConfig = new uiconfig();
        uiConfig.ReadJSON();
        Console.WriteLine($"berapa suhu badan anda saat ini ? dalam nilai {uiConfig.config.satuan_suhu} ");
        double nilaiSuhu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu anda terakhir memiliki gejala demam?");
        double hariDemam = Convert.ToInt32(Console.ReadLine());

        if (uiConfig.config.satuan_suhu == "Celcius")
        {
            if ((nilaiSuhu >= 36.5 && nilaiSuhu <= 37.5) && hariDemam < uiConfig.config.batas_hari_demam)
            {

                Console.WriteLine(uiConfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(uiConfig.config.pesan_ditolak);
            }
        }
        else if (config.satuan_suhu == "Fahrenheit")
        {

            if ((nilaiSuhu >= 97.7 && nilaiSuhu <= 99.5) && hariDemam < uiConfig.config.batas_hari_demam)
            {
                Console.WriteLine(uiConfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(uiConfig.config.pesan_ditolak);
            }
        }

        config.UbahSatuan();
        uiConfig.ReadJSON();
        Console.WriteLine($"berapa suhu badan anda saat ini ? dalam nilai {uiConfig.config.satuan_suhu}");
        nilaiSuhu = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Berapa hari yang lalu anda terakhir memiliki gejala demam?");
        hariDemam = Convert.ToInt32(Console.ReadLine());
        
        if (uiConfig.config.satuan_suhu == "Celcius")
        {
            if ((nilaiSuhu >= 36.5 && nilaiSuhu <= 37.5) && hariDemam < uiConfig.config.batas_hari_demam)
            {

                Console.WriteLine(uiConfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(uiConfig.config.pesan_ditolak);
            }
        }
        else if (uiConfig.config.satuan_suhu == "Fahrenheit")
        {

            if ((nilaiSuhu >= 97.7 && nilaiSuhu <= 99.5) && hariDemam < uiConfig.config.batas_hari_demam)
            {
                Console.WriteLine(uiConfig.config.pesan_diterima);
            }
            else
            {
                Console.WriteLine(uiConfig.config.pesan_ditolak);
            }
        }
    }
}