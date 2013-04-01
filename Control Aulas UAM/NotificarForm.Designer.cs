namespace Control_Aulas_UAM
{
    partial class NotificarForm
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
            this.controlNotificar1 = new Control_Aulas_UAM.ControlNotificar();
            this.SuspendLayout();
            // 
            // controlNotificar1
            // 
            this.controlNotificar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.controlNotificar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.controlNotificar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlNotificar1.Location = new System.Drawing.Point(0, 0);
            this.controlNotificar1.Name = "controlNotificar1";
            this.controlNotificar1.Size = new System.Drawing.Size(245, 479);
            this.controlNotificar1.TabIndex = 0;
            this.controlNotificar1.Usuario = null;
            this.controlNotificar1.Load += new System.EventHandler(this.controlNotificar1_Load);
            // 
            // NotificarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 479);
            this.Controls.Add(this.controlNotificar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificarForm";
            this.Text = "NotificarForm";
            this.ResumeLayout(false);

        }

        #endregion

        public ControlNotificar controlNotificar1;



    }
}