
namespace MainProject
{
    partial class FootTableControl
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
            System.Windows.Forms.Label carbsLabel;
            System.Windows.Forms.Label fiberLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label protein_Label;
            System.Windows.Forms.Label foodLabel;
            System.Windows.Forms.Label fatsLabel;
            System.Windows.Forms.Label calories_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FootTableControl));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.carbsTextBox = new System.Windows.Forms.TextBox();
            this.fiberTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.protein_TextBox = new System.Windows.Forms.TextBox();
            this.fatsTextBox = new System.Windows.Forms.TextBox();
            this.foodTextBox = new System.Windows.Forms.TextBox();
            this.calories_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sheet1_TableAdapter1 = new MainProject.nutDataSetTableAdapters.Sheet1_TableAdapter();
            carbsLabel = new System.Windows.Forms.Label();
            fiberLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            protein_Label = new System.Windows.Forms.Label();
            foodLabel = new System.Windows.Forms.Label();
            fatsLabel = new System.Windows.Forms.Label();
            calories_Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // carbsLabel
            // 
            carbsLabel.AutoSize = true;
            carbsLabel.Location = new System.Drawing.Point(264, 110);
            carbsLabel.Name = "carbsLabel";
            carbsLabel.Size = new System.Drawing.Size(53, 18);
            carbsLabel.TabIndex = 14;
            carbsLabel.Text = "Carbs:";
            // 
            // fiberLabel
            // 
            fiberLabel.AutoSize = true;
            fiberLabel.Location = new System.Drawing.Point(35, 110);
            fiberLabel.Name = "fiberLabel";
            fiberLabel.Size = new System.Drawing.Size(51, 18);
            fiberLabel.TabIndex = 18;
            fiberLabel.Text = "Fiber:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(35, 70);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(72, 18);
            amountLabel.TabIndex = 8;
            amountLabel.Text = "Amount:";
            // 
            // protein_Label
            // 
            protein_Label.AutoSize = true;
            protein_Label.Location = new System.Drawing.Point(511, 68);
            protein_Label.Name = "protein_Label";
            protein_Label.Size = new System.Drawing.Size(77, 18);
            protein_Label.TabIndex = 12;
            protein_Label.Text = "Protein :";
            // 
            // foodLabel
            // 
            foodLabel.AutoSize = true;
            foodLabel.Location = new System.Drawing.Point(35, 33);
            foodLabel.Name = "foodLabel";
            foodLabel.Size = new System.Drawing.Size(48, 18);
            foodLabel.TabIndex = 6;
            foodLabel.Text = "Food:";
            // 
            // fatsLabel
            // 
            fatsLabel.AutoSize = true;
            fatsLabel.Location = new System.Drawing.Point(511, 105);
            fatsLabel.Name = "fatsLabel";
            fatsLabel.Size = new System.Drawing.Size(46, 18);
            fatsLabel.TabIndex = 22;
            fatsLabel.Text = "Fats:";
            // 
            // calories_Label
            // 
            calories_Label.AutoSize = true;
            calories_Label.Location = new System.Drawing.Point(264, 71);
            calories_Label.Name = "calories_Label";
            calories_Label.Size = new System.Drawing.Size(79, 18);
            calories_Label.TabIndex = 10;
            calories_Label.Text = "Calories :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 37);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(84, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(422, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(61, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 106);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // carbsTextBox
            // 
            this.carbsTextBox.Location = new System.Drawing.Point(360, 105);
            this.carbsTextBox.Name = "carbsTextBox";
            this.carbsTextBox.Size = new System.Drawing.Size(112, 28);
            this.carbsTextBox.TabIndex = 15;
            // 
            // fiberTextBox
            // 
            this.fiberTextBox.Location = new System.Drawing.Point(117, 110);
            this.fiberTextBox.Name = "fiberTextBox";
            this.fiberTextBox.Size = new System.Drawing.Size(112, 28);
            this.fiberTextBox.TabIndex = 19;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(117, 68);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(112, 28);
            this.amountTextBox.TabIndex = 9;
            // 
            // protein_TextBox
            // 
            this.protein_TextBox.Location = new System.Drawing.Point(593, 63);
            this.protein_TextBox.Name = "protein_TextBox";
            this.protein_TextBox.Size = new System.Drawing.Size(112, 28);
            this.protein_TextBox.TabIndex = 13;
            // 
            // fatsTextBox
            // 
            this.fatsTextBox.Location = new System.Drawing.Point(593, 103);
            this.fatsTextBox.Name = "fatsTextBox";
            this.fatsTextBox.Size = new System.Drawing.Size(112, 28);
            this.fatsTextBox.TabIndex = 23;
            // 
            // foodTextBox
            // 
            this.foodTextBox.Location = new System.Drawing.Point(117, 28);
            this.foodTextBox.Name = "foodTextBox";
            this.foodTextBox.Size = new System.Drawing.Size(588, 28);
            this.foodTextBox.TabIndex = 21;
            // 
            // calories_TextBox
            // 
            this.calories_TextBox.Location = new System.Drawing.Point(360, 70);
            this.calories_TextBox.Name = "calories_TextBox";
            this.calories_TextBox.Size = new System.Drawing.Size(112, 28);
            this.calories_TextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(calories_Label);
            this.groupBox2.Controls.Add(this.calories_TextBox);
            this.groupBox2.Controls.Add(this.foodTextBox);
            this.groupBox2.Controls.Add(fatsLabel);
            this.groupBox2.Controls.Add(foodLabel);
            this.groupBox2.Controls.Add(protein_Label);
            this.groupBox2.Controls.Add(this.fatsTextBox);
            this.groupBox2.Controls.Add(this.protein_TextBox);
            this.groupBox2.Controls.Add(amountLabel);
            this.groupBox2.Controls.Add(fiberLabel);
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Controls.Add(this.fiberTextBox);
            this.groupBox2.Controls.Add(this.carbsTextBox);
            this.groupBox2.Controls.Add(carbsLabel);
            this.groupBox2.Location = new System.Drawing.Point(61, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 141);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Deatils";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(752, 159);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sheet1_TableAdapter1
            // 
            this.sheet1_TableAdapter1.ClearBeforeFill = true;
            // 
            // FootTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(899, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FootTableControl";
            this.Text = "Food Controler";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox carbsTextBox;
        private System.Windows.Forms.TextBox fiberTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox protein_TextBox;
        private System.Windows.Forms.TextBox fatsTextBox;
        private System.Windows.Forms.TextBox foodTextBox;
        private System.Windows.Forms.TextBox calories_TextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private nutDataSetTableAdapters.Sheet1_TableAdapter sheet1_TableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}