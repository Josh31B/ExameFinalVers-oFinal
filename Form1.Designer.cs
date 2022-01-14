namespace CalculadoraWindowsJosh
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPadrao1 = new System.Windows.Forms.Button();
            this.btnCalculado1 = new System.Windows.Forms.Label();
            this.btnResultado1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblConta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnMaisouMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPadrao1
            // 
            this.btnPadrao1.FlatAppearance.BorderSize = 0;
            this.btnPadrao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPadrao1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadrao1.Location = new System.Drawing.Point(43, 22);
            this.btnPadrao1.Name = "btnPadrao1";
            this.btnPadrao1.Size = new System.Drawing.Size(92, 39);
            this.btnPadrao1.TabIndex = 0;
            this.btnPadrao1.Text = "Padrão";
            this.btnPadrao1.UseVisualStyleBackColor = true;
            this.btnPadrao1.Click += new System.EventHandler(this.btnPadrao);
            // 
            // btnCalculado1
            // 
            this.btnCalculado1.AutoSize = true;
            this.btnCalculado1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculado1.Location = new System.Drawing.Point(2, 0);
            this.btnCalculado1.Name = "btnCalculado1";
            this.btnCalculado1.Size = new System.Drawing.Size(88, 20);
            this.btnCalculado1.TabIndex = 1;
            this.btnCalculado1.Text = "Calculadora";
            this.btnCalculado1.Click += new System.EventHandler(this.btnCalculadora);
            // 
            // btnResultado1
            // 
            this.btnResultado1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnResultado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado1.Location = new System.Drawing.Point(6, 73);
            this.btnResultado1.Name = "btnResultado1";
            this.btnResultado1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResultado1.Size = new System.Drawing.Size(416, 86);
            this.btnResultado1.TabIndex = 2;
            this.btnResultado1.Text = "0";
            this.btnResultado1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResultado1.Click += new System.EventHandler(this.btnResultado);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblConta);
            this.splitContainer1.Panel1.Controls.Add(this.btnPadrao1);
            this.splitContainer1.Panel1.Controls.Add(this.btnResultado1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.button8);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(422, 609);
            this.splitContainer1.SplitterDistance = 159;
            this.splitContainer1.TabIndex = 3;
            this.splitContainer1.Click += new System.EventHandler(this.lblResultado);
            // 
            // lblConta
            // 
            this.lblConta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta.Location = new System.Drawing.Point(4, 55);
            this.lblConta.Name = "lblConta";
            this.lblConta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConta.Size = new System.Drawing.Size(416, 25);
            this.lblConta.TabIndex = 3;
            this.lblConta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConta.Click += new System.EventHandler(this.lblConta_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-6, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "≡";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnIgual3);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnIgual, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnVirgula, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNum0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnMaisouMenos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnMais, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNum1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMenos, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNum4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVezes, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnNum7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDivisao, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button14, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button13, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLimpar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 407);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // btnIgual
            // 
            this.btnIgual.AutoSize = true;
            this.btnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(317, 337);
            this.btnIgual.Margin = new System.Windows.Forms.Padding(2);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(103, 68);
            this.btnIgual.TabIndex = 23;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.AutoSize = true;
            this.btnVirgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnVirgula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVirgula.FlatAppearance.BorderSize = 0;
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(212, 337);
            this.btnVirgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(101, 68);
            this.btnVirgula.TabIndex = 22;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.AutoSize = true;
            this.btnNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum0.FlatAppearance.BorderSize = 0;
            this.btnNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(107, 337);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(101, 68);
            this.btnNum0.TabIndex = 21;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = false;
            this.btnNum0.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMaisouMenos
            // 
            this.btnMaisouMenos.AutoSize = true;
            this.btnMaisouMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMaisouMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaisouMenos.FlatAppearance.BorderSize = 0;
            this.btnMaisouMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisouMenos.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisouMenos.Location = new System.Drawing.Point(2, 337);
            this.btnMaisouMenos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaisouMenos.Name = "btnMaisouMenos";
            this.btnMaisouMenos.Size = new System.Drawing.Size(101, 68);
            this.btnMaisouMenos.TabIndex = 20;
            this.btnMaisouMenos.Text = "+/-";
            this.btnMaisouMenos.UseVisualStyleBackColor = false;
            this.btnMaisouMenos.Click += new System.EventHandler(this.btnMaisouMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.AutoSize = true;
            this.btnMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMais.FlatAppearance.BorderSize = 0;
            this.btnMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMais.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(317, 270);
            this.btnMais.Margin = new System.Windows.Forms.Padding(2);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(103, 63);
            this.btnMais.TabIndex = 19;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.AutoSize = true;
            this.btnNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum3.FlatAppearance.BorderSize = 0;
            this.btnNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(212, 270);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(101, 63);
            this.btnNum3.TabIndex = 18;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = false;
            this.btnNum3.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.AutoSize = true;
            this.btnNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum2.FlatAppearance.BorderSize = 0;
            this.btnNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(107, 270);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(101, 63);
            this.btnNum2.TabIndex = 17;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = false;
            this.btnNum2.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.AutoSize = true;
            this.btnNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum1.FlatAppearance.BorderSize = 0;
            this.btnNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(2, 270);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(101, 63);
            this.btnNum1.TabIndex = 16;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = false;
            this.btnNum1.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.AutoSize = true;
            this.btnMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenos.FlatAppearance.BorderSize = 0;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(317, 203);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(103, 63);
            this.btnMenos.TabIndex = 15;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.AutoSize = true;
            this.btnNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum6.FlatAppearance.BorderSize = 0;
            this.btnNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(212, 203);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(101, 63);
            this.btnNum6.TabIndex = 14;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = false;
            this.btnNum6.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.AutoSize = true;
            this.btnNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum5.FlatAppearance.BorderSize = 0;
            this.btnNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(107, 203);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(101, 63);
            this.btnNum5.TabIndex = 13;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = false;
            this.btnNum5.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.AutoSize = true;
            this.btnNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum4.FlatAppearance.BorderSize = 0;
            this.btnNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(2, 203);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(101, 63);
            this.btnNum4.TabIndex = 12;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = false;
            this.btnNum4.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.AutoSize = true;
            this.btnVezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnVezes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVezes.FlatAppearance.BorderSize = 0;
            this.btnVezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVezes.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVezes.Location = new System.Drawing.Point(317, 136);
            this.btnVezes.Margin = new System.Windows.Forms.Padding(2);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(103, 63);
            this.btnVezes.TabIndex = 11;
            this.btnVezes.Text = "X";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.AutoSize = true;
            this.btnNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum9.FlatAppearance.BorderSize = 0;
            this.btnNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(212, 136);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(101, 63);
            this.btnNum9.TabIndex = 10;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = false;
            this.btnNum9.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.AutoSize = true;
            this.btnNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum8.FlatAppearance.BorderSize = 0;
            this.btnNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(107, 136);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(101, 63);
            this.btnNum8.TabIndex = 9;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = false;
            this.btnNum8.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.AutoSize = true;
            this.btnNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNum7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNum7.FlatAppearance.BorderSize = 0;
            this.btnNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNum7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(2, 136);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(101, 63);
            this.btnNum7.TabIndex = 8;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = false;
            this.btnNum7.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.AutoSize = true;
            this.btnDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDivisao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivisao.FlatAppearance.BorderSize = 0;
            this.btnDivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivisao.Font = new System.Drawing.Font("Segoe UI Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(317, 69);
            this.btnDivisao.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(103, 63);
            this.btnDivisao.TabIndex = 7;
            this.btnDivisao.Text = "﻿÷";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnOpe_Click);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(212, 69);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(101, 63);
            this.button14.TabIndex = 6;
            this.button14.Text = "²√x";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(107, 69);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 63);
            this.button13.TabIndex = 5;
            this.button13.Text = "x²";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(2, 69);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(101, 63);
            this.button12.TabIndex = 4;
            this.button12.Text = "1/x";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::CalculadoraWindowsJosh.Properties.Resources.backspace__2_;
            this.btnExcluir.Location = new System.Drawing.Point(317, 2);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 63);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(212, 2);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 63);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(107, 2);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 63);
            this.button9.TabIndex = 1;
            this.button9.Text = "CE";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btn);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(2, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 63);
            this.button2.TabIndex = 0;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnPorcentagem);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(3, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(65, 26);
            this.button8.TabIndex = 3;
            this.button8.Text = "M";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(354, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 26);
            this.button7.TabIndex = 3;
            this.button7.Text = "MS";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(283, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 26);
            this.button6.TabIndex = 3;
            this.button6.Text = "M-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(212, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 26);
            this.button5.TabIndex = 3;
            this.button5.Text = "M+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(141, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "MR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(70, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "MC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(422, 609);
            this.Controls.Add(this.btnCalculado1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPadrao1;
        private System.Windows.Forms.Label btnCalculado1;
        private System.Windows.Forms.Label btnResultado1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnMaisouMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.Button button1;
    }
}

