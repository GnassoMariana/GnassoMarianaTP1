namespace GnassoMarianaTP1.Windows
{
    partial class frmPiramides
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
            components = new System.ComponentModel.Container();
            piramidesListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            ladoTextBox = new TextBox();
            alturaTextBox = new TextBox();
            guardarButton = new Button();
            cancelarButton = new Button();
            errorProvider1 = new ErrorProvider(components);
            cantidadLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // piramidesListBox
            // 
            piramidesListBox.FormattingEnabled = true;
            piramidesListBox.Location = new Point(96, 147);
            piramidesListBox.Name = "piramidesListBox";
            piramidesListBox.Size = new Size(248, 224);
            piramidesListBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Lado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 96);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Altura";
            // 
            // ladoTextBox
            // 
            ladoTextBox.Location = new Point(136, 42);
            ladoTextBox.Name = "ladoTextBox";
            ladoTextBox.Size = new Size(125, 27);
            ladoTextBox.TabIndex = 3;
            // 
            // alturaTextBox
            // 
            alturaTextBox.Location = new Point(136, 93);
            alturaTextBox.Name = "alturaTextBox";
            alturaTextBox.Size = new Size(125, 27);
            alturaTextBox.TabIndex = 4;
            // 
            // guardarButton
            // 
            guardarButton.Location = new Point(307, 34);
            guardarButton.Name = "guardarButton";
            guardarButton.Size = new Size(94, 35);
            guardarButton.TabIndex = 5;
            guardarButton.Text = "Guardar";
            guardarButton.UseVisualStyleBackColor = true;
            guardarButton.Click += guardarButton_Click;
            // 
            // cancelarButton
            // 
            cancelarButton.Location = new Point(307, 92);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(94, 29);
            cancelarButton.TabIndex = 6;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = true;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.BackColor = SystemColors.ControlLightLight;
            cantidadLabel.BorderStyle = BorderStyle.FixedSingle;
            cantidadLabel.Location = new Point(92, 391);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new Size(252, 22);
            cantidadLabel.TabIndex = 7;
            cantidadLabel.Text = "Cantidad de piramides ingresadas: 0";
            // 
            // frmPiramides
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 450);
            Controls.Add(cantidadLabel);
            Controls.Add(cancelarButton);
            Controls.Add(guardarButton);
            Controls.Add(alturaTextBox);
            Controls.Add(ladoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(piramidesListBox);
            MaximumSize = new Size(467, 497);
            MinimumSize = new Size(467, 497);
            Name = "frmPiramides";
            Text = "Piramides";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox piramidesListBox;
        private Label label1;
        private Label label2;
        private TextBox ladoTextBox;
        private TextBox alturaTextBox;
        private Button guardarButton;
        private Button cancelarButton;
        private ErrorProvider errorProvider1;
        private Label cantidadLabel;
    }
}
