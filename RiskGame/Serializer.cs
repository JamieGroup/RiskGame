using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RiskGame
{
    public class Serializer
    {
        public static bool SerializePlayer(Plys obj)
        {
            try
            {
                Stream stream = File.Open("SerializedPlayer.bin", FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, obj);
                stream.Close();
                return true;
            }
            catch
            {

            }
            return false;

        }
    }
}
