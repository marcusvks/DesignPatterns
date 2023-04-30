namespace StructuralPatternsProject
{
    partial class AdapterForm
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
            this.lb_LogPadrao = new System.Windows.Forms.ListBox();
            this.lb_LogNovo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_logPadrao = new System.Windows.Forms.RadioButton();
            this.rb_logNovo = new System.Windows.Forms.RadioButton();
            this.lb_logUnico = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_LogPadrao
            // 
            this.lb_LogPadrao.FormattingEnabled = true;
            this.lb_LogPadrao.Location = new System.Drawing.Point(12, 227);
            this.lb_LogPadrao.Name = "lb_LogPadrao";
            this.lb_LogPadrao.Size = new System.Drawing.Size(536, 147);
            this.lb_LogPadrao.TabIndex = 0;
            // 
            // lb_LogNovo
            // 
            this.lb_LogNovo.FormattingEnabled = true;
            this.lb_LogNovo.Location = new System.Drawing.Point(12, 396);
            this.lb_LogNovo.Name = "lb_LogNovo";
            this.lb_LogNovo.Size = new System.Drawing.Size(536, 147);
            this.lb_LogNovo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(536, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar Logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rb_logPadrao
            // 
            this.rb_logPadrao.AutoSize = true;
            this.rb_logPadrao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_logPadrao.Location = new System.Drawing.Point(34, 549);
            this.rb_logPadrao.Name = "rb_logPadrao";
            this.rb_logPadrao.Size = new System.Drawing.Size(195, 19);
            this.rb_logPadrao.TabIndex = 3;
            this.rb_logPadrao.TabStop = true;
            this.rb_logPadrao.Text = "Usar Dependencia Log Padrao";
            this.rb_logPadrao.UseVisualStyleBackColor = true;
            // 
            // rb_logNovo
            // 
            this.rb_logNovo.AutoSize = true;
            this.rb_logNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_logNovo.Location = new System.Drawing.Point(331, 549);
            this.rb_logNovo.Name = "rb_logNovo";
            this.rb_logNovo.Size = new System.Drawing.Size(183, 19);
            this.rb_logNovo.TabIndex = 4;
            this.rb_logNovo.TabStop = true;
            this.rb_logNovo.Text = "Usar Dependencia Log Novo";
            this.rb_logNovo.UseVisualStyleBackColor = true;
            // 
            // lb_logUnico
            // 
            this.lb_logUnico.FormattingEnabled = true;
            this.lb_logUnico.Location = new System.Drawing.Point(12, 28);
            this.lb_logUnico.Name = "lb_logUnico";
            this.lb_logUnico.Size = new System.Drawing.Size(536, 147);
            this.lb_logUnico.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "LOG UNICO DA APLICAÇÃO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(170, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "LOG PADRAO DA APLICAÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(170, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOG NOVO DA APLICAÇÃO";
            // 
            // AdapterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 624);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_logUnico);
            this.Controls.Add(this.rb_logNovo);
            this.Controls.Add(this.rb_logPadrao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_LogNovo);
            this.Controls.Add(this.lb_LogPadrao);
            this.Name = "AdapterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdapterPattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_LogPadrao;
        private System.Windows.Forms.ListBox lb_LogNovo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_logPadrao;
        private System.Windows.Forms.RadioButton rb_logNovo;
        private System.Windows.Forms.ListBox lb_logUnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

