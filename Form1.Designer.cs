namespace ContractReadingToolApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            lblOriginal = new Label();
            txtOriginalContractSum = new TextBox();
            txtNetChangeByChangeOrders = new TextBox();
            lblNetChange = new Label();
            txtRevisedContractSumActual = new TextBox();
            lblRevisedActual = new Label();
            txtNewTotalChangeOrders = new TextBox();
            lblTotalCOs = new Label();
            txtInvoicesERP = new TextBox();
            lblInvoicesERP = new Label();
            txtRevisedContractSumCalculated = new TextBox();
            lblRevisedCalc = new Label();
            txtDifferencesCalculated = new TextBox();
            lblDifference = new Label();
            txtInvoicesAdjustCalculated = new TextBox();
            lblToAdjust = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 21);
            label1.TabIndex = 0;
            label1.Text = "Commitments Contract Reading Tool";
            // 
            // lblOriginal
            // 
            lblOriginal.AutoSize = true;
            lblOriginal.Location = new Point(36, 54);
            lblOriginal.Name = "lblOriginal";
            lblOriginal.Size = new Size(125, 15);
            lblOriginal.TabIndex = 1;
            lblOriginal.Text = "Original Contract Sum";
            // 
            // txtOriginalContractSum
            // 
            txtOriginalContractSum.BackColor = Color.Yellow;
            txtOriginalContractSum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOriginalContractSum.Location = new Point(36, 72);
            txtOriginalContractSum.Name = "txtOriginalContractSum";
            txtOriginalContractSum.Size = new Size(132, 23);
            txtOriginalContractSum.TabIndex = 1;
            // 
            // txtNetChangeByChangeOrders
            // 
            txtNetChangeByChangeOrders.BackColor = Color.Yellow;
            txtNetChangeByChangeOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNetChangeByChangeOrders.Location = new Point(36, 139);
            txtNetChangeByChangeOrders.Name = "txtNetChangeByChangeOrders";
            txtNetChangeByChangeOrders.Size = new Size(132, 23);
            txtNetChangeByChangeOrders.TabIndex = 2;
            // 
            // lblNetChange
            // 
            lblNetChange.AutoSize = true;
            lblNetChange.Location = new Point(36, 121);
            lblNetChange.Name = "lblNetChange";
            lblNetChange.Size = new Size(168, 15);
            lblNetChange.TabIndex = 3;
            lblNetChange.Text = "Net Change By Change Orders";
            // 
            // txtRevisedContractSumActual
            // 
            txtRevisedContractSumActual.BackColor = Color.Yellow;
            txtRevisedContractSumActual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRevisedContractSumActual.Location = new Point(36, 210);
            txtRevisedContractSumActual.Name = "txtRevisedContractSumActual";
            txtRevisedContractSumActual.Size = new Size(132, 23);
            txtRevisedContractSumActual.TabIndex = 3;
            // 
            // lblRevisedActual
            // 
            lblRevisedActual.AutoSize = true;
            lblRevisedActual.Location = new Point(36, 192);
            lblRevisedActual.Name = "lblRevisedActual";
            lblRevisedActual.Size = new Size(168, 15);
            lblRevisedActual.TabIndex = 5;
            lblRevisedActual.Text = "Revised Contract Sum (Actual)";
            // 
            // txtNewTotalChangeOrders
            // 
            txtNewTotalChangeOrders.BackColor = Color.Yellow;
            txtNewTotalChangeOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNewTotalChangeOrders.Location = new Point(36, 278);
            txtNewTotalChangeOrders.Name = "txtNewTotalChangeOrders";
            txtNewTotalChangeOrders.Size = new Size(132, 23);
            txtNewTotalChangeOrders.TabIndex = 4;
            // 
            // lblTotalCOs
            // 
            lblTotalCOs.AutoSize = true;
            lblTotalCOs.Location = new Point(36, 260);
            lblTotalCOs.Name = "lblTotalCOs";
            lblTotalCOs.Size = new Size(142, 15);
            lblTotalCOs.TabIndex = 7;
            lblTotalCOs.Text = "New Total Change Orders";
            // 
            // txtInvoicesERP
            // 
            txtInvoicesERP.BackColor = Color.Yellow;
            txtInvoicesERP.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInvoicesERP.Location = new Point(36, 349);
            txtInvoicesERP.Name = "txtInvoicesERP";
            txtInvoicesERP.Size = new Size(132, 23);
            txtInvoicesERP.TabIndex = 5;
            // 
            // lblInvoicesERP
            // 
            lblInvoicesERP.AutoSize = true;
            lblInvoicesERP.Location = new Point(36, 331);
            lblInvoicesERP.Name = "lblInvoicesERP";
            lblInvoicesERP.Size = new Size(179, 15);
            lblInvoicesERP.TabIndex = 9;
            lblInvoicesERP.Text = "Invoices ERP (Pending/Not Paid)";
            // 
            // txtRevisedContractSumCalculated
            // 
            txtRevisedContractSumCalculated.BackColor = Color.Lime;
            txtRevisedContractSumCalculated.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRevisedContractSumCalculated.Location = new Point(348, 139);
            txtRevisedContractSumCalculated.Name = "txtRevisedContractSumCalculated";
            txtRevisedContractSumCalculated.ReadOnly = true;
            txtRevisedContractSumCalculated.Size = new Size(157, 23);
            txtRevisedContractSumCalculated.TabIndex = 12;
            // 
            // lblRevisedCalc
            // 
            lblRevisedCalc.AutoSize = true;
            lblRevisedCalc.Location = new Point(348, 121);
            lblRevisedCalc.Name = "lblRevisedCalc";
            lblRevisedCalc.Size = new Size(190, 15);
            lblRevisedCalc.TabIndex = 11;
            lblRevisedCalc.Text = "Revised Contract Sum (Calculated)";
            // 
            // txtDifferencesCalculated
            // 
            txtDifferencesCalculated.BackColor = Color.FromArgb(255, 128, 128);
            txtDifferencesCalculated.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDifferencesCalculated.Location = new Point(348, 206);
            txtDifferencesCalculated.Name = "txtDifferencesCalculated";
            txtDifferencesCalculated.ReadOnly = true;
            txtDifferencesCalculated.Size = new Size(157, 23);
            txtDifferencesCalculated.TabIndex = 14;
            // 
            // lblDifference
            // 
            lblDifference.AutoSize = true;
            lblDifference.Location = new Point(348, 188);
            lblDifference.Name = "lblDifference";
            lblDifference.Size = new Size(133, 15);
            lblDifference.TabIndex = 13;
            lblDifference.Text = "Differences (Calculated)";
            // 
            // txtInvoicesAdjustCalculated
            // 
            txtInvoicesAdjustCalculated.BackColor = Color.Lime;
            txtInvoicesAdjustCalculated.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtInvoicesAdjustCalculated.Location = new Point(348, 277);
            txtInvoicesAdjustCalculated.Name = "txtInvoicesAdjustCalculated";
            txtInvoicesAdjustCalculated.ReadOnly = true;
            txtInvoicesAdjustCalculated.Size = new Size(157, 23);
            txtInvoicesAdjustCalculated.TabIndex = 16;
            // 
            // lblToAdjust
            // 
            lblToAdjust.AutoSize = true;
            lblToAdjust.Location = new Point(348, 259);
            lblToAdjust.Name = "lblToAdjust";
            lblToAdjust.Size = new Size(202, 15);
            lblToAdjust.TabIndex = 15;
            lblToAdjust.Text = "Invoice to Adjust/Create (Calculated)";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(454, 357);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(105, 32);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(571, 401);
            Controls.Add(btnReset);
            Controls.Add(txtInvoicesAdjustCalculated);
            Controls.Add(lblToAdjust);
            Controls.Add(txtDifferencesCalculated);
            Controls.Add(lblDifference);
            Controls.Add(txtRevisedContractSumCalculated);
            Controls.Add(lblRevisedCalc);
            Controls.Add(txtInvoicesERP);
            Controls.Add(lblInvoicesERP);
            Controls.Add(txtNewTotalChangeOrders);
            Controls.Add(lblTotalCOs);
            Controls.Add(txtRevisedContractSumActual);
            Controls.Add(lblRevisedActual);
            Controls.Add(txtNetChangeByChangeOrders);
            Controls.Add(lblNetChange);
            Controls.Add(txtOriginalContractSum);
            Controls.Add(lblOriginal);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Contract Reading Tool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOriginal;
        private TextBox txtOriginalContractSum;
        private TextBox txtNetChangeByChangeOrders;
        private Label lblNetChange;
        private TextBox txtRevisedContractSumActual;
        private Label lblRevisedActual;
        private TextBox txtNewTotalChangeOrders;
        private Label lblTotalCOs;
        private TextBox txtInvoicesERP;
        private Label lblInvoicesERP;
        private TextBox txtRevisedContractSumCalculated;
        private Label lblRevisedCalc;
        private TextBox txtDifferencesCalculated;
        private Label lblDifference;
        private TextBox txtInvoicesAdjustCalculated;
        private Label lblToAdjust;
        private Button btnReset;
    }
}
