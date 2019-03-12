namespace TextEditorMemento
{
    partial class MainForm
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
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(68, 62);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtb
            // 
            this.rtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtb.Location = new System.Drawing.Point(59, 101);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(641, 307);
            this.rtb.TabIndex = 2;
            this.rtb.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUndo);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtb;
    }
}