namespace AbstractFactoryPatternRealLife
{
    partial class AbstractFactoryPattern
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
            this.tb_data = new System.Windows.Forms.TextBox();
            this.btn_data = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dataFactory = new System.Windows.Forms.TextBox();
            this.btn_dataFactory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dataBastractFactory = new System.Windows.Forms.TextBox();
            this.btn_dataAbstractFactory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_data
            // 
            this.tb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_data.Location = new System.Drawing.Point(12, 26);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(269, 38);
            this.tb_data.TabIndex = 0;
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(12, 132);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(269, 42);
            this.btn_data.TabIndex = 1;
            this.btn_data.Text = "ATUALIZAR DATA HORA - DI Padrao";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Metodo: DI Injetada Padrao";
            // 
            // tb_dataFactory
            // 
            this.tb_dataFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataFactory.Location = new System.Drawing.Point(336, 26);
            this.tb_dataFactory.Name = "tb_dataFactory";
            this.tb_dataFactory.Size = new System.Drawing.Size(269, 38);
            this.tb_dataFactory.TabIndex = 4;
            // 
            // btn_dataFactory
            // 
            this.btn_dataFactory.Location = new System.Drawing.Point(336, 132);
            this.btn_dataFactory.Name = "btn_dataFactory";
            this.btn_dataFactory.Size = new System.Drawing.Size(269, 42);
            this.btn_dataFactory.TabIndex = 5;
            this.btn_dataFactory.Text = "ATUALIZAR DATA HORA - Factory";
            this.btn_dataFactory.UseVisualStyleBackColor = true;
            this.btn_dataFactory.Click += new System.EventHandler(this.btn_dataFactory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pattern: FACTORY";
            // 
            // tb_dataBastractFactory
            // 
            this.tb_dataBastractFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dataBastractFactory.Location = new System.Drawing.Point(667, 26);
            this.tb_dataBastractFactory.Name = "tb_dataBastractFactory";
            this.tb_dataBastractFactory.Size = new System.Drawing.Size(269, 38);
            this.tb_dataBastractFactory.TabIndex = 8;
            // 
            // btn_dataAbstractFactory
            // 
            this.btn_dataAbstractFactory.Location = new System.Drawing.Point(667, 132);
            this.btn_dataAbstractFactory.Name = "btn_dataAbstractFactory";
            this.btn_dataAbstractFactory.Size = new System.Drawing.Size(269, 42);
            this.btn_dataAbstractFactory.TabIndex = 9;
            this.btn_dataAbstractFactory.Text = "ATUALIZAR DATA HORA - Abstract Factory";
            this.btn_dataAbstractFactory.UseVisualStyleBackColor = true;
            this.btn_dataAbstractFactory.Click += new System.EventHandler(this.btn_dataAbstractFactory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(714, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pattern: ABASTRACTY FACTORY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "NÃO FUNCIONA A ATUALIZAÇÃO DA DATA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(349, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "AGORA FUNCIONA A ATUALIZAÇÃO DA DATA!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(672, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "CONTINUA FUNCIONANDO DE FORMA ELEGANTE";
            // 
            // AbstractFactoryPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 186);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_dataAbstractFactory);
            this.Controls.Add(this.tb_dataBastractFactory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_dataFactory);
            this.Controls.Add(this.tb_dataFactory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.tb_data);
            this.Name = "AbstractFactoryPattern";
            this.Text = "AbstractFactoryPattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Button btn_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_dataFactory;
        private System.Windows.Forms.Button btn_dataFactory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dataBastractFactory;
        private System.Windows.Forms.Button btn_dataAbstractFactory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}

