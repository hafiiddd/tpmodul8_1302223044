using System;
using System.Text.Json;


    public class CovidConfig
    {
        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public CovidConfig()
        {


            this.satuan_suhu = satuan_suhu;
            this.batas_hari_demam = batas_hari_demam;
            this.pesan_ditolak = pesan_ditolak;
            this.pesan_diterima = pesan_diterima;

        }
        public void UbahSatuan()
        {
            uiconfig UIconfig = new uiconfig();
          
            if(UIconfig.config.satuan_suhu == null)
            {
                UIconfig.config.satuan_suhu = "Celcius";
                UIconfig.writeJSON();
            }
            else if (UIconfig.config.satuan_suhu == "Celcius")
            {
                UIconfig.config.satuan_suhu = "Fahrenheit";
                UIconfig.writeJSON();
                
            }
            else if (UIconfig.config.satuan_suhu == "Fahrenheit")
            {
                UIconfig.config.satuan_suhu = "Celcius";
            UIconfig.writeJSON();
        }
  

        }

    }

