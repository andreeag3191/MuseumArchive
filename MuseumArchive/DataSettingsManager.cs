using Newtonsoft.Json;
using System.IO;

namespace MuseumArchive
{
    public class DataSettingsManager
    {
        private const string dataSettingsFilePath = "dataSettings.json";

        public static DataSettings LoadSettings()
        {
            string text = File.ReadAllText(dataSettingsFilePath);

            if (string.IsNullOrEmpty(text))
                return new DataSettings();

            DataSettings settings = JsonConvert.DeserializeObject<DataSettings>(text);

            return settings;
        }
    }

    public class DataSettings
    {
        public string ConnectionString { get; set; }
    }
}
