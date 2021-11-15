using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TowerOfHanoi.Data
{
    class DataHandler
    {
        private const string FILENAME = "stats.csv";

        public static void Write(User user, TimeSpan time)
        {
            File.AppendAllText(FILENAME, $"{user.Name};{user.Age};{time.Ticks}\n");
        }

        public static List<DataPoint> Read()
        {
            string[] lines = File.ReadAllLines(FILENAME);
            List<DataPoint> dataPoints = new List<DataPoint>();
            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                DataPoint dp = new DataPoint(
                    new User(data[0], int.Parse(data[1])),
                    new TimeSpan(long.Parse(data[2]))
                );
                dataPoints.Add(dp);
            }
            return dataPoints;
        }
    }
}
