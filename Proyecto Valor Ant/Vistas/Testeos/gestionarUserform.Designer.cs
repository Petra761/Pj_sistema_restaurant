namespace Proyecto_Valor_Ant
{
    partial class gestionarUserform
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.datagridUsers = new System.Windows.Forms.DataGridView();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.contratxt = new System.Windows.Forms.TextBox();
            this.sueldotxt = new System.Windows.Forms.TextBox();
            this.persona_idtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboxrol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datagridhorarios = new System.Windows.Forms.DataGridView();
            this.horarioidtxt = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnpersona = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridhorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(516, 417);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 56);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // datagridUsers
            // 
            this.datagridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridUsers.Location = new System.Drawing.Point(476, 21);
            this.datagridUsers.Name = "datagridUsers";
            this.datagridUsers.RowHeadersWidth = 51;
            this.datagridUsers.RowTemplate.Height = 24;
            this.datagridUsers.Size = new System.Drawing.Size(830, 343);
            this.datagridUsers.TabIndex = 1;
            this.datagridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(153, 21);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(150, 22);
            this.idtxt.TabIndex = 2;
            // 
            // usuariotxt
            // 
            this.usuariotxt.Location = new System.Drawing.Point(153, 65);
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.Size = new System.Drawing.Size(150, 22);
            this.usuariotxt.TabIndex = 3;
            // 
            // contratxt
            // 
            this.contratxt.Location = new System.Drawing.Point(153, 115);
            this.contratxt.Name = "contratxt";
            this.contratxt.Size = new System.Drawing.Size(150, 22);
            this.contratxt.TabIndex = 4;
            // 
            // sueldotxt
            // 
            this.sueldotxt.Location = new System.Drawing.Point(153, 215);
            this.sueldotxt.Name = "sueldotxt";
            this.sueldotxt.Size = new System.Drawing.Size(150, 22);
            this.sueldotxt.TabIndex = 6;
            // 
            // persona_idtxt
            // 
            this.persona_idtxt.Location = new System.Drawing.Point(153, 262);
            this.persona_idtxt.Name = "persona_idtxt";
            this.persona_idtxt.Size = new System.Drawing.Size(150, 22);
            this.persona_idtxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "rol";
            // 
            // cmboxrol
            // 
            this.cmboxrol.FormattingEnabled = true;
            this.cmboxrol.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.cmboxrol.Location = new System.Drawing.Point(153, 163);
            this.cmboxrol.Name = "cmboxrol";
            this.cmboxrol.Size = new System.Drawing.Size(150, 24);
            this.cmboxrol.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sueldo por Jornada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Persona Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Horario Id";
            // 
            // datagridhorarios
            // 
            this.datagridhorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridhorarios.Location = new System.Drawing.Point(12, 370);
            this.datagridhorarios.Name = "datagridhorarios";
            this.datagridhorarios.RowHeadersWidth = 51;
            this.datagridhorarios.RowTemplate.Height = 24;
            this.datagridhorarios.Size = new System.Drawing.Size(442, 157);
            this.datagridhorarios.TabIndex = 17;
            // 
            // horarioidtxt
            // 
            this.horarioidtxt.Location = new System.Drawing.Point(153, 311);
            this.horarioidtxt.Name = "horarioidtxt";
            this.horarioidtxt.Size = new System.Drawing.Size(150, 22);
            this.horarioidtxt.TabIndex = 18;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(680, 417);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 56);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar usuario";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(845, 417);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 56);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar usuario";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnpersona
            // 
            this.btnpersona.Location = new System.Drawing.Point(817, 371);
            this.btnpersona.Name = "btnpersona";
            this.btnpersona.Size = new System.Drawing.Size(75, 23);
            this.btnpersona.TabIndex = 21;
            this.btnpersona.Text = "Persona";
            this.btnpersona.UseVisualStyleBackColor = true;
            this.btnpersona.Click += new System.EventHandler(this.btnpersona_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.Location = new System.Drawing.Point(923, 371);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(75, 23);
            this.btnusuario.TabIndex = 22;
            this.btnusuario.Text = "Usuarios";
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // gestionarUserform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 544);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.btnpersona);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.horarioidtxt);
            this.Controls.Add(this.datagridhorarios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboxrol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.persona_idtxt);
            this.Controls.Add(this.sueldotxt);
            this.Controls.Add(this.contratxt);
            this.Controls.Add(this.usuariotxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.datagridUsers);
            this.Controls.Add(this.btnAgregar);
            this.Name = "gestionarUserform";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.gestionarUserform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridhorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView datagridUsers;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.TextBox contratxt;
        private System.Windows.Forms.TextBox sueldotxt;
        private System.Windows.Forms.TextBox persona_idtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboxrol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView datagridhorarios;
        private System.Windows.Forms.TextBox horarioidtxt;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnpersona;
        private System.Windows.Forms.Button btnusuario;
    }
}