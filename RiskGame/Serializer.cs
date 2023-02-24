using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RiskGame
{
    public class Serializer
    {
        public static AES a = new AES();

        public static bool SerializePlayer(Plys obj)
        {
            try
            {
                if(!Directory.Exists("tmp"))
                {
                    Directory.CreateDirectory("tmp");
                }
                
                Stream stream = File.Open($"tmp\\{obj.username}.bin", FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, obj);
                stream.Close();

                a.FileEncrypt($"tmp\\{obj.username}.bin", obj.passwordHash, obj.username);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Plys DeserializePlayer(string username, string passwordHash)
        {
            try
            {
                if(!File.Exists($"tmp\\{username}.bin"))
                {
                    a.FileDecrypt($"usr\\{username}.aes", $"tmp\\{username}.bin", passwordHash);
                }

                Stream stream = File.Open($"tmp\\{username}.bin", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                Plys objectDeSerialized = (Plys)bformatter.Deserialize(stream);
                stream.Close();
                return objectDeSerialized;
            }
            catch
            {
                return null;
            }
        }
    }
}
