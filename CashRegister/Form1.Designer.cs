
namespace CashRegister
{
    partial class Minecraft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minecraft));
            this.titleLabel = new System.Windows.Forms.Label();
            this.nofWeaponsLabel = new System.Windows.Forms.Label();
            this.nofWoodLabel = new System.Windows.Forms.Label();
            this.nofMinedLabel = new System.Windows.Forms.Label();
            this.weaponsInput = new System.Windows.Forms.TextBox();
            this.woodInput = new System.Windows.Forms.TextBox();
            this.minedInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.reciptButton = new System.Windows.Forms.Button();
            this.totalTaxLabel = new System.Windows.Forms.Label();
            this.tenderingInput = new System.Windows.Forms.TextBox();
            this.changeTotalLabel = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.pricesButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.ordernameInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Snow;
            this.titleLabel.Image = ((System.Drawing.Image)(resources.GetObject("titleLabel.Image")));
            this.titleLabel.Location = new System.Drawing.Point(-8, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(697, 64);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Minecraft Inventory Shop";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nofWeaponsLabel
            // 
            this.nofWeaponsLabel.AutoSize = true;
            this.nofWeaponsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nofWeaponsLabel.Location = new System.Drawing.Point(12, 85);
            this.nofWeaponsLabel.Name = "nofWeaponsLabel";
            this.nofWeaponsLabel.Size = new System.Drawing.Size(167, 20);
            this.nofWeaponsLabel.TabIndex = 1;
            this.nofWeaponsLabel.Text = "Number of Weapons:";
            // 
            // nofWoodLabel
            // 
            this.nofWoodLabel.AutoSize = true;
            this.nofWoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nofWoodLabel.Location = new System.Drawing.Point(12, 131);
            this.nofWoodLabel.Name = "nofWoodLabel";
            this.nofWoodLabel.Size = new System.Drawing.Size(196, 20);
            this.nofWoodLabel.TabIndex = 2;
            this.nofWoodLabel.Text = "Number of Wood Blocks:";
            // 
            // nofMinedLabel
            // 
            this.nofMinedLabel.AutoSize = true;
            this.nofMinedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nofMinedLabel.Location = new System.Drawing.Point(12, 179);
            this.nofMinedLabel.Name = "nofMinedLabel";
            this.nofMinedLabel.Size = new System.Drawing.Size(198, 20);
            this.nofMinedLabel.TabIndex = 3;
            this.nofMinedLabel.Text = "Number of Mined Blocks:";
            // 
            // weaponsInput
            // 
            this.weaponsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponsInput.Location = new System.Drawing.Point(228, 78);
            this.weaponsInput.Name = "weaponsInput";
            this.weaponsInput.Size = new System.Drawing.Size(100, 27);
            this.weaponsInput.TabIndex = 4;
            // 
            // woodInput
            // 
            this.woodInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.woodInput.Location = new System.Drawing.Point(228, 128);
            this.woodInput.Name = "woodInput";
            this.woodInput.Size = new System.Drawing.Size(100, 27);
            this.woodInput.TabIndex = 5;
            // 
            // minedInput
            // 
            this.minedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minedInput.Location = new System.Drawing.Point(228, 172);
            this.minedInput.Name = "minedInput";
            this.minedInput.Size = new System.Drawing.Size(100, 27);
            this.minedInput.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(84, 226);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(157, 32);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalsLabel
            // 
            this.totalsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.Location = new System.Drawing.Point(26, 299);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(161, 101);
            this.totalsLabel.TabIndex = 8;
            this.totalsLabel.Text = "Subtotal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tax:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(26, 437);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(84, 20);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(26, 530);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(71, 20);
            this.changeLabel.TabIndex = 12;
            this.changeLabel.Text = "Change:";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(48, 475);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(157, 32);
            this.changeButton.TabIndex = 13;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // reciptButton
            // 
            this.reciptButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.reciptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptButton.Location = new System.Drawing.Point(48, 618);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(157, 32);
            this.reciptButton.TabIndex = 14;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = false;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // totalTaxLabel
            // 
            this.totalTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTaxLabel.Location = new System.Drawing.Point(141, 297);
            this.totalTaxLabel.Name = "totalTaxLabel";
            this.totalTaxLabel.Size = new System.Drawing.Size(187, 137);
            this.totalTaxLabel.TabIndex = 15;
            // 
            // tenderingInput
            // 
            this.tenderingInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderingInput.Location = new System.Drawing.Point(141, 437);
            this.tenderingInput.Name = "tenderingInput";
            this.tenderingInput.Size = new System.Drawing.Size(100, 27);
            this.tenderingInput.TabIndex = 18;
            // 
            // changeTotalLabel
            // 
            this.changeTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTotalLabel.Location = new System.Drawing.Point(141, 530);
            this.changeTotalLabel.Name = "changeTotalLabel";
            this.changeTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.changeTotalLabel.TabIndex = 19;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.White;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(350, 84);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(318, 469);
            this.receiptLabel.TabIndex = 20;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(350, 571);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(128, 32);
            this.newButton.TabIndex = 21;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // pricesButton
            // 
            this.pricesButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pricesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricesButton.Location = new System.Drawing.Point(527, 571);
            this.pricesButton.Name = "pricesButton";
            this.pricesButton.Size = new System.Drawing.Size(128, 32);
            this.pricesButton.TabIndex = 22;
            this.pricesButton.Text = "Show Prices";
            this.pricesButton.UseVisualStyleBackColor = false;
            this.pricesButton.Click += new System.EventHandler(this.pricesButton_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderLabel.Location = new System.Drawing.Point(26, 577);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(106, 20);
            this.orderLabel.TabIndex = 23;
            this.orderLabel.Text = "Order Name:";
            // 
            // ordernameInput
            // 
            this.ordernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernameInput.Location = new System.Drawing.Point(141, 574);
            this.ordernameInput.Name = "ordernameInput";
            this.ordernameInput.Size = new System.Drawing.Size(100, 27);
            this.ordernameInput.TabIndex = 24;
            // 
            // Minecraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(680, 662);
            this.Controls.Add(this.ordernameInput);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.pricesButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.changeTotalLabel);
            this.Controls.Add(this.tenderingInput);
            this.Controls.Add(this.totalTaxLabel);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalsLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.minedInput);
            this.Controls.Add(this.woodInput);
            this.Controls.Add(this.weaponsInput);
            this.Controls.Add(this.nofMinedLabel);
            this.Controls.Add(this.nofWoodLabel);
            this.Controls.Add(this.nofWeaponsLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minecraft";
            this.Text = "Minecraft Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nofWeaponsLabel;
        private System.Windows.Forms.Label nofWoodLabel;
        private System.Windows.Forms.Label nofMinedLabel;
        private System.Windows.Forms.TextBox weaponsInput;
        private System.Windows.Forms.TextBox woodInput;
        private System.Windows.Forms.TextBox minedInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Label totalTaxLabel;
        private System.Windows.Forms.TextBox tenderingInput;
        private System.Windows.Forms.Label changeTotalLabel;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button pricesButton;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.TextBox ordernameInput;
    }
}

