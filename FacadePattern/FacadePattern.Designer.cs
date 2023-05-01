namespace FacadePattern
{
    partial class FacadePattern
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.list_lanches = new System.Windows.Forms.TreeView();
            this.list_bebidas = new System.Windows.Forms.TreeView();
            this.btn_verCardapio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESTAURANTE LAGEANO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CARDAPIO DE LANCHES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CARDAPIO DE BEBIDAS";
            // 
            // list_lanches
            // 
            this.list_lanches.Location = new System.Drawing.Point(16, 165);
            this.list_lanches.Name = "list_lanches";
            this.list_lanches.Size = new System.Drawing.Size(196, 223);
            this.list_lanches.TabIndex = 3;
            // 
            // list_bebidas
            // 
            this.list_bebidas.Location = new System.Drawing.Point(268, 165);
            this.list_bebidas.Name = "list_bebidas";
            this.list_bebidas.Size = new System.Drawing.Size(196, 223);
            this.list_bebidas.TabIndex = 4;
            // 
            // btn_verCardapio
            // 
            this.btn_verCardapio.Location = new System.Drawing.Point(89, 419);
            this.btn_verCardapio.Name = "btn_verCardapio";
            this.btn_verCardapio.Size = new System.Drawing.Size(307, 37);
            this.btn_verCardapio.TabIndex = 5;
            this.btn_verCardapio.Text = "VER O CARDAPIO";
            this.btn_verCardapio.UseVisualStyleBackColor = true;
            this.btn_verCardapio.Click += new System.EventHandler(this.btn_verCardapio_Click);
            // 
            // FacadePattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 468);
            this.Controls.Add(this.btn_verCardapio);
            this.Controls.Add(this.list_bebidas);
            this.Controls.Add(this.list_lanches);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FacadePattern";
            this.Text = "FacadePattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView list_lanches;
        private System.Windows.Forms.TreeView list_bebidas;
        private System.Windows.Forms.Button btn_verCardapio;
    }
}

