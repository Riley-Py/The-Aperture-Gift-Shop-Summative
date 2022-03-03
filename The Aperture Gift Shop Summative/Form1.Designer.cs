namespace The_Aperture_Gift_Shop_Summative
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Label();
            this.labelCube = new System.Windows.Forms.Label();
            this.labelTurrets = new System.Windows.Forms.Label();
            this.labelPersonalityCores = new System.Windows.Forms.Label();
            this.inputNumCubes = new System.Windows.Forms.TextBox();
            this.inputNumTurrets = new System.Windows.Forms.TextBox();
            this.inputNumCores = new System.Windows.Forms.TextBox();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.outputSubtotal = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.outputTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.labelTendered = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelChange = new System.Windows.Forms.Label();
            this.outputChange = new System.Windows.Forms.Label();
            this.buttonReceipt = new System.Windows.Forms.Button();
            this.costCube = new System.Windows.Forms.Label();
            this.costTurrets = new System.Windows.Forms.Label();
            this.costPersonalityCores = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.receiptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(172, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(251, 20);
            this.title.TabIndex = 0;
            this.title.Text = "The Aperture Gift Shop!";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCube
            // 
            this.labelCube.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelCube.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCube.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelCube.Location = new System.Drawing.Point(12, 47);
            this.labelCube.Name = "labelCube";
            this.labelCube.Size = new System.Drawing.Size(189, 20);
            this.labelCube.TabIndex = 1;
            this.labelCube.Text = "Number of companion cubes:\r\n\r\n";
            // 
            // labelTurrets
            // 
            this.labelTurrets.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelTurrets.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurrets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTurrets.Location = new System.Drawing.Point(55, 95);
            this.labelTurrets.Name = "labelTurrets";
            this.labelTurrets.Size = new System.Drawing.Size(136, 20);
            this.labelTurrets.TabIndex = 2;
            this.labelTurrets.Text = "Number of turrets:";
            // 
            // labelPersonalityCores
            // 
            this.labelPersonalityCores.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelPersonalityCores.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalityCores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelPersonalityCores.Location = new System.Drawing.Point(12, 143);
            this.labelPersonalityCores.Name = "labelPersonalityCores";
            this.labelPersonalityCores.Size = new System.Drawing.Size(179, 20);
            this.labelPersonalityCores.TabIndex = 3;
            this.labelPersonalityCores.Text = "Number of personality cores:\r\n\r\n";
            // 
            // inputNumCubes
            // 
            this.inputNumCubes.Location = new System.Drawing.Point(197, 47);
            this.inputNumCubes.Name = "inputNumCubes";
            this.inputNumCubes.Size = new System.Drawing.Size(45, 20);
            this.inputNumCubes.TabIndex = 4;
            this.inputNumCubes.TextChanged += new System.EventHandler(this.inputNumCubes_TextChanged);
            // 
            // inputNumTurrets
            // 
            this.inputNumTurrets.Location = new System.Drawing.Point(197, 95);
            this.inputNumTurrets.Name = "inputNumTurrets";
            this.inputNumTurrets.Size = new System.Drawing.Size(45, 20);
            this.inputNumTurrets.TabIndex = 5;
            this.inputNumTurrets.TextChanged += new System.EventHandler(this.inputNumTurrets_TextChanged);
            // 
            // inputNumCores
            // 
            this.inputNumCores.Location = new System.Drawing.Point(197, 143);
            this.inputNumCores.Name = "inputNumCores";
            this.inputNumCores.Size = new System.Drawing.Size(45, 20);
            this.inputNumCores.TabIndex = 6;
            this.inputNumCores.TextChanged += new System.EventHandler(this.inputNumCores_TextChanged);
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.calculateTotalsButton.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotalsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.calculateTotalsButton.Location = new System.Drawing.Point(15, 178);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(227, 26);
            this.calculateTotalsButton.TabIndex = 7;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = false;
            this.calculateTotalsButton.Click += new System.EventHandler(this.calculateTotalsButton_Click);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelSubtotal.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelSubtotal.Location = new System.Drawing.Point(28, 216);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(77, 20);
            this.labelSubtotal.TabIndex = 8;
            this.labelSubtotal.Text = "Subtotal:\r\n\r\n\r\n";
            // 
            // outputSubtotal
            // 
            this.outputSubtotal.AutoSize = true;
            this.outputSubtotal.Location = new System.Drawing.Point(111, 221);
            this.outputSubtotal.Name = "outputSubtotal";
            this.outputSubtotal.Size = new System.Drawing.Size(43, 15);
            this.outputSubtotal.TabIndex = 9;
            this.outputSubtotal.Text = "            ";
            // 
            // labelTax
            // 
            this.labelTax.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelTax.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTax.Location = new System.Drawing.Point(68, 254);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(37, 20);
            this.labelTax.TabIndex = 10;
            this.labelTax.Text = "Tax:";
            // 
            // outputTax
            // 
            this.outputTax.AutoSize = true;
            this.outputTax.Location = new System.Drawing.Point(111, 259);
            this.outputTax.Name = "outputTax";
            this.outputTax.Size = new System.Drawing.Size(43, 15);
            this.outputTax.TabIndex = 11;
            this.outputTax.Text = "            ";
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelTotal.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTotal.Location = new System.Drawing.Point(48, 290);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(57, 20);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total:";
            // 
            // outputTotal
            // 
            this.outputTotal.AutoSize = true;
            this.outputTotal.Location = new System.Drawing.Point(111, 295);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(43, 15);
            this.outputTotal.TabIndex = 13;
            this.outputTotal.Text = "            ";
            // 
            // divider
            // 
            this.divider.BackColor = System.Drawing.Color.SteelBlue;
            this.divider.Location = new System.Drawing.Point(28, 336);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(214, 13);
            this.divider.TabIndex = 14;
            this.divider.Text = "            ";
            // 
            // labelTendered
            // 
            this.labelTendered.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelTendered.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTendered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTendered.Location = new System.Drawing.Point(31, 369);
            this.labelTendered.Name = "labelTendered";
            this.labelTendered.Size = new System.Drawing.Size(77, 20);
            this.labelTendered.TabIndex = 15;
            this.labelTendered.Text = "Tendered:";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(114, 369);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(45, 20);
            this.tenderedInput.TabIndex = 16;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonChange.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonChange.Location = new System.Drawing.Point(15, 410);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(227, 26);
            this.buttonChange.TabIndex = 17;
            this.buttonChange.Text = "Calculate Change";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelChange
            // 
            this.labelChange.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelChange.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelChange.Location = new System.Drawing.Point(48, 455);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(57, 20);
            this.labelChange.TabIndex = 18;
            this.labelChange.Text = "Change:";
            // 
            // outputChange
            // 
            this.outputChange.AutoSize = true;
            this.outputChange.Location = new System.Drawing.Point(111, 460);
            this.outputChange.Name = "outputChange";
            this.outputChange.Size = new System.Drawing.Size(43, 15);
            this.outputChange.TabIndex = 19;
            this.outputChange.Text = "            ";
            // 
            // buttonReceipt
            // 
            this.buttonReceipt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonReceipt.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReceipt.Location = new System.Drawing.Point(15, 497);
            this.buttonReceipt.Name = "buttonReceipt";
            this.buttonReceipt.Size = new System.Drawing.Size(227, 26);
            this.buttonReceipt.TabIndex = 20;
            this.buttonReceipt.Text = "Calculate Receipt";
            this.buttonReceipt.UseVisualStyleBackColor = false;
            this.buttonReceipt.Click += new System.EventHandler(this.buttonReceipt_Click);
            // 
            // costCube
            // 
            this.costCube.AutoSize = true;
            this.costCube.BackColor = System.Drawing.Color.DarkSlateGray;
            this.costCube.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costCube.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.costCube.Location = new System.Drawing.Point(281, 48);
            this.costCube.Name = "costCube";
            this.costCube.Size = new System.Drawing.Size(16, 17);
            this.costCube.TabIndex = 22;
            this.costCube.Text = "0";
            // 
            // costTurrets
            // 
            this.costTurrets.AutoSize = true;
            this.costTurrets.BackColor = System.Drawing.Color.DarkSlateGray;
            this.costTurrets.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTurrets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.costTurrets.Location = new System.Drawing.Point(281, 100);
            this.costTurrets.Name = "costTurrets";
            this.costTurrets.Size = new System.Drawing.Size(16, 17);
            this.costTurrets.TabIndex = 23;
            this.costTurrets.Text = "0";
            // 
            // costPersonalityCores
            // 
            this.costPersonalityCores.AutoSize = true;
            this.costPersonalityCores.BackColor = System.Drawing.Color.DarkSlateGray;
            this.costPersonalityCores.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPersonalityCores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.costPersonalityCores.Location = new System.Drawing.Point(281, 148);
            this.costPersonalityCores.Name = "costPersonalityCores";
            this.costPersonalityCores.Size = new System.Drawing.Size(16, 17);
            this.costPersonalityCores.TabIndex = 24;
            this.costPersonalityCores.Text = "0";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.clearButton.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearButton.Location = new System.Drawing.Point(312, 455);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(227, 26);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "New Order";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(243, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(248, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // receiptLabel
            // 
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(312, 178);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(237, 246);
            this.receiptLabel.TabIndex = 29;
            this.receiptLabel.Text = "       ";
            // 
            // Form1
            // 
            this.BackgroundImage = global::The_Aperture_Gift_Shop_Summative.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(587, 538);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.costPersonalityCores);
            this.Controls.Add(this.costTurrets);
            this.Controls.Add(this.costCube);
            this.Controls.Add(this.buttonReceipt);
            this.Controls.Add(this.outputChange);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.labelTendered);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.outputTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.outputTax);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.outputSubtotal);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.inputNumCores);
            this.Controls.Add(this.inputNumTurrets);
            this.Controls.Add(this.inputNumCubes);
            this.Controls.Add(this.labelPersonalityCores);
            this.Controls.Add(this.labelTurrets);
            this.Controls.Add(this.labelCube);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Aperture Gift Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleStore;
        private System.Windows.Forms.Label labelCube;
        private System.Windows.Forms.Label labelTurrets;
        private System.Windows.Forms.Label labelPersonalityCores;
        private System.Windows.Forms.TextBox inputNumCubes;
        private System.Windows.Forms.TextBox inputNumTurrets;
        private System.Windows.Forms.TextBox inputNumCores;
        private System.Windows.Forms.Button calculateTotalsButton;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label outputSubtotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label outputTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label outputTotal;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label labelTendered;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label outputChange;
        private System.Windows.Forms.Button buttonReceipt;
        private System.Windows.Forms.Label costCube;
        private System.Windows.Forms.Label costTurrets;
        private System.Windows.Forms.Label costPersonalityCores;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label receiptLabel;
    }
}

