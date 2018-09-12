namespace WindowsFormsApp1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbINPUTS = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLBP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTFP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tbTAP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLWL = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCALCULATE = new System.Windows.Forms.Button();
            this.btnLOAD = new System.Windows.Forms.Button();
            this.tbVdisp = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbCm = new System.Windows.Forms.TextBox();
            this.tbAbt = new System.Windows.Forms.TextBox();
            this.tbLCB = new System.Windows.Forms.TextBox();
            this.tbCwp = new System.Windows.Forms.TextBox();
            this.tbVelocity = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbCstern = new System.Windows.Forms.TextBox();
            this.tbpropellerclearance = new System.Windows.Forms.TextBox();
            this.tbWettedArea = new System.Windows.Forms.TextBox();
            this.tbTransomArea = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbINPUTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1457, 756);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbINPUTS);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1449, 727);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gbINPUTS
            // 
            this.gbINPUTS.Controls.Add(this.tbpropellerclearance);
            this.gbINPUTS.Controls.Add(this.tbWettedArea);
            this.gbINPUTS.Controls.Add(this.tbTransomArea);
            this.gbINPUTS.Controls.Add(this.tbCwp);
            this.gbINPUTS.Controls.Add(this.tbVelocity);
            this.gbINPUTS.Controls.Add(this.tbZ);
            this.gbINPUTS.Controls.Add(this.tbCstern);
            this.gbINPUTS.Controls.Add(this.tbVdisp);
            this.gbINPUTS.Controls.Add(this.tbD);
            this.gbINPUTS.Controls.Add(this.tbCm);
            this.gbINPUTS.Controls.Add(this.tbAbt);
            this.gbINPUTS.Controls.Add(this.tbLCB);
            this.gbINPUTS.Controls.Add(this.btnLOAD);
            this.gbINPUTS.Controls.Add(this.btnCALCULATE);
            this.gbINPUTS.Controls.Add(this.btnSAVE);
            this.gbINPUTS.Controls.Add(this.label16);
            this.gbINPUTS.Controls.Add(this.label17);
            this.gbINPUTS.Controls.Add(this.label20);
            this.gbINPUTS.Controls.Add(this.label11);
            this.gbINPUTS.Controls.Add(this.label12);
            this.gbINPUTS.Controls.Add(this.label13);
            this.gbINPUTS.Controls.Add(this.label14);
            this.gbINPUTS.Controls.Add(this.label15);
            this.gbINPUTS.Controls.Add(this.label1);
            this.gbINPUTS.Controls.Add(this.tbLBP);
            this.gbINPUTS.Controls.Add(this.label6);
            this.gbINPUTS.Controls.Add(this.label2);
            this.gbINPUTS.Controls.Add(this.tbTFP);
            this.gbINPUTS.Controls.Add(this.label7);
            this.gbINPUTS.Controls.Add(this.label3);
            this.gbINPUTS.Controls.Add(this.textBox8);
            this.gbINPUTS.Controls.Add(this.tbTAP);
            this.gbINPUTS.Controls.Add(this.label8);
            this.gbINPUTS.Controls.Add(this.label4);
            this.gbINPUTS.Controls.Add(this.tbB);
            this.gbINPUTS.Controls.Add(this.label9);
            this.gbINPUTS.Controls.Add(this.label5);
            this.gbINPUTS.Controls.Add(this.tbLWL);
            this.gbINPUTS.Controls.Add(this.label10);
            this.gbINPUTS.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbINPUTS.Location = new System.Drawing.Point(18, 32);
            this.gbINPUTS.Name = "gbINPUTS";
            this.gbINPUTS.Size = new System.Drawing.Size(1337, 397);
            this.gbINPUTS.TabIndex = 20;
            this.gbINPUTS.TabStop = false;
            this.gbINPUTS.Text = "INPUTS";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(687, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 27);
            this.label16.TabIndex = 38;
            this.label16.Text = "Velocity";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(978, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(196, 27);
            this.label17.TabIndex = 36;
            this.label17.Text = "propeller clearance";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(687, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 27);
            this.label20.TabIndex = 30;
            this.label20.Text = "Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(978, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 27);
            this.label11.TabIndex = 28;
            this.label11.Text = "Transom Area";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(978, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 27);
            this.label12.TabIndex = 26;
            this.label12.Text = "Wetted Area(append.)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(687, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 27);
            this.label13.TabIndex = 24;
            this.label13.Text = "C stern";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(337, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 27);
            this.label14.TabIndex = 22;
            this.label14.Text = "D";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(687, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 27);
            this.label15.TabIndex = 20;
            this.label15.Text = "Cwp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "LBP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbLBP
            // 
            this.tbLBP.BackColor = System.Drawing.Color.White;
            this.tbLBP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLBP.Location = new System.Drawing.Point(167, 25);
            this.tbLBP.Name = "tbLBP";
            this.tbLBP.Size = new System.Drawing.Size(131, 34);
            this.tbLBP.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(337, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 27);
            this.label6.TabIndex = 18;
            this.label6.Text = "LCB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "T(mld on FP)";
            // 
            // tbTFP
            // 
            this.tbTFP.BackColor = System.Drawing.Color.White;
            this.tbTFP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTFP.Location = new System.Drawing.Point(167, 239);
            this.tbTFP.Name = "tbTFP";
            this.tbTFP.Size = new System.Drawing.Size(131, 34);
            this.tbTFP.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Abt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "T(mld on AP)";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(340, 284);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(131, 34);
            this.textBox8.TabIndex = 15;
            // 
            // tbTAP
            // 
            this.tbTAP.BackColor = System.Drawing.Color.White;
            this.tbTAP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTAP.Location = new System.Drawing.Point(167, 182);
            this.tbTAP.Name = "tbTAP";
            this.tbTAP.Size = new System.Drawing.Size(131, 34);
            this.tbTAP.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 27);
            this.label8.TabIndex = 14;
            this.label8.Text = "centre of Abt above keel line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "B(mld)";
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.Color.White;
            this.tbB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.Location = new System.Drawing.Point(167, 127);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(131, 34);
            this.tbB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(337, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "LWL";
            // 
            // tbLWL
            // 
            this.tbLWL.BackColor = System.Drawing.Color.White;
            this.tbLWL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLWL.Location = new System.Drawing.Point(167, 77);
            this.tbLWL.Name = "tbLWL";
            this.tbLWL.Size = new System.Drawing.Size(131, 34);
            this.tbLWL.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(337, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 27);
            this.label10.TabIndex = 10;
            this.label10.Text = "disp V(mld)";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1358, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSAVE
            // 
            this.btnSAVE.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.Location = new System.Drawing.Point(692, 279);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(166, 43);
            this.btnSAVE.TabIndex = 40;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            // 
            // btnCALCULATE
            // 
            this.btnCALCULATE.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCALCULATE.Location = new System.Drawing.Point(692, 328);
            this.btnCALCULATE.Name = "btnCALCULATE";
            this.btnCALCULATE.Size = new System.Drawing.Size(166, 43);
            this.btnCALCULATE.TabIndex = 41;
            this.btnCALCULATE.Text = "CALCULATE";
            this.btnCALCULATE.UseVisualStyleBackColor = true;
            // 
            // btnLOAD
            // 
            this.btnLOAD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOAD.Location = new System.Drawing.Point(692, 230);
            this.btnLOAD.Name = "btnLOAD";
            this.btnLOAD.Size = new System.Drawing.Size(166, 43);
            this.btnLOAD.TabIndex = 42;
            this.btnLOAD.Text = "LOAD";
            this.btnLOAD.UseVisualStyleBackColor = true;
            // 
            // tbVdisp
            // 
            this.tbVdisp.BackColor = System.Drawing.Color.White;
            this.tbVdisp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVdisp.Location = new System.Drawing.Point(491, 25);
            this.tbVdisp.Name = "tbVdisp";
            this.tbVdisp.Size = new System.Drawing.Size(131, 34);
            this.tbVdisp.TabIndex = 43;
            // 
            // tbD
            // 
            this.tbD.BackColor = System.Drawing.Color.White;
            this.tbD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbD.Location = new System.Drawing.Point(491, 239);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(131, 34);
            this.tbD.TabIndex = 44;
            // 
            // tbCm
            // 
            this.tbCm.BackColor = System.Drawing.Color.White;
            this.tbCm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCm.Location = new System.Drawing.Point(491, 182);
            this.tbCm.Name = "tbCm";
            this.tbCm.Size = new System.Drawing.Size(131, 34);
            this.tbCm.TabIndex = 45;
            // 
            // tbAbt
            // 
            this.tbAbt.BackColor = System.Drawing.Color.White;
            this.tbAbt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAbt.Location = new System.Drawing.Point(491, 127);
            this.tbAbt.Name = "tbAbt";
            this.tbAbt.Size = new System.Drawing.Size(131, 34);
            this.tbAbt.TabIndex = 46;
            // 
            // tbLCB
            // 
            this.tbLCB.BackColor = System.Drawing.Color.White;
            this.tbLCB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLCB.Location = new System.Drawing.Point(491, 77);
            this.tbLCB.Name = "tbLCB";
            this.tbLCB.Size = new System.Drawing.Size(131, 34);
            this.tbLCB.TabIndex = 47;
            // 
            // tbCwp
            // 
            this.tbCwp.BackColor = System.Drawing.Color.White;
            this.tbCwp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCwp.Location = new System.Drawing.Point(790, 25);
            this.tbCwp.Name = "tbCwp";
            this.tbCwp.Size = new System.Drawing.Size(131, 34);
            this.tbCwp.TabIndex = 48;
            // 
            // tbVelocity
            // 
            this.tbVelocity.BackColor = System.Drawing.Color.White;
            this.tbVelocity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVelocity.Location = new System.Drawing.Point(790, 182);
            this.tbVelocity.Name = "tbVelocity";
            this.tbVelocity.Size = new System.Drawing.Size(131, 34);
            this.tbVelocity.TabIndex = 49;
            // 
            // tbZ
            // 
            this.tbZ.BackColor = System.Drawing.Color.White;
            this.tbZ.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZ.Location = new System.Drawing.Point(790, 127);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(131, 34);
            this.tbZ.TabIndex = 50;
            // 
            // tbCstern
            // 
            this.tbCstern.BackColor = System.Drawing.Color.White;
            this.tbCstern.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCstern.Location = new System.Drawing.Point(790, 77);
            this.tbCstern.Name = "tbCstern";
            this.tbCstern.Size = new System.Drawing.Size(131, 34);
            this.tbCstern.TabIndex = 51;
            // 
            // tbpropellerclearance
            // 
            this.tbpropellerclearance.BackColor = System.Drawing.Color.White;
            this.tbpropellerclearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpropellerclearance.Location = new System.Drawing.Point(1200, 25);
            this.tbpropellerclearance.Name = "tbpropellerclearance";
            this.tbpropellerclearance.Size = new System.Drawing.Size(131, 34);
            this.tbpropellerclearance.TabIndex = 52;
            // 
            // tbWettedArea
            // 
            this.tbWettedArea.BackColor = System.Drawing.Color.White;
            this.tbWettedArea.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWettedArea.Location = new System.Drawing.Point(1200, 127);
            this.tbWettedArea.Name = "tbWettedArea";
            this.tbWettedArea.Size = new System.Drawing.Size(131, 34);
            this.tbWettedArea.TabIndex = 53;
            // 
            // tbTransomArea
            // 
            this.tbTransomArea.BackColor = System.Drawing.Color.White;
            this.tbTransomArea.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTransomArea.Location = new System.Drawing.Point(1200, 77);
            this.tbTransomArea.Name = "tbTransomArea";
            this.tbTransomArea.Size = new System.Drawing.Size(131, 34);
            this.tbTransomArea.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 763);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbINPUTS.ResumeLayout(false);
            this.gbINPUTS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbLBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbINPUTS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTFP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tbTAP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLWL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbpropellerclearance;
        private System.Windows.Forms.TextBox tbWettedArea;
        private System.Windows.Forms.TextBox tbTransomArea;
        private System.Windows.Forms.TextBox tbCwp;
        private System.Windows.Forms.TextBox tbVelocity;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.TextBox tbCstern;
        private System.Windows.Forms.TextBox tbVdisp;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbCm;
        private System.Windows.Forms.TextBox tbAbt;
        private System.Windows.Forms.TextBox tbLCB;
        private System.Windows.Forms.Button btnLOAD;
        private System.Windows.Forms.Button btnCALCULATE;
        private System.Windows.Forms.Button btnSAVE;
    }
}

