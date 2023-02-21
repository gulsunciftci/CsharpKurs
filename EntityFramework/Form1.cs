using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //ETradeContext pahalı bir nesnedir çok yer kaplar
                //using= blok bittiği anda nesneyi zorla bellekten atar buna dispos denir

                dgwProducts.DataSource = context.Products.ToList();
                //tabloya erişme kodu budur


                //connection stringi App.config içine <configurationString tagının altına yazmalıyız "server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true"
                //Aşağıdaki kodu ekle
                // < connectionStrings >
                //< add name = "ETradeContext"
                //   connectionString = "server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true"
                //    providerName = "System.Data.SqlClient" />
                //</ connectionStrings >



            }
        }
    }
}
