
namespace ProiectAsofronieiRoxana
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputCompany = new System.Windows.Forms.TextBox();
            this.inputServings = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.addNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 568);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tea products";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(14, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(243, 46);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "TeaShop";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(273, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 379);
            this.listBox1.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Firebrick;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteButton.Location = new System.Drawing.Point(279, 474);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 79);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(404, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 79);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generate product list file";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(449, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(311, 46);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Manage products";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(705, 89);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(233, 23);
            this.inputName.TabIndex = 4;
            this.inputName.Text = "Name";
            // 
            // inputCompany
            // 
            this.inputCompany.Location = new System.Drawing.Point(705, 118);
            this.inputCompany.Name = "inputCompany";
            this.inputCompany.Size = new System.Drawing.Size(233, 23);
            this.inputCompany.TabIndex = 5;
            this.inputCompany.Text = "Company";
            // 
            // inputServings
            // 
            this.inputServings.Location = new System.Drawing.Point(705, 147);
            this.inputServings.Name = "inputServings";
            this.inputServings.Size = new System.Drawing.Size(233, 23);
            this.inputServings.TabIndex = 6;
            this.inputServings.Text = "Servings";
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(705, 176);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(233, 23);
            this.inputPrice.TabIndex = 7;
            this.inputPrice.Text = "Price";
            // 
            // addNew
            // 
            this.addNew.BackColor = System.Drawing.Color.OliveDrab;
            this.addNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNew.Location = new System.Drawing.Point(705, 219);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(233, 46);
            this.addNew.TabIndex = 8;
            this.addNew.Text = "Add new";
            this.addNew.UseVisualStyleBackColor = false;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(950, 565);
            this.Controls.Add(this.addNew);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.inputServings);
            this.Controls.Add(this.inputCompany);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "                                                                     ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputCompany;
        private System.Windows.Forms.TextBox inputServings;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Button addNew;
    }
}

