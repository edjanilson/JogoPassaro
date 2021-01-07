namespace JogoPassaro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblpontos = new System.Windows.Forms.Label();
            this.tempoJogo = new System.Windows.Forms.Timer(this.components);
            this.terra = new System.Windows.Forms.PictureBox();
            this.tubobaixo = new System.Windows.Forms.PictureBox();
            this.passaro = new System.Windows.Forms.PictureBox();
            this.tubocima = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.terra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubobaixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passaro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubocima)).BeginInit();
            this.SuspendLayout();
            // 
            // lblpontos
            // 
            this.lblpontos.AutoSize = true;
            this.lblpontos.BackColor = System.Drawing.Color.Khaki;
            this.lblpontos.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpontos.Location = new System.Drawing.Point(12, 528);
            this.lblpontos.Name = "lblpontos";
            this.lblpontos.Size = new System.Drawing.Size(238, 41);
            this.lblpontos.TabIndex = 1;
            this.lblpontos.Text = "Pontuação: 0";
            // 
            // tempoJogo
            // 
            this.tempoJogo.Enabled = true;
            this.tempoJogo.Interval = 20;
            this.tempoJogo.Tick += new System.EventHandler(this.tempoJogoEvent);
            // 
            // terra
            // 
            this.terra.Image = global::JogoPassaro.Properties.Resources.ground;
            this.terra.Location = new System.Drawing.Point(-5, 508);
            this.terra.Name = "terra";
            this.terra.Size = new System.Drawing.Size(752, 77);
            this.terra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.terra.TabIndex = 0;
            this.terra.TabStop = false;
            // 
            // tubobaixo
            // 
            this.tubobaixo.Image = global::JogoPassaro.Properties.Resources.pipe;
            this.tubobaixo.Location = new System.Drawing.Point(430, 330);
            this.tubobaixo.Name = "tubobaixo";
            this.tubobaixo.Size = new System.Drawing.Size(100, 185);
            this.tubobaixo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tubobaixo.TabIndex = 0;
            this.tubobaixo.TabStop = false;
            // 
            // passaro
            // 
            this.passaro.Image = global::JogoPassaro.Properties.Resources.iconfinder_twitter43_52987;
            this.passaro.Location = new System.Drawing.Point(51, 193);
            this.passaro.Name = "passaro";
            this.passaro.Size = new System.Drawing.Size(79, 78);
            this.passaro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passaro.TabIndex = 0;
            this.passaro.TabStop = false;
            // 
            // tubocima
            // 
            this.tubocima.Image = global::JogoPassaro.Properties.Resources.pipedown;
            this.tubocima.Location = new System.Drawing.Point(555, -5);
            this.tubocima.Name = "tubocima";
            this.tubocima.Size = new System.Drawing.Size(100, 185);
            this.tubocima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tubocima.TabIndex = 0;
            this.tubocima.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(679, 578);
            this.Controls.Add(this.lblpontos);
            this.Controls.Add(this.terra);
            this.Controls.Add(this.tubobaixo);
            this.Controls.Add(this.passaro);
            this.Controls.Add(this.tubocima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo - Pássaro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jogochavebaixo);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.jogochavecima);
            ((System.ComponentModel.ISupportInitialize)(this.terra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubobaixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passaro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tubocima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tubocima;
        private System.Windows.Forms.PictureBox passaro;
        private System.Windows.Forms.PictureBox tubobaixo;
        private System.Windows.Forms.PictureBox terra;
        private System.Windows.Forms.Label lblpontos;
        private System.Windows.Forms.Timer tempoJogo;
    }
}

