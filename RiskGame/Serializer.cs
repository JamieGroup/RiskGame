using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
            
        }
    }
}
