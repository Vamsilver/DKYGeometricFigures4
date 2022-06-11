/*
    Vasilev Roman 220P,
    Figures2-Figures,
    27.04.22
 */

using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace DKYGeometricFigures4
{
    public class Figures
    {
        List<Figure> listFigures;

        public Figures()
        {
            listFigures = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            listFigures.Add(figure);
        }

        public void PopBack()
        {
            if(listFigures.Count != 0)
            {
                listFigures.RemoveAt(listFigures.Count - 1);
            }
        }

        public void Clear()
        {
            listFigures.Clear();
        }

        public void Save(string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream stream = File.Open(path, FileMode.Create))
            {
                binaryFormatter.Serialize(stream, listFigures);
            }

        }

        public void Load(string path)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (Stream stream = File.Open(path, FileMode.Open))
            {
                listFigures = (List<Figure>) binaryFormatter.Deserialize(stream);
            }
        }

        public void Draw(IDrawer drawer)
        {
            foreach (var f in listFigures)
            {
                f.Draw(drawer);
            }
        }
    }
}
