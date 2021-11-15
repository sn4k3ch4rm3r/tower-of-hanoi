using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                    WriteLine($"\t{user.Key.Name} ({user.Key.Age}): {valid.Average(x => x.Time.TotalSeconds)} másodperc");
            }
            
            WriteLine("\nLegfiatalabb játékosok:");
            foreach (var data in dataPoints.FindAll(x => x.User.Age == dataPoints.Min(y => y.User.Age)).GroupBy(x => x.User))
            {
                WriteLine($"\t{data.Key.Name}");
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
