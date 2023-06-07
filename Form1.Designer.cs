namespace AppCalculateArriendo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLuz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lvalorPerson = new System.Windows.Forms.Label();
            this.lamountArriendo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLuz
            // 
            this.txtLuz.Location = new System.Drawing.Point(99, 39);
            this.txtLuz.Name = "txtLuz";
            this.txtLuz.Size = new System.Drawing.Size(100, 22);
            this.txtLuz.TabIndex = 0;
            this.txtLuz.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Luz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gas";
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(99, 91);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(100, 22);
            this.txtGas.TabIndex = 3;
            this.txtGas.Text = "0";
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(99, 140);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(100, 22);
            this.txtAgua.TabIndex = 5;
            this.txtAgua.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Agua";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 251);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lvalorPerson
            // 
            this.lvalorPerson.AutoSize = true;
            this.lvalorPerson.Location = new System.Drawing.Point(16, 335);
            this.lvalorPerson.Name = "lvalorPerson";
            this.lvalorPerson.Size = new System.Drawing.Size(44, 16);
            this.lvalorPerson.TabIndex = 7;
            this.lvalorPerson.Text = "label4";
            // 
            // lamountArriendo
            // 
            this.lamountArriendo.AutoSize = true;
            this.lamountArriendo.Location = new System.Drawing.Point(19, 190);
            this.lamountArriendo.Name = "lamountArriendo";
            this.lamountArriendo.Size = new System.Drawing.Size(0, 16);
            this.lamountArriendo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lamountArriendo);
            this.Controls.Add(this.lvalorPerson);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAgua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLuz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLuz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.TextBox txtAgua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lvalorPerson;
        private System.Windows.Forms.Label lamountArriendo;
    }
}

