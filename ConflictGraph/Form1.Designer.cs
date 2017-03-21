namespace ConflictGraph
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtSSResult = new System.Windows.Forms.Label();
            this.txtSerialSchedule = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.panelDTGV = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelHost = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.tabControlSchedule = new System.Windows.Forms.TabControl();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.tabPageSerialSchedule = new System.Windows.Forms.TabPage();
            this.dtgvSerialSchedule = new System.Windows.Forms.DataGridView();
            this.dtgvSchedule = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelDTGV.SuspendLayout();
            this.panelHost.SuspendLayout();
            this.tabControlSchedule.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            this.tabPageSerialSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSerialSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtSSResult);
            this.panelTop.Controls.Add(this.txtSerialSchedule);
            this.panelTop.Controls.Add(this.txtResult);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtInput);
            this.panelTop.Controls.Add(this.btnGenerate);
            this.panelTop.Controls.Add(this.btnReload);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(925, 122);
            this.panelTop.TabIndex = 0;
            // 
            // txtSSResult
            // 
            this.txtSSResult.AutoSize = true;
            this.txtSSResult.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSResult.ForeColor = System.Drawing.Color.Black;
            this.txtSSResult.Location = new System.Drawing.Point(163, 86);
            this.txtSSResult.Name = "txtSSResult";
            this.txtSSResult.Size = new System.Drawing.Size(0, 20);
            this.txtSSResult.TabIndex = 7;
            // 
            // txtSerialSchedule
            // 
            this.txtSerialSchedule.AutoSize = true;
            this.txtSerialSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialSchedule.Location = new System.Drawing.Point(13, 86);
            this.txtSerialSchedule.Name = "txtSerialSchedule";
            this.txtSerialSchedule.Size = new System.Drawing.Size(138, 22);
            this.txtSerialSchedule.TabIndex = 6;
            this.txtSerialSchedule.Text = "Serial schedule:";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Red;
            this.txtResult.Location = new System.Drawing.Point(108, 47);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(0, 22);
            this.txtResult.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Schedule";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(104, 7);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(698, 27);
            this.txtInput.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtInput, "Schedule fromat example: W1(A), R1(A), W2(B), R2(B)...");
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(825, 7);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 59);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(825, 72);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(88, 36);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panelDTGV
            // 
            this.panelDTGV.Controls.Add(this.tabControlSchedule);
            this.panelDTGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDTGV.Location = new System.Drawing.Point(0, 122);
            this.panelDTGV.Name = "panelDTGV";
            this.panelDTGV.Size = new System.Drawing.Size(461, 371);
            this.panelDTGV.TabIndex = 1;
            // 
            // panelHost
            // 
            this.panelHost.Controls.Add(this.elementHost1);
            this.panelHost.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHost.Location = new System.Drawing.Point(461, 122);
            this.panelHost.Name = "panelHost";
            this.panelHost.Size = new System.Drawing.Size(464, 371);
            this.panelHost.TabIndex = 2;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(464, 371);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // tabControlSchedule
            // 
            this.tabControlSchedule.Controls.Add(this.tabPageSchedule);
            this.tabControlSchedule.Controls.Add(this.tabPageSerialSchedule);
            this.tabControlSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSchedule.Location = new System.Drawing.Point(0, 0);
            this.tabControlSchedule.Name = "tabControlSchedule";
            this.tabControlSchedule.SelectedIndex = 0;
            this.tabControlSchedule.Size = new System.Drawing.Size(461, 371);
            this.tabControlSchedule.TabIndex = 1;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.dtgvSchedule);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 27);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(453, 340);
            this.tabPageSchedule.TabIndex = 0;
            this.tabPageSchedule.Text = "Schedule";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // tabPageSerialSchedule
            // 
            this.tabPageSerialSchedule.Controls.Add(this.dtgvSerialSchedule);
            this.tabPageSerialSchedule.Location = new System.Drawing.Point(4, 27);
            this.tabPageSerialSchedule.Name = "tabPageSerialSchedule";
            this.tabPageSerialSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialSchedule.Size = new System.Drawing.Size(453, 340);
            this.tabPageSerialSchedule.TabIndex = 1;
            this.tabPageSerialSchedule.Text = "Serial Schedule";
            this.tabPageSerialSchedule.UseVisualStyleBackColor = true;
            // 
            // dtgvSerialSchedule
            // 
            this.dtgvSerialSchedule.AllowUserToAddRows = false;
            this.dtgvSerialSchedule.AllowUserToDeleteRows = false;
            this.dtgvSerialSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSerialSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSerialSchedule.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgvSerialSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSerialSchedule.Location = new System.Drawing.Point(3, 3);
            this.dtgvSerialSchedule.Name = "dtgvSerialSchedule";
            this.dtgvSerialSchedule.ReadOnly = true;
            this.dtgvSerialSchedule.RowHeadersVisible = false;
            this.dtgvSerialSchedule.Size = new System.Drawing.Size(447, 334);
            this.dtgvSerialSchedule.TabIndex = 0;
            // 
            // dtgvSchedule
            // 
            this.dtgvSchedule.AllowUserToAddRows = false;
            this.dtgvSchedule.AllowUserToDeleteRows = false;
            this.dtgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSchedule.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvSchedule.Location = new System.Drawing.Point(3, 3);
            this.dtgvSchedule.Name = "dtgvSchedule";
            this.dtgvSchedule.ReadOnly = true;
            this.dtgvSchedule.RowHeadersVisible = false;
            this.dtgvSchedule.Size = new System.Drawing.Size(447, 334);
            this.dtgvSchedule.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 493);
            this.Controls.Add(this.panelDTGV);
            this.Controls.Add(this.panelHost);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelDTGV.ResumeLayout(false);
            this.panelHost.ResumeLayout(false);
            this.tabControlSchedule.ResumeLayout(false);
            this.tabPageSchedule.ResumeLayout(false);
            this.tabPageSerialSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSerialSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.HelpButton = true;

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panelDTGV;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label txtSSResult;
        private System.Windows.Forms.Label txtSerialSchedule;
        private System.Windows.Forms.Panel panelHost;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.TabControl tabControlSchedule;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.DataGridView dtgvSchedule;
        private System.Windows.Forms.TabPage tabPageSerialSchedule;
        private System.Windows.Forms.DataGridView dtgvSerialSchedule;
    }
}

