namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(ETradeContext context=new ETradeContext())
            {
                //ETradeContext pahalý bir nesnedir çok yer kaplar
                //using= blok bittiði anda nesneyi zorla bellekten atar buna dispos denir

                dgwProducts.DataSource = context.Products.ToList();
                //tabloya eriþme kodu budur


                //connection stringi App.config içine <configurationString tagýnýn altýna yazmalýyýz "server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true"
            }
        }
    }
}