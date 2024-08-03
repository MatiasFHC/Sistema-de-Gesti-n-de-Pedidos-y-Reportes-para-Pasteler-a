namespace Presentacion
{
    partial class FormOpcionesAdmin
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
            this.btSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPedidoLocal = new System.Windows.Forms.Button();
            this.btnPedidoEventos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDiasMayoresVentasDelivery = new System.Windows.Forms.Button();
            this.btnGanancias = new System.Windows.Forms.Button();
            this.btnSaboresPopulares = new System.Windows.Forms.Button();
            this.btnEventosMayorDemanda = new System.Windows.Forms.Button();
            this.btnEncuestas = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.BurlyWood;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(276, 310);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(81, 30);
            this.btSalir.TabIndex = 21;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(449, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 39);
            this.panel1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reportes";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(135, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(109, 39);
            this.panel5.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "¡HOLA, (NOMBRE DEL ADMINISTRADOR)!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btnPedidoLocal);
            this.panel3.Controls.Add(this.btnPedidoEventos);
            this.panel3.Location = new System.Drawing.Point(19, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 197);
            this.panel3.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.Evento;
            this.pictureBox2.Location = new System.Drawing.Point(176, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Local;
            this.pictureBox1.Location = new System.Drawing.Point(20, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnPedidoLocal
            // 
            this.btnPedidoLocal.BackColor = System.Drawing.Color.IndianRed;
            this.btnPedidoLocal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoLocal.ForeColor = System.Drawing.Color.White;
            this.btnPedidoLocal.Location = new System.Drawing.Point(29, 139);
            this.btnPedidoLocal.Name = "btnPedidoLocal";
            this.btnPedidoLocal.Size = new System.Drawing.Size(116, 33);
            this.btnPedidoLocal.TabIndex = 5;
            this.btnPedidoLocal.Text = "Pedido en local";
            this.btnPedidoLocal.UseVisualStyleBackColor = false;
            this.btnPedidoLocal.Click += new System.EventHandler(this.btnPedidoLocal_Click);
            // 
            // btnPedidoEventos
            // 
            this.btnPedidoEventos.BackColor = System.Drawing.Color.IndianRed;
            this.btnPedidoEventos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoEventos.ForeColor = System.Drawing.Color.White;
            this.btnPedidoEventos.Location = new System.Drawing.Point(168, 139);
            this.btnPedidoEventos.Name = "btnPedidoEventos";
            this.btnPedidoEventos.Size = new System.Drawing.Size(146, 33);
            this.btnPedidoEventos.TabIndex = 6;
            this.btnPedidoEventos.Text = "Pedido para eventos";
            this.btnPedidoEventos.UseVisualStyleBackColor = false;
            this.btnPedidoEventos.Click += new System.EventHandler(this.btnPedidoEventos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDiasMayoresVentasDelivery);
            this.panel2.Controls.Add(this.btnGanancias);
            this.panel2.Controls.Add(this.btnSaboresPopulares);
            this.panel2.Controls.Add(this.btnEventosMayorDemanda);
            this.panel2.Controls.Add(this.btnEncuestas);
            this.panel2.Location = new System.Drawing.Point(374, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 197);
            this.panel2.TabIndex = 19;
            // 
            // btnDiasMayoresVentasDelivery
            // 
            this.btnDiasMayoresVentasDelivery.BackColor = System.Drawing.Color.IndianRed;
            this.btnDiasMayoresVentasDelivery.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiasMayoresVentasDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDiasMayoresVentasDelivery.Location = new System.Drawing.Point(12, 78);
            this.btnDiasMayoresVentasDelivery.Name = "btnDiasMayoresVentasDelivery";
            this.btnDiasMayoresVentasDelivery.Size = new System.Drawing.Size(239, 30);
            this.btnDiasMayoresVentasDelivery.TabIndex = 9;
            this.btnDiasMayoresVentasDelivery.Text = "Día con mayores ventas de delivery";
            this.btnDiasMayoresVentasDelivery.UseVisualStyleBackColor = false;
            this.btnDiasMayoresVentasDelivery.Click += new System.EventHandler(this.btnDiasMayoresVentasDelivery_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.BackColor = System.Drawing.Color.IndianRed;
            this.btnGanancias.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanancias.ForeColor = System.Drawing.Color.White;
            this.btnGanancias.Location = new System.Drawing.Point(22, 47);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(220, 25);
            this.btnGanancias.TabIndex = 8;
            this.btnGanancias.Text = "Ganancias de ventas por fecha";
            this.btnGanancias.UseVisualStyleBackColor = false;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // btnSaboresPopulares
            // 
            this.btnSaboresPopulares.BackColor = System.Drawing.Color.IndianRed;
            this.btnSaboresPopulares.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaboresPopulares.ForeColor = System.Drawing.Color.White;
            this.btnSaboresPopulares.Location = new System.Drawing.Point(22, 16);
            this.btnSaboresPopulares.Name = "btnSaboresPopulares";
            this.btnSaboresPopulares.Size = new System.Drawing.Size(220, 25);
            this.btnSaboresPopulares.TabIndex = 7;
            this.btnSaboresPopulares.Text = "Sabores más populares por sede";
            this.btnSaboresPopulares.UseVisualStyleBackColor = false;
            this.btnSaboresPopulares.Click += new System.EventHandler(this.btnSaboresPopulares_Click);
            // 
            // btnEventosMayorDemanda
            // 
            this.btnEventosMayorDemanda.BackColor = System.Drawing.Color.IndianRed;
            this.btnEventosMayorDemanda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventosMayorDemanda.ForeColor = System.Drawing.Color.White;
            this.btnEventosMayorDemanda.Location = new System.Drawing.Point(22, 114);
            this.btnEventosMayorDemanda.Name = "btnEventosMayorDemanda";
            this.btnEventosMayorDemanda.Size = new System.Drawing.Size(220, 27);
            this.btnEventosMayorDemanda.TabIndex = 10;
            this.btnEventosMayorDemanda.Text = "Información de las encuestas";
            this.btnEventosMayorDemanda.UseVisualStyleBackColor = false;
            this.btnEventosMayorDemanda.Click += new System.EventHandler(this.btnEventosMayorDemanda_Click);
            // 
            // btnEncuestas
            // 
            this.btnEncuestas.BackColor = System.Drawing.Color.IndianRed;
            this.btnEncuestas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncuestas.ForeColor = System.Drawing.Color.White;
            this.btnEncuestas.Location = new System.Drawing.Point(22, 145);
            this.btnEncuestas.Name = "btnEncuestas";
            this.btnEncuestas.Size = new System.Drawing.Size(220, 47);
            this.btnEncuestas.TabIndex = 11;
            this.btnEncuestas.Text = "Mostrar los pedidos de un cliente por fecha";
            this.btnEncuestas.UseVisualStyleBackColor = false;
            this.btnEncuestas.Click += new System.EventHandler(this.btnEncuestas_Click);
            // 
            // FormOpcionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(672, 361);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormOpcionesAdmin";
            this.Text = "FormOpcionesAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPedidoLocal;
        private System.Windows.Forms.Button btnPedidoEventos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDiasMayoresVentasDelivery;
        private System.Windows.Forms.Button btnGanancias;
        private System.Windows.Forms.Button btnSaboresPopulares;
        private System.Windows.Forms.Button btnEventosMayorDemanda;
        private System.Windows.Forms.Button btnEncuestas;
    }
}