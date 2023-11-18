namespace Prueva_del_codigo
{
    public partial class Form1 : Form
    {
        //'Declaracion de variables de cantidad
        int CantidadHamburgesas;
        int CantidadHotDog;
        int CantidadSandwich;
        int CantidadTe;
        int CantidadRefresco;
        int CantidadPapas;

        double TotalVta;
        double CostoHamburgesas;
        double CostoHotDog;
        double CostoSandwich;
        double CostoTe;
        double CostoRefresco;
        double CostoPapas;

        //'Inicializar las variables con los precios de los productos 
        double Hamburgesas = 20.5;
        double HotDog = 19.25;
        double Sandwich = 17.5;
        double Papas = 4.5;
        double Refresco = 4;
        double Te;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Paqute numero 1 de camida
            txtTotal.Text = "";
            if (radioButton1.Checked == true)
            {
                CantidadHamburgesas = 1;
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 0;
                CantidadSandwich = 0;
                CantidadTe = 0;
                //Inicialixar Valores 
                txtHamburgesas.Text = CantidadHamburgesas.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();

                //Acrivar las cajas de texto del Paquete 
                txtHamburgesas.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                //Desactivar las otras cajas 
                txtHotDog.Enabled = false;
                txtTe.Enabled = false;
                txtSandwich.Enabled = false;

                //Limpiar cajas de texto 
                txtHotDog.Text = "";
                txtTe.Text = "";
                txtSandwich.Text = "";
                

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No 2 de comida 
            txtTotal.Text = "";
            if (radioButton2.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 1;
                CantidadSandwich = 0;

                //Inicializar Valores 
                txtHotDog.Text = CantidadHotDog.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();

                //activar las cajas de texto 
                txtHotDog.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                //desactivar las otras cajas 
                txtHamburgesas.Enabled = false;
                txtSandwich.Enabled = false;
                txtTe.Enabled = false;

                //Limpia las cajas de texto 
                txtHamburgesas.Text = "";
                txtSandwich.Text = "";
                txtTe.Text = "";
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //Paquete No 3 de comida 
            txtTotal.Text = "";
            if (radioButton3.Checked == true)
            {
                CantidadRefresco = 1;
                CantidadPapas = 1;
                CantidadHotDog = 0;
                CantidadSandwich = 1;
                CantidadHamburgesas = 0;

                //Inicializar Valores 
                txtSandwich.Text = CantidadHotDog.ToString();
                txtRefresco.Text = CantidadRefresco.ToString();
                txtPapas.Text = CantidadPapas.ToString();

                //activar las cajas de texto 
                txtSandwich.Enabled = true;
                txtRefresco.Enabled = true;
                txtPapas.Enabled = true;

                //desactivar las otras cajas 
                txtHamburgesas.Enabled = false;
                txtHotDog.Enabled = false;
                txtTe.Enabled = false;

                //Limpia las cajas de texto 
                txtHamburgesas.Text = "";
                txtHotDog.Text = "";
                txtTe.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //opcion de otro pedido 
            txtTotal.Text = "";
            if (radioButton4.Checked == true)
            {
                //Habilitar todas las entradas 
                txtHamburgesas.Enabled = true;
                txtHotDog.Enabled = true;
                txtSandwich.Enabled = true;
                txtPapas.Enabled = true;
                txtRefresco.Enabled = true;
                txtTe.Enabled = true;

                /*
                txtHamburgesas.Text = "";
                txtHotDog.Text = "";
                txtPapas.Text = "";
                txtRefresco.Text = "";
                txtSandwich.Text = "";
                txtTe.Text = "";*/


                double CantidadHamburgesas = int.Parse(txtHamburgesas.Text);
                double CantidadHotDog = int.Parse(txtHotDog.Text);
                double CantidadSandwich = int.Parse(txtSandwich.Text);
                double CantidadTe = int.Parse(txtTe.Text);
                double CantidadRefresco = int.Parse(txtRefresco.Text);
                double CantidadPapas = int.Parse(txtPapas.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Multiplicando la cantidad por el precio y sumando el total
            CostoHamburgesas = (CantidadHamburgesas + Hamburgesas);
            CostoHotDog = (CantidadHotDog + HotDog);
            CostoSandwich = (CantidadSandwich + Sandwich);
            CostoTe = (CantidadTe + Te);
            CostoRefresco = (CantidadRefresco + Refresco);
            CostoPapas = (CantidadPapas + Papas);
            TotalVta = CostoHamburgesas + CostoHotDog + CostoPapas + CostoRefresco + CostoSandwich + CostoTe;
            txtTotal.Text = TotalVta.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}