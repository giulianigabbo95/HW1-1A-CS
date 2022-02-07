
namespace HW1
{
    partial class Finestra
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
            this.bottoneTesto = new System.Windows.Forms.Button();
            this.spazioTesto = new System.Windows.Forms.RichTextBox();
            this.bottonePalla = new System.Windows.Forms.Button();
            this.rettangoloPalla = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bottoneTesto
            // 
            this.bottoneTesto.Location = new System.Drawing.Point(13, 13);
            this.bottoneTesto.Name = "bottoneTesto";
            this.bottoneTesto.Size = new System.Drawing.Size(134, 23);
            this.bottoneTesto.TabIndex = 0;
            this.bottoneTesto.Text = "Stampa Testo";
            this.bottoneTesto.UseVisualStyleBackColor = true;
            this.bottoneTesto.Click += new System.EventHandler(this.bottoneTesto_Click);
            // 
            // spazioTesto
            // 
            this.spazioTesto.Location = new System.Drawing.Point(13, 43);
            this.spazioTesto.Name = "spazioTesto";
            this.spazioTesto.Size = new System.Drawing.Size(134, 54);
            this.spazioTesto.TabIndex = 1;
            this.spazioTesto.Text = "";
            // 
            // bottonePalla
            // 
            this.bottonePalla.Location = new System.Drawing.Point(12, 154);
            this.bottonePalla.Name = "bottonePalla";
            this.bottonePalla.Size = new System.Drawing.Size(134, 23);
            this.bottonePalla.TabIndex = 3;
            this.bottonePalla.Text = "Anima Palla";
            this.bottonePalla.UseVisualStyleBackColor = true;
            this.bottonePalla.Click += new System.EventHandler(this.bottonePalle_Click);
            // 
            // rettangoloPalla
            // 
            this.rettangoloPalla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rettangoloPalla.Location = new System.Drawing.Point(12, 183);
            this.rettangoloPalla.Name = "rettangoloPalla";
            this.rettangoloPalla.Size = new System.Drawing.Size(238, 255);
            this.rettangoloPalla.TabIndex = 4;
            this.rettangoloPalla.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintCircle);
            // 
            // Finestra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 450);
            this.Controls.Add(this.rettangoloPalla);
            this.Controls.Add(this.bottonePalla);
            this.Controls.Add(this.spazioTesto);
            this.Controls.Add(this.bottoneTesto);
            this.Name = "Finestra";
            this.Text = "Finestra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bottoneTesto;
        private System.Windows.Forms.RichTextBox spazioTesto;
        private System.Windows.Forms.Button bottonePalla;
        private System.Windows.Forms.Panel rettangoloPalla;
    }
}

