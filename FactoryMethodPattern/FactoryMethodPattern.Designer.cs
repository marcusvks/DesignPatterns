namespace FactoryMethodPattern
{
    partial class FactoryMethodPattern
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
            this.tbStringConexao = new System.Windows.Forms.TextBox();
            this.cbSqlServer = new System.Windows.Forms.CheckBox();
            this.cbOracle = new System.Windows.Forms.CheckBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMySql = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStringConexao
            // 
            this.tbStringConexao.Location = new System.Drawing.Point(12, 137);
            this.tbStringConexao.Name = "tbStringConexao";
            this.tbStringConexao.Size = new System.Drawing.Size(390, 20);
            this.tbStringConexao.TabIndex = 0;
            // 
            // cbSqlServer
            // 
            this.cbSqlServer.AutoSize = true;
            this.cbSqlServer.Location = new System.Drawing.Point(15, 72);
            this.cbSqlServer.Name = "cbSqlServer";
            this.cbSqlServer.Size = new System.Drawing.Size(81, 17);
            this.cbSqlServer.TabIndex = 1;
            this.cbSqlServer.Text = "SQL Server";
            this.cbSqlServer.UseVisualStyleBackColor = true;
            this.cbSqlServer.CheckedChanged += new System.EventHandler(this.cbSqlServer_CheckedChanged);
            // 
            // cbOracle
            // 
            this.cbOracle.AutoSize = true;
            this.cbOracle.Location = new System.Drawing.Point(102, 72);
            this.cbOracle.Name = "cbOracle";
            this.cbOracle.Size = new System.Drawing.Size(57, 17);
            this.cbOracle.TabIndex = 2;
            this.cbOracle.Text = "Oracle";
            this.cbOracle.UseVisualStyleBackColor = true;
            this.cbOracle.CheckedChanged += new System.EventHandler(this.cbOracle_CheckedChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(84, 175);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(229, 39);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha o Banco de Dados Para se Conectar";
            // 
            // cbMySql
            // 
            this.cbMySql.AutoSize = true;
            this.cbMySql.Location = new System.Drawing.Point(165, 72);
            this.cbMySql.Name = "cbMySql";
            this.cbMySql.Size = new System.Drawing.Size(55, 17);
            this.cbMySql.TabIndex = 5;
            this.cbMySql.Text = "MySql";
            this.cbMySql.UseVisualStyleBackColor = true;
            this.cbMySql.CheckedChanged += new System.EventHandler(this.cbMySql_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite a Connection String Completa";
            // 
            // FactoryMethodPattern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMySql);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.cbOracle);
            this.Controls.Add(this.cbSqlServer);
            this.Controls.Add(this.tbStringConexao);
            this.Name = "FactoryMethodPattern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FactoryMethodPattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStringConexao;
        private System.Windows.Forms.CheckBox cbSqlServer;
        private System.Windows.Forms.CheckBox cbOracle;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMySql;
        private System.Windows.Forms.Label label2;
    }
}

