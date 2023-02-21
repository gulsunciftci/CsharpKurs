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
                //ETradeContext pahal� bir nesnedir �ok yer kaplar
                //using= blok bitti�i anda nesneyi zorla bellekten atar buna dispos denir

                dgwProducts.DataSource = context.Products.ToList();
                //tabloya eri�me kodu budur


                //connection stringi App.config i�ine <configurationString tag�n�n alt�na yazmal�y�z "server=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true"
            }
        }
    }
}