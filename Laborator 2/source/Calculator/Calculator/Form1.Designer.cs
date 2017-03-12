namespace Calculator
{
     partial class Calculator
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
               this.plusButton = new System.Windows.Forms.Button();
               this.equalButton = new System.Windows.Forms.Button();
               this.panel1 = new System.Windows.Forms.Panel();
               this.buttonDelete = new System.Windows.Forms.Button();
               this.buttonC = new System.Windows.Forms.Button();
               this.buttonCE = new System.Windows.Forms.Button();
               this.buttonPunct = new System.Windows.Forms.Button();
               this.buttonPlusMinus = new System.Windows.Forms.Button();
               this.button0 = new System.Windows.Forms.Button();
               this.minusButton = new System.Windows.Forms.Button();
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.button5 = new System.Windows.Forms.Button();
               this.button6 = new System.Windows.Forms.Button();
               this.button7 = new System.Windows.Forms.Button();
               this.button8 = new System.Windows.Forms.Button();
               this.button9 = new System.Windows.Forms.Button();
               this.multButton = new System.Windows.Forms.Button();
               this.divideButton = new System.Windows.Forms.Button();
               this.buttonProcent = new System.Windows.Forms.Button();
               this.buttonRadical = new System.Windows.Forms.Button();
               this.buttonPutere = new System.Windows.Forms.Button();
               this.buttonx_y = new System.Windows.Forms.Button();
               this.numberTextBox = new System.Windows.Forms.TextBox();
               this.textBoxShow = new System.Windows.Forms.TextBox();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.panel1.SuspendLayout();
               this.menuStrip1.SuspendLayout();
               this.SuspendLayout();
               // 
               // plusButton
               // 
               this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.plusButton.Location = new System.Drawing.Point(236, 159);
               this.plusButton.Name = "plusButton";
               this.plusButton.Size = new System.Drawing.Size(82, 50);
               this.plusButton.TabIndex = 0;
               this.plusButton.Text = "+";
               this.plusButton.UseVisualStyleBackColor = true;
               this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
               // 
               // equalButton
               // 
               this.equalButton.BackColor = System.Drawing.SystemColors.ControlLight;
               this.equalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.equalButton.Location = new System.Drawing.Point(236, 215);
               this.equalButton.Name = "equalButton";
               this.equalButton.Size = new System.Drawing.Size(82, 51);
               this.equalButton.TabIndex = 1;
               this.equalButton.Text = "=";
               this.equalButton.UseVisualStyleBackColor = false;
               this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
               this.panel1.Controls.Add(this.buttonDelete);
               this.panel1.Controls.Add(this.buttonC);
               this.panel1.Controls.Add(this.buttonCE);
               this.panel1.Controls.Add(this.buttonPunct);
               this.panel1.Controls.Add(this.buttonPlusMinus);
               this.panel1.Controls.Add(this.button0);
               this.panel1.Controls.Add(this.minusButton);
               this.panel1.Controls.Add(this.button1);
               this.panel1.Controls.Add(this.button2);
               this.panel1.Controls.Add(this.button3);
               this.panel1.Controls.Add(this.button4);
               this.panel1.Controls.Add(this.button5);
               this.panel1.Controls.Add(this.button6);
               this.panel1.Controls.Add(this.button7);
               this.panel1.Controls.Add(this.button8);
               this.panel1.Controls.Add(this.button9);
               this.panel1.Controls.Add(this.multButton);
               this.panel1.Controls.Add(this.divideButton);
               this.panel1.Controls.Add(this.plusButton);
               this.panel1.Controls.Add(this.equalButton);
               this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.panel1.Location = new System.Drawing.Point(0, 188);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(318, 275);
               this.panel1.TabIndex = 4;
               // 
               // buttonDelete
               // 
               this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonDelete.Location = new System.Drawing.Point(167, 0);
               this.buttonDelete.Name = "buttonDelete";
               this.buttonDelete.Size = new System.Drawing.Size(70, 41);
               this.buttonDelete.TabIndex = 21;
               this.buttonDelete.Text = "←";
               this.buttonDelete.UseVisualStyleBackColor = true;
               this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
               // 
               // buttonC
               // 
               this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonC.Location = new System.Drawing.Point(87, 0);
               this.buttonC.Name = "buttonC";
               this.buttonC.Size = new System.Drawing.Size(75, 42);
               this.buttonC.TabIndex = 20;
               this.buttonC.Text = "C";
               this.buttonC.UseVisualStyleBackColor = true;
               this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
               // 
               // buttonCE
               // 
               this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonCE.Location = new System.Drawing.Point(4, 0);
               this.buttonCE.Name = "buttonCE";
               this.buttonCE.Size = new System.Drawing.Size(77, 42);
               this.buttonCE.TabIndex = 19;
               this.buttonCE.Text = "CE";
               this.buttonCE.UseVisualStyleBackColor = true;
               this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
               // 
               // buttonPunct
               // 
               this.buttonPunct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonPunct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonPunct.Location = new System.Drawing.Point(167, 215);
               this.buttonPunct.Name = "buttonPunct";
               this.buttonPunct.Size = new System.Drawing.Size(71, 51);
               this.buttonPunct.TabIndex = 15;
               this.buttonPunct.Text = ".";
               this.buttonPunct.UseVisualStyleBackColor = true;
               this.buttonPunct.Click += new System.EventHandler(this.buttonPunct_Click);
               // 
               // buttonPlusMinus
               // 
               this.buttonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonPlusMinus.Location = new System.Drawing.Point(6, 215);
               this.buttonPlusMinus.Name = "buttonPlusMinus";
               this.buttonPlusMinus.Size = new System.Drawing.Size(77, 51);
               this.buttonPlusMinus.TabIndex = 5;
               this.buttonPlusMinus.Text = "±";
               this.buttonPlusMinus.UseVisualStyleBackColor = true;
               this.buttonPlusMinus.Click += new System.EventHandler(this.buttonPlusMinus_Click);
               // 
               // button0
               // 
               this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button0.Location = new System.Drawing.Point(87, 215);
               this.button0.Name = "button0";
               this.button0.Size = new System.Drawing.Size(75, 51);
               this.button0.TabIndex = 14;
               this.button0.Text = "0";
               this.button0.UseVisualStyleBackColor = true;
               this.button0.Click += new System.EventHandler(this.button0_Click);
               // 
               // minusButton
               // 
               this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.minusButton.Location = new System.Drawing.Point(236, 99);
               this.minusButton.Name = "minusButton";
               this.minusButton.Size = new System.Drawing.Size(82, 54);
               this.minusButton.TabIndex = 4;
               this.minusButton.Text = "-";
               this.minusButton.UseVisualStyleBackColor = true;
               this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
               // 
               // button1
               // 
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(6, 159);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(77, 50);
               this.button1.TabIndex = 5;
               this.button1.Text = "1";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(88, 159);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(76, 50);
               this.button2.TabIndex = 6;
               this.button2.Text = "2";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(167, 159);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(71, 50);
               this.button3.TabIndex = 7;
               this.button3.Text = "3";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // button4
               // 
               this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button4.Location = new System.Drawing.Point(5, 99);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(78, 54);
               this.button4.TabIndex = 8;
               this.button4.Text = "4";
               this.button4.UseVisualStyleBackColor = true;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // button5
               // 
               this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button5.Location = new System.Drawing.Point(89, 99);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(75, 54);
               this.button5.TabIndex = 9;
               this.button5.Text = "5";
               this.button5.UseVisualStyleBackColor = true;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // button6
               // 
               this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button6.Location = new System.Drawing.Point(168, 99);
               this.button6.Name = "button6";
               this.button6.Size = new System.Drawing.Size(72, 54);
               this.button6.TabIndex = 10;
               this.button6.Text = "6";
               this.button6.UseVisualStyleBackColor = true;
               this.button6.Click += new System.EventHandler(this.button6_Click);
               // 
               // button7
               // 
               this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button7.Location = new System.Drawing.Point(4, 48);
               this.button7.Name = "button7";
               this.button7.Size = new System.Drawing.Size(79, 45);
               this.button7.TabIndex = 11;
               this.button7.Text = "7";
               this.button7.UseVisualStyleBackColor = true;
               this.button7.Click += new System.EventHandler(this.button7_Click);
               // 
               // button8
               // 
               this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button8.Location = new System.Drawing.Point(89, 48);
               this.button8.Name = "button8";
               this.button8.Size = new System.Drawing.Size(75, 45);
               this.button8.TabIndex = 12;
               this.button8.Text = "8";
               this.button8.UseVisualStyleBackColor = true;
               this.button8.Click += new System.EventHandler(this.button8_Click);
               // 
               // button9
               // 
               this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button9.Location = new System.Drawing.Point(168, 48);
               this.button9.Name = "button9";
               this.button9.Size = new System.Drawing.Size(70, 45);
               this.button9.TabIndex = 13;
               this.button9.Text = "9";
               this.button9.UseVisualStyleBackColor = true;
               this.button9.Click += new System.EventHandler(this.button9_Click);
               // 
               // multButton
               // 
               this.multButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.multButton.Location = new System.Drawing.Point(236, 48);
               this.multButton.Name = "multButton";
               this.multButton.Size = new System.Drawing.Size(82, 45);
               this.multButton.TabIndex = 3;
               this.multButton.Text = "x";
               this.multButton.UseVisualStyleBackColor = true;
               this.multButton.Click += new System.EventHandler(this.multButton_Click);
               // 
               // divideButton
               // 
               this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.divideButton.Location = new System.Drawing.Point(236, 0);
               this.divideButton.Name = "divideButton";
               this.divideButton.Size = new System.Drawing.Size(82, 41);
               this.divideButton.TabIndex = 2;
               this.divideButton.Text = "÷";
               this.divideButton.UseVisualStyleBackColor = true;
               this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
               // 
               // buttonProcent
               // 
               this.buttonProcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonProcent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonProcent.Location = new System.Drawing.Point(2, 140);
               this.buttonProcent.Name = "buttonProcent";
               this.buttonProcent.Size = new System.Drawing.Size(79, 42);
               this.buttonProcent.TabIndex = 16;
               this.buttonProcent.Text = "%";
               this.buttonProcent.UseVisualStyleBackColor = true;
               this.buttonProcent.Click += new System.EventHandler(this.buttonProcent_Click);
               // 
               // buttonRadical
               // 
               this.buttonRadical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonRadical.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonRadical.Location = new System.Drawing.Point(87, 140);
               this.buttonRadical.Name = "buttonRadical";
               this.buttonRadical.Size = new System.Drawing.Size(75, 42);
               this.buttonRadical.TabIndex = 17;
               this.buttonRadical.Text = "√";
               this.buttonRadical.UseVisualStyleBackColor = true;
               this.buttonRadical.Click += new System.EventHandler(this.buttonRadical_Click);
               // 
               // buttonPutere
               // 
               this.buttonPutere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonPutere.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonPutere.Location = new System.Drawing.Point(165, 140);
               this.buttonPutere.Name = "buttonPutere";
               this.buttonPutere.Size = new System.Drawing.Size(72, 42);
               this.buttonPutere.TabIndex = 18;
               this.buttonPutere.Text = "x^2";
               this.buttonPutere.UseVisualStyleBackColor = true;
               this.buttonPutere.Click += new System.EventHandler(this.buttonPutere_Click);
               // 
               // buttonx_y
               // 
               this.buttonx_y.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.buttonx_y.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonx_y.Location = new System.Drawing.Point(236, 140);
               this.buttonx_y.Name = "buttonx_y";
               this.buttonx_y.Size = new System.Drawing.Size(82, 42);
               this.buttonx_y.TabIndex = 22;
               this.buttonx_y.Text = "x^y";
               this.buttonx_y.UseVisualStyleBackColor = true;
               this.buttonx_y.Click += new System.EventHandler(this.buttonx_y_Click);
               // 
               // numberTextBox
               // 
               this.numberTextBox.BackColor = System.Drawing.SystemColors.Control;
               this.numberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.numberTextBox.Enabled = false;
               this.numberTextBox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.numberTextBox.Location = new System.Drawing.Point(2, 27);
               this.numberTextBox.Multiline = true;
               this.numberTextBox.Name = "numberTextBox";
               this.numberTextBox.ReadOnly = true;
               this.numberTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
               this.numberTextBox.Size = new System.Drawing.Size(314, 34);
               this.numberTextBox.TabIndex = 24;
               this.numberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
               // 
               // textBoxShow
               // 
               this.textBoxShow.BackColor = System.Drawing.SystemColors.Control;
               this.textBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBoxShow.Enabled = false;
               this.textBoxShow.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBoxShow.Location = new System.Drawing.Point(4, 74);
               this.textBoxShow.Multiline = true;
               this.textBoxShow.Name = "textBoxShow";
               this.textBoxShow.ReadOnly = true;
               this.textBoxShow.Size = new System.Drawing.Size(312, 46);
               this.textBoxShow.TabIndex = 25;
               this.textBoxShow.Text = "0";
               this.textBoxShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
               this.textBoxShow.TextChanged += new System.EventHandler(this.textBoxShow_TextChanged);
               // 
               // menuStrip1
               // 
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(321, 24);
               this.menuStrip1.TabIndex = 26;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
               this.fileToolStripMenuItem.Text = "File";
               // 
               // exitToolStripMenuItem
               // 
               this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
               this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
               this.exitToolStripMenuItem.Text = "Exit";
               this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
               this.aboutToolStripMenuItem.Text = "About";
               this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
               // 
               // Calculator
               // 
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
               this.BackColor = System.Drawing.SystemColors.Control;
               this.ClientSize = new System.Drawing.Size(321, 462);
               this.Controls.Add(this.textBoxShow);
               this.Controls.Add(this.numberTextBox);
               this.Controls.Add(this.buttonx_y);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.buttonProcent);
               this.Controls.Add(this.buttonRadical);
               this.Controls.Add(this.buttonPutere);
               this.Controls.Add(this.menuStrip1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MainMenuStrip = this.menuStrip1;
               this.MaximizeBox = false;
               this.Name = "Calculator";
               this.Text = "Calculator ";
               this.panel1.ResumeLayout(false);
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Button plusButton;
          private System.Windows.Forms.Button equalButton;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Button minusButton;
          private System.Windows.Forms.Button multButton;
          private System.Windows.Forms.Button divideButton;
          private System.Windows.Forms.Button button9;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button5;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.Button button7;
          private System.Windows.Forms.Button button8;
          private System.Windows.Forms.Button button0;
          private System.Windows.Forms.Button buttonPunct;
          private System.Windows.Forms.Button buttonPlusMinus;
          private System.Windows.Forms.Button buttonRadical;
          private System.Windows.Forms.Button buttonProcent;
          private System.Windows.Forms.Button buttonPutere;
          private System.Windows.Forms.Button buttonx_y;
          private System.Windows.Forms.Button buttonDelete;
          private System.Windows.Forms.Button buttonC;
          private System.Windows.Forms.Button buttonCE;
          private System.Windows.Forms.TextBox numberTextBox;
          private System.Windows.Forms.TextBox textBoxShow;
          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
     }
}

