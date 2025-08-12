namespace PetProjectDog
{
    partial class AddNoteForm
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
            txtNote = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtNote
            // 
            txtNote.Location = new Point(12, 21);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(404, 23);
            txtNote.TabIndex = 0;
            txtNote.TextChanged += textBox1_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(279, 129);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 91);
            btnSave.TabIndex = 1;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 254);
            Controls.Add(btnSave);
            Controls.Add(txtNote);
            Name = "AddNoteForm";
            Text = "Добавление заметки";
            Load += AddNoteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNote;
        private Button btnSave;
    }
}