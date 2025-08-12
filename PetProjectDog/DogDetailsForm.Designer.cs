namespace PetProjectDog
{
    partial class btnBack
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
            lblName = new Label();
            lblBreed = new Label();
            lblAge = new Label();
            lblWeight = new Label();
            lblColour = new Label();
            lblFriendly = new Label();
            label6 = new Label();
            lblUnique = new Label();
            lblNotes = new Label();
            lblLastVaccination = new Label();
            lblNextVaccination = new Label();
            lblOwnerName = new Label();
            lblOwnerPhone = new Label();
            lblLastWalk = new Label();
            lblNextWalk = new Label();
            btnEdit = new Button();
            cmbNotes = new ComboBox();
            lblPetName = new Label();
            lblPetUnique = new Label();
            lblPetIsVaccined = new Label();
            lblPetIsFriendly = new Label();
            lblPetColour = new Label();
            lblPetWeight = new Label();
            lblPetAge = new Label();
            lblPetBreed = new Label();
            lblPetOwnerPhone = new Label();
            lblPetNextVacation = new Label();
            lblPetLastVacation = new Label();
            lblPetOwnerName = new Label();
            lblPetLastWalk = new Label();
            lblPetNextWalk = new Label();
            lblLastUpdate = new Label();
            lblDateLastUpdate = new Label();
            pictureDog = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureDog).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblName.Location = new Point(53, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(120, 21);
            lblName.TabIndex = 0;
            lblName.Text = "Имя питомца:";
            lblName.Click += txtName_Click;
            // 
            // lblBreed
            // 
            lblBreed.AutoSize = true;
            lblBreed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblBreed.Location = new Point(53, 70);
            lblBreed.Name = "lblBreed";
            lblBreed.Size = new Size(75, 21);
            lblBreed.TabIndex = 1;
            lblBreed.Text = "Порода:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblAge.Location = new Point(53, 106);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(76, 21);
            lblAge.TabIndex = 2;
            lblAge.Text = "Возраст:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWeight.Location = new Point(53, 142);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(41, 21);
            lblWeight.TabIndex = 3;
            lblWeight.Text = "Вес:";
            // 
            // lblColour
            // 
            lblColour.AutoSize = true;
            lblColour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblColour.Location = new Point(49, 178);
            lblColour.Name = "lblColour";
            lblColour.Size = new Size(52, 21);
            lblColour.TabIndex = 4;
            lblColour.Text = "Цвет:";
            lblColour.Click += label4_Click;
            // 
            // lblFriendly
            // 
            lblFriendly.AutoSize = true;
            lblFriendly.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblFriendly.Location = new Point(49, 214);
            lblFriendly.Name = "lblFriendly";
            lblFriendly.Size = new Size(124, 21);
            lblFriendly.TabIndex = 5;
            lblFriendly.Text = "Дружелюбен?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(49, 250);
            label6.Name = "label6";
            label6.Size = new Size(133, 21);
            label6.TabIndex = 6;
            label6.Text = "Вакцинирован?";
            // 
            // lblUnique
            // 
            lblUnique.AutoSize = true;
            lblUnique.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblUnique.Location = new Point(49, 286);
            lblUnique.Name = "lblUnique";
            lblUnique.Size = new Size(151, 21);
            lblUnique.TabIndex = 7;
            lblUnique.Text = "Особые приметы:";
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNotes.Location = new Point(49, 322);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(111, 21);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "Примечания";
            // 
            // lblLastVaccination
            // 
            lblLastVaccination.AutoSize = true;
            lblLastVaccination.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblLastVaccination.Location = new Point(49, 358);
            lblLastVaccination.Name = "lblLastVaccination";
            lblLastVaccination.Size = new Size(200, 21);
            lblLastVaccination.TabIndex = 9;
            lblLastVaccination.Text = "Последняя вакцинация:";
            // 
            // lblNextVaccination
            // 
            lblNextVaccination.AutoSize = true;
            lblNextVaccination.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNextVaccination.Location = new Point(49, 394);
            lblNextVaccination.Name = "lblNextVaccination";
            lblNextVaccination.Size = new Size(207, 21);
            lblNextVaccination.TabIndex = 10;
            lblNextVaccination.Text = "Следующая вакцинация:";
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblOwnerName.Location = new Point(557, 34);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(137, 21);
            lblOwnerName.TabIndex = 11;
            lblOwnerName.Text = "Имя владельца:";
            // 
            // lblOwnerPhone
            // 
            lblOwnerPhone.AutoSize = true;
            lblOwnerPhone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblOwnerPhone.Location = new Point(557, 106);
            lblOwnerPhone.Name = "lblOwnerPhone";
            lblOwnerPhone.Size = new Size(156, 21);
            lblOwnerPhone.TabIndex = 12;
            lblOwnerPhone.Text = "Номер владельца:";
            // 
            // lblLastWalk
            // 
            lblLastWalk.AutoSize = true;
            lblLastWalk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblLastWalk.Location = new Point(557, 178);
            lblLastWalk.Name = "lblLastWalk";
            lblLastWalk.Size = new Size(178, 21);
            lblLastWalk.TabIndex = 13;
            lblLastWalk.Text = "Последняя прогулка:";
            // 
            // lblNextWalk
            // 
            lblNextWalk.AutoSize = true;
            lblNextWalk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNextWalk.Location = new Point(557, 214);
            lblNextWalk.Name = "lblNextWalk";
            lblNextWalk.Size = new Size(185, 21);
            lblNextWalk.TabIndex = 14;
            lblNextWalk.Text = "Следующая прогулка:";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnEdit.Location = new Point(760, 381);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 62);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Редактировать данные";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cmbNotes
            // 
            cmbNotes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbNotes.FormattingEnabled = true;
            cmbNotes.Location = new Point(198, 314);
            cmbNotes.Name = "cmbNotes";
            cmbNotes.Size = new Size(121, 29);
            cmbNotes.TabIndex = 32;
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetName.Location = new Point(197, 34);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(41, 21);
            lblPetName.TabIndex = 34;
            lblPetName.Text = "Имя";
            // 
            // lblPetUnique
            // 
            lblPetUnique.AutoSize = true;
            lblPetUnique.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetUnique.Location = new Point(197, 286);
            lblPetUnique.Name = "lblPetUnique";
            lblPetUnique.Size = new Size(134, 21);
            lblPetUnique.TabIndex = 35;
            lblPetUnique.Text = "Особые приметы";
            // 
            // lblPetIsVaccined
            // 
            lblPetIsVaccined.AutoSize = true;
            lblPetIsVaccined.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetIsVaccined.Location = new Point(197, 250);
            lblPetIsVaccined.Name = "lblPetIsVaccined";
            lblPetIsVaccined.Size = new Size(115, 21);
            lblPetIsVaccined.TabIndex = 36;
            lblPetIsVaccined.Text = "Вакцинирован";
            // 
            // lblPetIsFriendly
            // 
            lblPetIsFriendly.AutoSize = true;
            lblPetIsFriendly.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetIsFriendly.Location = new Point(197, 209);
            lblPetIsFriendly.Name = "lblPetIsFriendly";
            lblPetIsFriendly.Size = new Size(105, 21);
            lblPetIsFriendly.TabIndex = 37;
            lblPetIsFriendly.Text = "Дружелюбен";
            // 
            // lblPetColour
            // 
            lblPetColour.AutoSize = true;
            lblPetColour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetColour.Location = new Point(197, 174);
            lblPetColour.Name = "lblPetColour";
            lblPetColour.Size = new Size(45, 21);
            lblPetColour.TabIndex = 38;
            lblPetColour.Text = "Цвет";
            // 
            // lblPetWeight
            // 
            lblPetWeight.AutoSize = true;
            lblPetWeight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetWeight.Location = new Point(197, 139);
            lblPetWeight.Name = "lblPetWeight";
            lblPetWeight.Size = new Size(34, 21);
            lblPetWeight.TabIndex = 39;
            lblPetWeight.Text = "Вес";
            // 
            // lblPetAge
            // 
            lblPetAge.AutoSize = true;
            lblPetAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetAge.Location = new Point(197, 104);
            lblPetAge.Name = "lblPetAge";
            lblPetAge.Size = new Size(66, 21);
            lblPetAge.TabIndex = 40;
            lblPetAge.Text = "Возраст";
            // 
            // lblPetBreed
            // 
            lblPetBreed.AutoSize = true;
            lblPetBreed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetBreed.Location = new Point(197, 69);
            lblPetBreed.Name = "lblPetBreed";
            lblPetBreed.Size = new Size(65, 21);
            lblPetBreed.TabIndex = 41;
            lblPetBreed.Text = "Порода";
            // 
            // lblPetOwnerPhone
            // 
            lblPetOwnerPhone.AutoSize = true;
            lblPetOwnerPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetOwnerPhone.Location = new Point(744, 106);
            lblPetOwnerPhone.Name = "lblPetOwnerPhone";
            lblPetOwnerPhone.Size = new Size(58, 21);
            lblPetOwnerPhone.TabIndex = 42;
            lblPetOwnerPhone.Text = "Номер";
            // 
            // lblPetNextVacation
            // 
            lblPetNextVacation.AutoSize = true;
            lblPetNextVacation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetNextVacation.Location = new Point(260, 392);
            lblPetNextVacation.Name = "lblPetNextVacation";
            lblPetNextVacation.Size = new Size(136, 21);
            lblPetNextVacation.TabIndex = 43;
            lblPetNextVacation.Text = "След.Вакцинация";
            // 
            // lblPetLastVacation
            // 
            lblPetLastVacation.AutoSize = true;
            lblPetLastVacation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetLastVacation.Location = new Point(260, 357);
            lblPetLastVacation.Name = "lblPetLastVacation";
            lblPetLastVacation.Size = new Size(178, 21);
            lblPetLastVacation.TabIndex = 44;
            lblPetLastVacation.Text = "Последняя вакцинация";
            // 
            // lblPetOwnerName
            // 
            lblPetOwnerName.AutoSize = true;
            lblPetOwnerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetOwnerName.Location = new Point(744, 34);
            lblPetOwnerName.Name = "lblPetOwnerName";
            lblPetOwnerName.Size = new Size(45, 21);
            lblPetOwnerName.TabIndex = 45;
            lblPetOwnerName.Text = "Имя ";
            // 
            // lblPetLastWalk
            // 
            lblPetLastWalk.AutoSize = true;
            lblPetLastWalk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetLastWalk.Location = new Point(744, 178);
            lblPetLastWalk.Name = "lblPetLastWalk";
            lblPetLastWalk.Size = new Size(156, 21);
            lblPetLastWalk.TabIndex = 46;
            lblPetLastWalk.Text = "Последняя прогулка";
            // 
            // lblPetNextWalk
            // 
            lblPetNextWalk.AutoSize = true;
            lblPetNextWalk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPetNextWalk.Location = new Point(744, 214);
            lblPetNextWalk.Name = "lblPetNextWalk";
            lblPetNextWalk.Size = new Size(164, 21);
            lblPetNextWalk.TabIndex = 47;
            lblPetNextWalk.Text = "Следующая прогулка";
            // 
            // lblLastUpdate
            // 
            lblLastUpdate.AutoSize = true;
            lblLastUpdate.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblLastUpdate.Location = new Point(49, 440);
            lblLastUpdate.Name = "lblLastUpdate";
            lblLastUpdate.Size = new Size(162, 13);
            lblLastUpdate.TabIndex = 48;
            lblLastUpdate.Text = "Дата последнего изменения:";
            // 
            // lblDateLastUpdate
            // 
            lblDateLastUpdate.AutoSize = true;
            lblDateLastUpdate.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblDateLastUpdate.Location = new Point(217, 440);
            lblDateLastUpdate.Name = "lblDateLastUpdate";
            lblDateLastUpdate.Size = new Size(162, 13);
            lblDateLastUpdate.TabIndex = 49;
            lblDateLastUpdate.Text = "Дата последнего изменения:";
            // 
            // pictureDog
            // 
            pictureDog.Location = new Point(557, 238);
            pictureDog.Name = "pictureDog";
            pictureDog.Size = new Size(156, 157);
            pictureDog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureDog.TabIndex = 50;
            pictureDog.TabStop = false;
            pictureDog.Click += pictureDog_Click;
            // 
            // button1
            // 
            button1.Location = new Point(689, 420);
            button1.Name = "button1";
            button1.Size = new Size(65, 23);
            button1.TabIndex = 51;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnBack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 461);
            Controls.Add(button1);
            Controls.Add(pictureDog);
            Controls.Add(lblDateLastUpdate);
            Controls.Add(lblLastUpdate);
            Controls.Add(lblPetNextWalk);
            Controls.Add(lblPetLastWalk);
            Controls.Add(lblPetOwnerName);
            Controls.Add(lblPetLastVacation);
            Controls.Add(lblPetNextVacation);
            Controls.Add(lblPetOwnerPhone);
            Controls.Add(lblPetBreed);
            Controls.Add(lblPetAge);
            Controls.Add(lblPetWeight);
            Controls.Add(lblPetColour);
            Controls.Add(lblPetIsFriendly);
            Controls.Add(lblPetIsVaccined);
            Controls.Add(lblPetUnique);
            Controls.Add(lblPetName);
            Controls.Add(cmbNotes);
            Controls.Add(btnEdit);
            Controls.Add(lblNextWalk);
            Controls.Add(lblLastWalk);
            Controls.Add(lblOwnerPhone);
            Controls.Add(lblOwnerName);
            Controls.Add(lblNextVaccination);
            Controls.Add(lblLastVaccination);
            Controls.Add(lblNotes);
            Controls.Add(lblUnique);
            Controls.Add(label6);
            Controls.Add(lblFriendly);
            Controls.Add(lblColour);
            Controls.Add(lblWeight);
            Controls.Add(lblAge);
            Controls.Add(lblBreed);
            Controls.Add(lblName);
            Name = "btnBack";
            Text = "Карточка питомца";
            Load += DogDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureDog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblBreed;
        private Label lblAge;
        private Label lblWeight;
        private Label lblColour;
        private Label lblFriendly;
        private Label label6;
        private Label lblUnique;
        private Label lblNotes;
        private Label lblLastVaccination;
        private Label lblNextVaccination;
        private Label lblOwnerName;
        private Label lblOwnerPhone;
        private Label lblLastWalk;
        private Label lblNextWalk;
        private Button btnEdit;
        private ComboBox cmbNotes;
        private Label lblPetName;
        private Label lblPetUnique;
        private Label lblPetIsVaccined;
        private Label lblPetIsFriendly;
        private Label lblPetColour;
        private Label lblPetWeight;
        private Label lblPetAge;
        private Label lblPetBreed;
        private Label lblPetOwnerPhone;
        private Label lblPetNextVacation;
        private Label lblPetLastVacation;
        private Label lblPetOwnerName;
        private Label lblPetLastWalk;
        private Label lblPetNextWalk;
        private Label lblLastUpdate;
        private Label lblDateLastUpdate;
        private PictureBox pictureDog;
        private Button button1;
    }
}