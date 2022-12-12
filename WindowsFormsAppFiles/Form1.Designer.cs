namespace WindowsFormsAppFiles
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
            this.richTextBoxSzoveg = new System.Windows.Forms.RichTextBox();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.labelNev = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // richTextBoxSzoveg
            // 
            this.richTextBoxSzoveg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxSzoveg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBoxSzoveg.Location = new System.Drawing.Point(0, 111);
            this.richTextBoxSzoveg.Name = "richTextBoxSzoveg";
            this.richTextBoxSzoveg.Size = new System.Drawing.Size(800, 339);
            this.richTextBoxSzoveg.TabIndex = 0;
            this.richTextBoxSzoveg.Text = "";
            // 
            // textBoxNev
            // 
            this.textBoxNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNev.Location = new System.Drawing.Point(150, 12);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(269, 26);
            this.textBoxNev.TabIndex = 1;
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNev.Location = new System.Drawing.Point(104, 15);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(40, 20);
            this.labelNev.TabIndex = 2;
            this.labelNev.Text = "Név:";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(425, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(73, 30);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOpen.Location = new System.Drawing.Point(530, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(81, 30);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Megyitás";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDatum.Location = new System.Drawing.Point(150, 53);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(269, 26);
            this.dateTimePickerDatum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.richTextBoxSzoveg);
            this.Name = "Form1";
            this.Text = "WindowsFormsAppFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSzoveg;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
    }
}

