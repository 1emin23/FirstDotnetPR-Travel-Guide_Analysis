using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_01_PRGuide
{
    public partial class FrmGuide : Form
    {
        public FrmGuide()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Entities db = new Entities();
        private void FrmGuide_Load(object sender, EventArgs e)
        {
            lblLocCount.Text = db.Location.Count().ToString();
            lblSumCap.Text = db.Location.Sum(x => x.Capacity).ToString();
            lblMaxCap.Text = db.Location.Max(x => x.Capacity).ToString();
            lblAvgPrice.Text = (db.Location.Average(x => x.Price) ?? 0 ).ToString("N2");
            int id = db.Location.Max(x =>x.LocationId);
            
            var lastCountryVisitedName = db.Location.Where(x => x.LocationId == id).FirstOrDefault();
            lblLatestCountry.Text = lastCountryVisitedName.Country.ToString();
            var avgCapacityTurkey = db.Location.Where(x => x.Country == "Türkiye").Average(x => x.Capacity);
            lblAvgTurkeyCap.Text = ((avgCapacityTurkey) ?? 0).ToString("F0");

            lblMaxPrice.Text = (db.Location.Max(x => x.Price) ?? 0).ToString("N2");

            lblGuideCount.Text = db.Guide.Count().ToString();
            lblAvgCap.Text = (db.Location.Average(x => x.Capacity) ?? 0).ToString("F0");

        }
    }
}
