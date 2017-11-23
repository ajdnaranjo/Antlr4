namespace Hormiguero.Test
{
    partial class App
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
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.trView = new System.Windows.Forms.TreeView();
            this.btnCarga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.FileName = "ofdSelectFile";
            this.ofdSelectFile.Filter = "(*.cs)|";
            // 
            // trView
            // 
            this.trView.Location = new System.Drawing.Point(29, 67);
            this.trView.Name = "trView";
            this.trView.Size = new System.Drawing.Size(722, 283);
            this.trView.TabIndex = 2;
            // 
            // btnCarga
            // 
            this.btnCarga.Location = new System.Drawing.Point(29, 28);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(75, 23);
            this.btnCarga.TabIndex = 3;
            this.btnCarga.Text = "Cargar archivo";
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 375);
            this.Controls.Add(this.btnCarga);
            this.Controls.Add(this.trView);
            this.Name = "App";
            this.Text = "Hormiguero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.TreeView trView;
        private System.Windows.Forms.Button btnCarga;
    }
}

