using Newtonsoft.Json;
using NUnit.Framework;
using System.Text.Json;

namespace UnrealEngine.Gvas.Test
{
    public class Test
    {
        [Test]
        public void Parse()
        {
            var save = SaveGameFile.LoadFrom(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Talos2\Saved\SaveGames\savedata_0.sav");
            Console.WriteLine(JsonConvert.SerializeObject(save));
        }
    }
}
