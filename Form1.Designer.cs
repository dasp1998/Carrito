
namespace Carrito
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3Acelerar = new System.Windows.Forms.Button();
            this.button4Frenar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelDatos = new System.Windows.Forms.Label();
            this.label1Velocidad = new System.Windows.Forms.Label();
            this.label1Frenar = new System.Windows.Forms.Label();
            this.label1Apagar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Carro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Encender Carro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3Acelerar
            // 
            this.button3Acelerar.Location = new System.Drawing.Point(50, 182);
            this.button3Acelerar.Name = "button3Acelerar";
            this.button3Acelerar.Size = new System.Drawing.Size(159, 29);
            this.button3Acelerar.TabIndex = 2;
            this.button3Acelerar.Text = "Acelerar";
            this.button3Acelerar.UseVisualStyleBackColor = true;
            this.button3Acelerar.Click += new System.EventHandler(this.button3Acelerar_Click);
            // 
            // button4Frenar
            // 
            this.button4Frenar.Location = new System.Drawing.Point(50, 243);
            this.button4Frenar.Name = "button4Frenar";
            this.button4Frenar.Size = new System.Drawing.Size(159, 29);
            this.button4Frenar.TabIndex = 3;
            this.button4Frenar.Text = "Frenar";
            this.button4Frenar.UseVisualStyleBackColor = true;
            this.button4Frenar.Click += new System.EventHandler(this.button4Frenar_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 29);
            this.button5.TabIndex = 4;
            this.button5.Text = "Apagar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelDatos
            // 
            this.labelDatos.AutoSize = true;
            this.labelDatos.Location = new System.Drawing.Point(427, 81);
            this.labelDatos.Name = "labelDatos";
            this.labelDatos.Size = new System.Drawing.Size(48, 20);
            this.labelDatos.TabIndex = 5;
            this.labelDatos.Text = "Datos";
            // 
            // label1Velocidad
            // 
            this.label1Velocidad.AutoSize = true;
            this.label1Velocidad.Location = new System.Drawing.Point(427, 155);
            this.label1Velocidad.Name = "label1Velocidad";
            this.label1Velocidad.Size = new System.Drawing.Size(50, 20);
            this.label1Velocidad.TabIndex = 6;
            this.label1Velocidad.Text = "label2";
            // 
            // label1Frenar
            // 
            this.label1Frenar.AutoSize = true;
            this.label1Frenar.Location = new System.Drawing.Point(427, 223);
            this.label1Frenar.Name = "label1Frenar";
            this.label1Frenar.Size = new System.Drawing.Size(50, 20);
            this.label1Frenar.TabIndex = 7;
            this.label1Frenar.Text = "label3";
            // 
            // label1Apagar
            // 
            this.label1Apagar.AutoSize = true;
            this.label1Apagar.Location = new System.Drawing.Point(427, 284);
            this.label1Apagar.Name = "label1Apagar";
            this.label1Apagar.Size = new System.Drawing.Size(50, 20);
            this.label1Apagar.TabIndex = 8;
            this.label1Apagar.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1Apagar);
            this.Controls.Add(this.label1Frenar);
            this.Controls.Add(this.label1Velocidad);
            this.Controls.Add(this.labelDatos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4Frenar);
            this.Controls.Add(this.button3Acelerar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Crear Carro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3Acelerar;
        private System.Windows.Forms.Button button4Frenar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelDatos;
        private System.Windows.Forms.Label label1Velocidad;
        private System.Windows.Forms.Label label1Frenar;
        private System.Windows.Forms.Label label1Apagar;
    }
}

