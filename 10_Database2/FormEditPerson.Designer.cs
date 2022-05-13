namespace _10_Database2
{
    partial class FormEditPerson
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDrivingLicense = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanelCars = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(78, 58);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(78, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // dateTimePickerDrivingLicense
            // 
            this.dateTimePickerDrivingLicense.Location = new System.Drawing.Point(78, 32);
            this.dateTimePickerDrivingLicense.Name = "dateTimePickerDrivingLicense";
            this.dateTimePickerDrivingLicense.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDrivingLicense.TabIndex = 2;
            // 
            // flowLayoutPanelCars
            // 
            this.flowLayoutPanelCars.AutoSize = true;
            this.flowLayoutPanelCars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelCars.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCars.Location = new System.Drawing.Point(284, 32);
            this.flowLayoutPanelCars.Name = "flowLayoutPanelCars";
            this.flowLayoutPanelCars.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanelCars.TabIndex = 3;
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(284, 6);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(106, 23);
            this.buttonAddCar.TabIndex = 4;
            this.buttonAddCar.Text = "Dodaj samochód";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prawo jazdy";
            // 
            // FormEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.flowLayoutPanelCars);
            this.Controls.Add(this.dateTimePickerDrivingLicense);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormEditPerson";
            this.Text = "FormEditPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDrivingLicense;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCars;
        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}