namespace PetProjectDog
{
    partial class DogListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DogListForm));
            listBoxDogs = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxDogs
            // 
            listBoxDogs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBoxDogs.FormattingEnabled = true;
            listBoxDogs.ItemHeight = 21;
            listBoxDogs.Location = new Point(12, 42);
            listBoxDogs.Name = "listBoxDogs";
            listBoxDogs.Size = new Size(776, 361);
            listBoxDogs.TabIndex = 0;
            listBoxDogs.SelectedIndexChanged += listBoxDogs_SelectedIndexChanged;
            listBoxDogs.DoubleClick += listBoxDogs_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 1;
            label1.Text = "Наши питомцы:";
            // 
            // DogListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBoxDogs);
            Name = "DogListForm";
            Text = "OurDogs";
            Load += DogListForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private ListBox listBoxDogs;
        private Label label1;
    }
}