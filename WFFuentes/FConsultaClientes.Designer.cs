﻿namespace WFFuentes
{
    partial class FConsultaClientes
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
            this.bActualizar = new System.Windows.Forms.Button();
            this.bBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bRegresar = new System.Windows.Forms.Button();
            this.dGClientes = new System.Windows.Forms.DataGridView();
            this.bImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // bActualizar
            // 
            this.bActualizar.BackColor = System.Drawing.Color.Teal;
            this.bActualizar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bActualizar.Location = new System.Drawing.Point(802, 425);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(96, 30);
            this.bActualizar.TabIndex = 48;
            this.bActualizar.Text = "Mostrar";
            this.bActualizar.UseVisualStyleBackColor = false;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // bBusqueda
            // 
            this.bBusqueda.BackColor = System.Drawing.Color.Teal;
            this.bBusqueda.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBusqueda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bBusqueda.Location = new System.Drawing.Point(718, 102);
            this.bBusqueda.Name = "bBusqueda";
            this.bBusqueda.Size = new System.Drawing.Size(119, 30);
            this.bBusqueda.TabIndex = 46;
            this.bBusqueda.Text = "Buscar";
            this.bBusqueda.UseVisualStyleBackColor = false;
            this.bBusqueda.Click += new System.EventHandler(this.bBusqueda_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(281, 106);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(407, 20);
            this.txtBusqueda.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 26);
            this.label8.TabIndex = 44;
            this.label8.Text = "Búsqueda por Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(338, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 49;
            this.label1.Text = "Cartera de clientes ";
            // 
            // bRegresar
            // 
            this.bRegresar.BackColor = System.Drawing.Color.Teal;
            this.bRegresar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegresar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bRegresar.Location = new System.Drawing.Point(694, 425);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(102, 30);
            this.bRegresar.TabIndex = 50;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = false;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // dGClientes
            // 
            this.dGClientes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGClientes.Location = new System.Drawing.Point(41, 151);
            this.dGClientes.Name = "dGClientes";
            this.dGClientes.Size = new System.Drawing.Size(857, 255);
            this.dGClientes.TabIndex = 51;
            // 
            // bImprimir
            // 
            this.bImprimir.BackColor = System.Drawing.Color.Teal;
            this.bImprimir.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bImprimir.Location = new System.Drawing.Point(577, 425);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(102, 30);
            this.bImprimir.TabIndex = 52;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = false;
            // 
            // FConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(952, 490);
            this.Controls.Add(this.bImprimir);
            this.Controls.Add(this.dGClientes);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bActualizar);
            this.Controls.Add(this.bBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FConsultaClientes";
            this.Text = "FConsultaClientes";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FConsultaClientes_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bActualizar;
        private System.Windows.Forms.Button bBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRegresar;
        private System.Windows.Forms.DataGridView dGClientes;
        private System.Windows.Forms.Button bImprimir;
    }
}