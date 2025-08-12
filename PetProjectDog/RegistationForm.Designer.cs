namespace PetProjectDog
{
    partial class RegistationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistationForm));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label8 = new Label();
            txtPetName = new TextBox();
            txtBreed = new TextBox();
            txtColor = new TextBox();
            txtWeight = new TextBox();
            txtAge = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtOwnerName = new TextBox();
            txtOwnerPhone = new TextBox();
            btnRegister = new Button();
            label6 = new Label();
            label7 = new Label();
            cmbFriendly = new ComboBox();
            cmbVaccinated = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 90);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Имя питомца";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 177);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 2;
            label3.Text = "Вес";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 218);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 3;
            label4.Text = "Цвет";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 263);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 4;
            label5.Text = "Порода";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 136);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 5;
            label2.Text = "Возраст";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.HotTrack;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(109, 21);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 8;
            label8.Text = "ПОЛЕ: ПИТОМЕЦ";
            label8.Click += label8_Click;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(188, 87);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(153, 33);
            txtPetName.TabIndex = 9;
            txtPetName.TextChanged += txtPetName_TextChanged;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(188, 260);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(153, 33);
            txtBreed.TabIndex = 11;
            txtBreed.TextChanged += txtBreed_TextChanged;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(188, 215);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(153, 33);
            txtColor.TabIndex = 12;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(188, 174);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(153, 33);
            txtWeight.TabIndex = 13;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(188, 133);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(153, 33);
            txtAge.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.HotTrack;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(497, 21);
            label9.Name = "label9";
            label9.Size = new Size(168, 25);
            label9.TabIndex = 16;
            label9.Text = "ПОЛЕ: ВЛАДЕЛЕЦ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(433, 87);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(145, 25);
            label10.TabIndex = 17;
            label10.Text = "Имя владельца";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(433, 133);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 25);
            label11.TabIndex = 18;
            label11.Text = "Телефон";
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(586, 84);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(153, 33);
            txtOwnerName.TabIndex = 19;
            // 
            // txtOwnerPhone
            // 
            txtOwnerPhone.Location = new Point(586, 130);
            txtOwnerPhone.Name = "txtOwnerPhone";
            txtOwnerPhone.Size = new Size(153, 33);
            txtOwnerPhone.TabIndex = 20;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(564, 324);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(159, 98);
            btnRegister.TabIndex = 21;
            btnRegister.Text = "РЕГИСТРАЦИЯ";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 305);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 22;
            label6.Text = "Дружелюбен?";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 349);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 23;
            label7.Text = "Привит?";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbFriendly
            // 
            cmbFriendly.FormattingEnabled = true;
            cmbFriendly.Items.AddRange(new object[] { "Да", "Нет" });
            cmbFriendly.Location = new Point(188, 299);
            cmbFriendly.Name = "cmbFriendly";
            cmbFriendly.Size = new Size(121, 33);
            cmbFriendly.TabIndex = 24;
            // 
            // cmbVaccinated
            // 
            cmbVaccinated.FormattingEnabled = true;
            cmbVaccinated.Items.AddRange(new object[] { "Да", "Нет" });
            cmbVaccinated.Location = new Point(188, 341);
            cmbVaccinated.Name = "cmbVaccinated";
            cmbVaccinated.Size = new Size(121, 33);
            cmbVaccinated.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(40, 390);
            button1.Name = "button1";
            button1.Size = new Size(195, 32);
            button1.TabIndex = 26;
            button1.Text = "Очистить все поля";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistationForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1257, 750);
            Controls.Add(button1);
            Controls.Add(cmbVaccinated);
            Controls.Add(cmbFriendly);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(txtOwnerPhone);
            Controls.Add(txtOwnerName);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtAge);
            Controls.Add(txtWeight);
            Controls.Add(txtColor);
            Controls.Add(txtBreed);
            Controls.Add(txtPetName);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "RegistationForm";
            Text = "Регистрация питомца";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label8;
        private TextBox txtPetName;
        private TextBox txtBreed;
        private TextBox txtColor;
        private TextBox txtWeight;
        private TextBox txtAge;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtOwnerName;
        private TextBox txtOwnerPhone;
        private Button btnRegister;
        private Label label6;
        private Label label7;
        private ComboBox cmbFriendly;
        private ComboBox cmbVaccinated;
        private Button button1;
    }
}