
namespace MainProject
{
    partial class Client_Details
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label iS_MaleLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label neckLabel;
            System.Windows.Forms.Label hipLabel;
            System.Windows.Forms.Label maintain_CaloriesLabel;
            System.Windows.Forms.Label fat_PercentgeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Details));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nutDataSet1 = new MainProject.nutDataSet1();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.iS_MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.neckTextBox = new System.Windows.Forms.TextBox();
            this.hipTextBox = new System.Windows.Forms.TextBox();
            this.maintain_CaloriesTextBox = new System.Windows.Forms.TextBox();
            this.fat_PercentgeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new MainProject.nutDataSet1TableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new MainProject.nutDataSet1TableAdapters.TableAdapterManager();
            this.clientsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            iS_MaleLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            neckLabel = new System.Windows.Forms.Label();
            hipLabel = new System.Windows.Forms.Label();
            maintain_CaloriesLabel = new System.Windows.Forms.Label();
            fat_PercentgeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutDataSet1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(24, 19);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 18);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(24, 49);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 18);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(485, 21);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(41, 18);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age:";
            // 
            // iS_MaleLabel
            // 
            iS_MaleLabel.AutoSize = true;
            iS_MaleLabel.Location = new System.Drawing.Point(485, 53);
            iS_MaleLabel.Name = "iS_MaleLabel";
            iS_MaleLabel.Size = new System.Drawing.Size(72, 18);
            iS_MaleLabel.TabIndex = 6;
            iS_MaleLabel.Text = "IS Male:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(24, 78);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(66, 18);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "Weight:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(24, 107);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(63, 18);
            heightLabel.TabIndex = 10;
            heightLabel.Text = "Height:";
            // 
            // neckLabel
            // 
            neckLabel.AutoSize = true;
            neckLabel.Location = new System.Drawing.Point(485, 80);
            neckLabel.Name = "neckLabel";
            neckLabel.Size = new System.Drawing.Size(49, 18);
            neckLabel.TabIndex = 12;
            neckLabel.Text = "Neck:";
            // 
            // hipLabel
            // 
            hipLabel.AutoSize = true;
            hipLabel.Location = new System.Drawing.Point(485, 109);
            hipLabel.Name = "hipLabel";
            hipLabel.Size = new System.Drawing.Size(39, 18);
            hipLabel.TabIndex = 14;
            hipLabel.Text = "Hip:";
            // 
            // maintain_CaloriesLabel
            // 
            maintain_CaloriesLabel.AutoSize = true;
            maintain_CaloriesLabel.Location = new System.Drawing.Point(24, 143);
            maintain_CaloriesLabel.Name = "maintain_CaloriesLabel";
            maintain_CaloriesLabel.Size = new System.Drawing.Size(145, 18);
            maintain_CaloriesLabel.TabIndex = 16;
            maintain_CaloriesLabel.Text = "Maintain Calories:";
            // 
            // fat_PercentgeLabel
            // 
            fat_PercentgeLabel.AutoSize = true;
            fat_PercentgeLabel.Location = new System.Drawing.Point(485, 143);
            fat_PercentgeLabel.Name = "fat_PercentgeLabel";
            fat_PercentgeLabel.Size = new System.Drawing.Size(120, 18);
            fat_PercentgeLabel.TabIndex = 18;
            fat_PercentgeLabel.Text = "Fat Percentge:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(nameLabel);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(ageLabel);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(iS_MaleLabel);
            this.groupBox1.Controls.Add(this.iS_MaleCheckBox);
            this.groupBox1.Controls.Add(weightLabel);
            this.groupBox1.Controls.Add(this.weightTextBox);
            this.groupBox1.Controls.Add(heightLabel);
            this.groupBox1.Controls.Add(this.heightTextBox);
            this.groupBox1.Controls.Add(neckLabel);
            this.groupBox1.Controls.Add(this.neckTextBox);
            this.groupBox1.Controls.Add(hipLabel);
            this.groupBox1.Controls.Add(this.hipTextBox);
            this.groupBox1.Controls.Add(maintain_CaloriesLabel);
            this.groupBox1.Controls.Add(this.maintain_CaloriesTextBox);
            this.groupBox1.Controls.Add(fat_PercentgeLabel);
            this.groupBox1.Controls.Add(this.fat_PercentgeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(43, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Informatin";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(165, 16);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(116, 28);
            this.iDTextBox.TabIndex = 1;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.nutDataSet1;
            // 
            // nutDataSet1
            // 
            this.nutDataSet1.DataSetName = "nutDataSet1";
            this.nutDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(165, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(116, 28);
            this.nameTextBox.TabIndex = 3;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(627, 18);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(116, 28);
            this.ageTextBox.TabIndex = 5;
            // 
            // iS_MaleCheckBox
            // 
            this.iS_MaleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.clientsBindingSource, "IS Male", true));
            this.iS_MaleCheckBox.Location = new System.Drawing.Point(627, 48);
            this.iS_MaleCheckBox.Name = "iS_MaleCheckBox";
            this.iS_MaleCheckBox.Size = new System.Drawing.Size(117, 26);
            this.iS_MaleCheckBox.TabIndex = 7;
            this.iS_MaleCheckBox.Text = "True";
            this.iS_MaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(165, 74);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(116, 28);
            this.weightTextBox.TabIndex = 9;
            // 
            // heightTextBox
            // 
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Height", true));
            this.heightTextBox.Location = new System.Drawing.Point(165, 104);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(116, 28);
            this.heightTextBox.TabIndex = 11;
            // 
            // neckTextBox
            // 
            this.neckTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Neck", true));
            this.neckTextBox.Location = new System.Drawing.Point(627, 76);
            this.neckTextBox.Name = "neckTextBox";
            this.neckTextBox.Size = new System.Drawing.Size(116, 28);
            this.neckTextBox.TabIndex = 13;
            // 
            // hipTextBox
            // 
            this.hipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Hip", true));
            this.hipTextBox.Location = new System.Drawing.Point(627, 106);
            this.hipTextBox.Name = "hipTextBox";
            this.hipTextBox.Size = new System.Drawing.Size(116, 28);
            this.hipTextBox.TabIndex = 15;
            // 
            // maintain_CaloriesTextBox
            // 
            this.maintain_CaloriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Maintain Calories", true));
            this.maintain_CaloriesTextBox.Location = new System.Drawing.Point(165, 140);
            this.maintain_CaloriesTextBox.Name = "maintain_CaloriesTextBox";
            this.maintain_CaloriesTextBox.Size = new System.Drawing.Size(116, 28);
            this.maintain_CaloriesTextBox.TabIndex = 17;
            // 
            // fat_PercentgeTextBox
            // 
            this.fat_PercentgeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Fat Percentge", true));
            this.fat_PercentgeTextBox.Location = new System.Drawing.Point(627, 143);
            this.fat_PercentgeTextBox.Name = "fat_PercentgeTextBox";
            this.fat_PercentgeTextBox.Size = new System.Drawing.Size(116, 28);
            this.fat_PercentgeTextBox.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(43, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(886, 94);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MainProject.nutDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsDataGridView
            // 
            this.clientsDataGridView.AutoGenerateColumns = false;
            this.clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.clientsDataGridView.DataSource = this.clientsBindingSource;
            this.clientsDataGridView.Location = new System.Drawing.Point(43, 299);
            this.clientsDataGridView.Name = "clientsDataGridView";
            this.clientsDataGridView.RowHeadersWidth = 51;
            this.clientsDataGridView.RowTemplate.Height = 24;
            this.clientsDataGridView.Size = new System.Drawing.Size(886, 220);
            this.clientsDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "Age";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IS Male";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IS Male";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn4.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Height";
            this.dataGridViewTextBoxColumn5.HeaderText = "Height";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Neck";
            this.dataGridViewTextBoxColumn6.HeaderText = "Neck";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Hip";
            this.dataGridViewTextBoxColumn7.HeaderText = "Hip";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Maintain Calories";
            this.dataGridViewTextBoxColumn8.HeaderText = "Maintain Calories";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Fat Percentge";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fat Percentge";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "activity type";
            this.dataGridViewTextBoxColumn10.HeaderText = "activity type";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // Client_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(994, 562);
            this.Controls.Add(this.clientsDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Client_Details";
            this.Text = "Client_Details";
            this.Load += new System.EventHandler(this.Client_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutDataSet1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private nutDataSet1 nutDataSet1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private nutDataSet1TableAdapters.clientsTableAdapter clientsTableAdapter;
        private nutDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.CheckBox iS_MaleCheckBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox neckTextBox;
        private System.Windows.Forms.TextBox hipTextBox;
        private System.Windows.Forms.TextBox maintain_CaloriesTextBox;
        private System.Windows.Forms.TextBox fat_PercentgeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView clientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}