namespace Salt_Lake_Infinity
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jogarBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.tokoBtn = new System.Windows.Forms.Button();
            this.discordBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jogarBtn
            // 
            this.jogarBtn.BackColor = System.Drawing.Color.Transparent;
            this.jogarBtn.BackgroundImage = global::Salt_Lake_Infinity.Properties.Resources.jogar_button;
            resources.ApplyResources(this.jogarBtn, "jogarBtn");
            this.jogarBtn.CausesValidation = false;
            this.jogarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jogarBtn.FlatAppearance.BorderSize = 0;
            this.jogarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.jogarBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.jogarBtn.Name = "jogarBtn";
            this.jogarBtn.Tag = "jogarBtn";
            this.jogarBtn.UseVisualStyleBackColor = false;
            this.jogarBtn.Click += new System.EventHandler(this.jogar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Salt_Lake_Infinity.Properties.Resources.close_button;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.tokoBtn);
            this.panel1.Controls.Add(this.discordBtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.jogarBtn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::Salt_Lake_Infinity.Properties.Resources.leia_meu_pinto;
            resources.ApplyResources(this.button3, "button3");
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tokoBtn
            // 
            this.tokoBtn.BackColor = System.Drawing.Color.Transparent;
            this.tokoBtn.BackgroundImage = global::Salt_Lake_Infinity.Properties.Resources.toko_logo;
            resources.ApplyResources(this.tokoBtn, "tokoBtn");
            this.tokoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tokoBtn.FlatAppearance.BorderSize = 0;
            this.tokoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tokoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tokoBtn.Name = "tokoBtn";
            this.tokoBtn.UseVisualStyleBackColor = false;
            this.tokoBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // discordBtn
            // 
            this.discordBtn.BackColor = System.Drawing.Color.Transparent;
            this.discordBtn.BackgroundImage = global::Salt_Lake_Infinity.Properties.Resources.discord_logoo1;
            resources.ApplyResources(this.discordBtn, "discordBtn");
            this.discordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.discordBtn.FlatAppearance.BorderSize = 0;
            this.discordBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.discordBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.discordBtn.Name = "discordBtn";
            this.discordBtn.UseVisualStyleBackColor = false;
            this.discordBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Salt_Lake_Infinity.Properties.Resources.asda;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Salt_Lake_Infinity.Properties.Resources.fundo_launcher;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jogarBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button discordBtn;
        private System.Windows.Forms.Button tokoBtn;
        private System.Windows.Forms.Button button3;
    }
}

