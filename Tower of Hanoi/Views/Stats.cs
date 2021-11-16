using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowerOfHanoi.Components;
using TowerOfHanoi.Data;

namespace TowerOfHanoi.Views
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
            output.Location = new Point(0, 0);
            output.Size = this.ClientSize;
            output.BackColor = Theme.Background;
            output.ForeColor = Theme.OnBackground;

            List<DataPoint> dataPoints = DataHandler.Read();
            IEnumerable<IGrouping<User, DataPoint>> byUser = dataPoints.GroupBy(x => x.User);

            WriteLine("Kísérletek száma:");
            foreach (var user in byUser)
            {
                WriteLine($"\t{user.Key.Name} ({user.Key.Age}): {user.Count()} próbálkozás");
            }
            
            WriteLine("\nÁtlag megoldási idő:");
            foreach (var user in byUser)
            {
                List<DataPoint> valid = dataPoints.FindAll(x => x.User == user.Key && x.Time.Ticks > 0);
                if(valid.Count > 0)
                    WriteLine($"\t{user.Key.Name} ({user.Key.Age}): {Math.Round(valid.Average(x => x.Time.TotalSeconds), 2)} másodperc");
            }
            
            WriteLine("\nLegfiatalabb játékosok:");
            foreach (var data in dataPoints.FindAll(x => x.User.Age == dataPoints.Min(y => y.User.Age)).GroupBy(x => x.User))
            {
                WriteLine($"\t{data.Key.Name}");
            }


            TextDialog dialog = new TextDialog();
            dialog.ShowDialog();
            double input = dialog.Value;
            WriteLine($"\nKevesebb, mint {input} másodperc alatt teljesítették:");
            List<DataPoint> filtered = dataPoints.FindAll(x => x.Time.TotalSeconds < input && x.Time.TotalSeconds != 0);
            if (filtered.Count > 0)
            {
                foreach (var data in filtered.GroupBy(x => x.User))
                {
                    WriteLine($"\t{data.Key.Name}");
                }
            }
            else
                WriteLine("\tSenki sem teljesítette ilyen gyorsan");

            dataPoints.Sort((x, y) => x.Time.CompareTo(y.Time));
            IEnumerator<IGrouping<User, DataPoint>> ranking = dataPoints.FindAll(x => x.Time.Ticks > 0).GroupBy(x=>x.User).GetEnumerator();
            WriteLine("\nA három leggyorsabb teljesítő");
            for(int i = 0; i < 3; i++)
            {
                ranking.MoveNext();
                WriteLine($"\t{i+1}. {ranking.Current.Key.ToString()}");
            }
            
        }

        private void WriteLine(string text)
        {
            output.Text += text + "\n";
        }

        private void Stats_Resize(object sender, EventArgs e)
        {
            output.Size = this.ClientSize;
        }
    }
}
