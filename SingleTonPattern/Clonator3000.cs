using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Clonator3000
    {
        public object Clone(object obj)
        {
            object clone = null; //пустая оболочка для клона
            MemoryStream memoryStream = new MemoryStream(); //происходит при помощи потока данных
                                                            //(брать данные из одного места и переливать в другое
            StreamingContext context = new StreamingContext(StreamingContextStates.Clone);//показывает что мы в итоге будет клонировать
            BinaryFormatter binaryFormatter = new BinaryFormatter(null, context);//позволяет сериализовывать объект 
                                                     //сериализация - создание потока данных из области памяти
            binaryFormatter.Serialize(memoryStream, obj);
            memoryStream.Seek(0,SeekOrigin.Begin);
            clone = binaryFormatter.Deserialize(memoryStream);
            return clone;
        }
    }
}
