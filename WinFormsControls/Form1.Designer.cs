
namespace WinFormsControls
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
            this.lstAllPeople = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LstAllCountries = new System.Windows.Forms.ListBox();
            this.lstDemo = new System.Windows.Forms.ListBox();
            this.btnFilterByAge = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilterByCountry = new System.Windows.Forms.Button();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindPerson = new System.Windows.Forms.Button();
            this.AddNewRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllPeople
            // 
            this.lstAllPeople.FormattingEnabled = true;
            this.lstAllPeople.Location = new System.Drawing.Point(38, 152);
            this.lstAllPeople.Name = "lstAllPeople";
            this.lstAllPeople.Size = new System.Drawing.Size(632, 108);
            this.lstAllPeople.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "All People";
            // 
            // LstAllCountries
            // 
            this.LstAllCountries.FormattingEnabled = true;
            this.LstAllCountries.Location = new System.Drawing.Point(38, 361);
            this.LstAllCountries.Name = "LstAllCountries";
            this.LstAllCountries.Size = new System.Drawing.Size(632, 69);
            this.LstAllCountries.TabIndex = 2;
            // 
            // lstDemo
            // 
            this.lstDemo.FormattingEnabled = true;
            this.lstDemo.Location = new System.Drawing.Point(38, 465);
            this.lstDemo.Name = "lstDemo";
            this.lstDemo.Size = new System.Drawing.Size(632, 108);
            this.lstDemo.TabIndex = 3;
            // 
            // btnFilterByAge
            // 
            this.btnFilterByAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByAge.Location = new System.Drawing.Point(38, 622);
            this.btnFilterByAge.Name = "btnFilterByAge";
            this.btnFilterByAge.Size = new System.Drawing.Size(126, 23);
            this.btnFilterByAge.TabIndex = 4;
            this.btnFilterByAge.Text = "Filter By Age";
            this.btnFilterByAge.UseVisualStyleBackColor = true;
            this.btnFilterByAge.Click += new System.EventHandler(this.btnFilterByAge_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(38, 75);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(632, 20);
            this.txtFilter.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Filter criteria";
            // 
            // btnFilterByCountry
            // 
            this.btnFilterByCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByCountry.Location = new System.Drawing.Point(248, 622);
            this.btnFilterByCountry.Name = "btnFilterByCountry";
            this.btnFilterByCountry.Size = new System.Drawing.Size(123, 23);
            this.btnFilterByCountry.TabIndex = 7;
            this.btnFilterByCountry.Text = "Filter By Country";
            this.btnFilterByCountry.UseVisualStyleBackColor = true;
            this.btnFilterByCountry.Click += new System.EventHandler(this.btnFilterByCountry_Click);
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(38, 322);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbCountry.TabIndex = 8;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Country";
            // 
            // btnFindPerson
            // 
            this.btnFindPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindPerson.Location = new System.Drawing.Point(450, 621);
            this.btnFindPerson.Name = "btnFindPerson";
            this.btnFindPerson.Size = new System.Drawing.Size(115, 23);
            this.btnFindPerson.TabIndex = 10;
            this.btnFindPerson.Text = "Find Person";
            this.btnFindPerson.UseVisualStyleBackColor = true;
            this.btnFindPerson.Click += new System.EventHandler(this.btnFindPerson_Click);
            // 
            // AddNewRecord
            // 
            this.AddNewRecord.Location = new System.Drawing.Point(619, 621);
            this.AddNewRecord.Name = "AddNewRecord";
            this.AddNewRecord.Size = new System.Drawing.Size(75, 23);
            this.AddNewRecord.TabIndex = 11;
            this.AddNewRecord.Text = "Add New Record";
            this.AddNewRecord.UseVisualStyleBackColor = true;
            this.AddNewRecord.Click += new System.EventHandler(this.AddNewRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 679);
            this.Controls.Add(this.AddNewRecord);
            this.Controls.Add(this.btnFindPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.btnFilterByCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFilterByAge);
            this.Controls.Add(this.lstDemo);
            this.Controls.Add(this.LstAllCountries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAllPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAllPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstAllCountries;
        private System.Windows.Forms.ListBox lstDemo;
        private System.Windows.Forms.Button btnFilterByAge;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilterByCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFindPerson;
        private System.Windows.Forms.Button AddNewRecord;
    }
}

