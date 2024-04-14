using System;
using System.Text.Json;
using System.Xml.Serialization;

    public class uiconfig
    {
        public CovidConfig config;
        public const string filePath = "C:\\Kuliah\\kpl\\tpmodul8_1302223044\\tpmodul8_1302223044\\covid_config.json";

        public uiconfig()
        {
            try
            {
                ReadJSON();
            }
            catch (Exception)
            {
                SetDefault();
                writeJSON();
            }
        }
        public void SetDefault()
        {
            config.satuan_suhu = "Celcius";
            config.batas_hari_demam = 14;
            config.pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            config.pesan_diterima = "Anda dipersilahkan masuk ke dalam gedung ini";
        }

        public CovidConfig ReadJSON()
        {
            string jsonData = File.ReadAllText(filePath);
            config = JsonSerializer.Deserialize<CovidConfig>(jsonData);
            return config;
        }
        public void writeJSON()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            string jsonString = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filePath, jsonString);
        }

    }
