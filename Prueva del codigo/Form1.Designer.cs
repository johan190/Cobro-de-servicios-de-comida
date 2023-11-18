namespace Prueva_del_codigo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            txtTotal = new TextBox();
            txtHotDog = new TextBox();
            txtHamburgesas = new TextBox();
            txtSandwich = new TextBox();
            txtTe = new TextBox();
            txtRefresco = new TextBox();
            txtPapas = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(67, 85);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(222, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "No.1 (Hamburgesas, Refresco, Papas)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(66, 110);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(191, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "No.2 (HotDog, Refresco, Papas)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(66, 135);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(204, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "No.3 (Samdwich, Refresco, Papas)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(66, 160);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(92, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Otro pedido ";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 23);
            label1.Name = "label1";
            label1.Size = new Size(264, 32);
            label1.TabIndex = 4;
            label1.Text = "Seleccion por  pedidos ";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(67, 360);
            button1.Name = "button1";
            button1.Size = new Size(103, 41);
            button1.TabIndex = 5;
            button1.Text = "Calcular ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Location = new Point(209, 360);
            button2.Name = "button2";
            button2.Size = new Size(105, 41);
            button2.TabIndex = 6;
            button2.Text = "Salida";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 215);
            label2.Name = "label2";
            label2.Size = new Size(139, 30);
            label2.TabIndex = 7;
            label2.Text = "Total a cobrar";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(67, 260);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(128, 23);
            txtTotal.TabIndex = 8;
            // 
            // txtHotDog
            // 
            txtHotDog.Location = new Point(415, 160);
            txtHotDog.Name = "txtHotDog";
            txtHotDog.Size = new Size(128, 23);
            txtHotDog.TabIndex = 9;
            // 
            // txtHamburgesas
            // 
            txtHamburgesas.Location = new Point(415, 110);
            txtHamburgesas.Name = "txtHamburgesas";
            txtHamburgesas.Size = new Size(128, 23);
            txtHamburgesas.TabIndex = 10;
            // 
            // txtSandwich
            // 
            txtSandwich.Location = new Point(415, 206);
            txtSandwich.Name = "txtSandwich";
            txtSandwich.Size = new Size(128, 23);
            txtSandwich.TabIndex = 11;
            // 
            // txtTe
            // 
            txtTe.Location = new Point(415, 257);
            txtTe.Name = "txtTe";
            txtTe.Size = new Size(128, 23);
            txtTe.TabIndex = 12;
            txtTe.TextChanged += textBox5_TextChanged;
            // 
            // txtRefresco
            // 
            txtRefresco.Location = new Point(415, 306);
            txtRefresco.Name = "txtRefresco";
            txtRefresco.Size = new Size(128, 23);
            txtRefresco.TabIndex = 13;
            // 
            // txtPapas
            // 
            txtPapas.Location = new Point(415, 355);
            txtPapas.Name = "txtPapas";
            txtPapas.Size = new Size(128, 23);
            txtPapas.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(415, 37);
            label3.Name = "label3";
            label3.Size = new Size(133, 37);
            label3.TabIndex = 15;
            label3.Text = "Cantidad";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(552, 114);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 16;
            label4.Text = "Hamburgesa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(552, 160);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 17;
            label5.Text = "HotDog";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(552, 206);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 18;
            label6.Text = "Sandwich";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(552, 260);
            label7.Name = "label7";
            label7.Size = new Size(20, 15);
            label7.TabIndex = 19;
            label7.Text = "Te";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(549, 309);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 20;
            label8.Text = "Refresco";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(549, 355);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 21;
            label9.Text = "Papas Fritas ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(402, 9);
            label10.Name = "label10";
            label10.Size = new Size(141, 15);
            label10.TabIndex = 22;
            label10.Text = "Alimentos seleccionados ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(648, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(648, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(648, 194);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 43);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(648, 243);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(648, 289);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(76, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(648, 336);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(75, 42);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 28;
            pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPapas);
            Controls.Add(txtRefresco);
            Controls.Add(txtTe);
            Controls.Add(txtSandwich);
            Controls.Add(txtHamburgesas);
            Controls.Add(txtHotDog);
            Controls.Add(txtTotal);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cobro de servicios de comida ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox txtTotal;
        private TextBox txtHotDog;
        private TextBox txtHamburgesas;
        private TextBox txtSandwich;
        private TextBox txtTe;
        private TextBox txtRefresco;
        private TextBox txtPapas;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}