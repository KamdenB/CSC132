using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CornerstoneAppartments
{
    public partial class CornerstoneApparments : Form
    {
        public double rentTotal = 0;

        public static double oneBed = 450; /** One bed price **/
        public static double twoBed = 550; /** Two bed price **/
        public static double threeBed = 700; /** Three bed price **/

        public static double twoBath = 75; /** Two bath price **/
        public static double threeBath = 150; /** Two bath price **/

        public static double lakeViewUpcharge = 50; /** Lake view upcharge price **/

        public string[] options;

        public class RentValues
        {
            public string Name { get; set; }
            public double Price { get; set; }
            
        }

        List<RentValues> rentValues = new List<RentValues>()
        {
            new RentValues { Name = "OneBed", Price = 450 },
            new RentValues { Name = "TwoBed", Price = 550 },
            new RentValues { Name = "ThreeBed", Price = 700 },

            new RentValues { Name = "TwoBath", Price = 75 },
            new RentValues { Name = "ThreeBath", Price = 150 },

            new RentValues { Name = "LakeView", Price = 100 },
            new RentValues { Name = "PondView", Price = 50 }
        };


        public class InfoValues
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public string Title { get; set; }
        }

        List<InfoValues> infoValues = new List<InfoValues>()
        {
            new InfoValues { Name = "OneBed", Text = "One bedroom apartment, perfect for the introvert programmers who doesn't like people", Title = "One Bedroom" },
            new InfoValues { Name = "TwoBed", Text = "Two bedrooom apartment, for the programmer who looks at another peroson's feet instead of their own when talking to people.", Title = "Two Bedroom" },
            new InfoValues { Name = "ThreeBed", Text = "Three bedroom apartment, whoa this programmer isn't afraid to turn on their camera during zoom calls.", Title = "Three Bedroom" },
            new InfoValues { Name = "TwoBath", Text = "Two bathrooms - maybe you and your roomate(s) dont want to share one bathroom, or if you live alone you like options", Title = "Two Bathroom" },
            new InfoValues { Name = "ThreeBath", Text = "Three bathroom apartment - most houses dont even have this many bathrooms!", Title = "Three Bathroom" },
            new InfoValues { Name = "LakeView", Text = "Lake view apartment for when you want a view of a lot of water", Title = "Lake View" },
            new InfoValues { Name = "PondView", Text = "Pond view apartment for a view when you want a little bit of water", Title = "Pond View" }
        };

        public CornerstoneApparments()
        {
            InitializeComponent();
        }

        /** Updates the rent total on change **/
        private void handleRentChange(object sender, EventArgs e)
        {
            rentTotal = 0;
            if (sender is RadioButton)
                rentTotal += rentValues.First(rent => "rad"+rent.Name == (sender as RadioButton).Name).Price;
            lblTotal.Text = rentTotal.ToString("C");
        }

        /** Dislpay information form **/
        private void handleShowInfo(object sender, EventArgs e)
        {
            var calling = infoValues.First(info => "menu" + info.Name == (sender as ToolStripMenuItem).Name);
            InformationForm infoForm = new InformationForm(calling.Name, calling.Text);
            if (sender is ToolStripMenuItem)
                infoForm.ShowDialog();
        }
    }
} 
