namespace Library.Forms
{
    partial class ReturnsForm
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
            this.labelOverallCost = new System.Windows.Forms.Label();
            this.TBOverall = new System.Windows.Forms.TextBox();
            this.TbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnPay = new System.Windows.Forms.Button();
            this.DgvMyPurchaes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMyPurchaes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOverallCost
            // 
            this.labelOverallCost.AutoSize = true;
            this.labelOverallCost.Location = new System.Drawing.Point(676, 298);
            this.labelOverallCost.Name = "labelOverallCost";
            this.labelOverallCost.Size = new System.Drawing.Size(89, 17);
            this.labelOverallCost.TabIndex = 15;
            this.labelOverallCost.Text = "Overall Cost:";
            // 
            // TBOverall
            // 
            this.TBOverall.Location = new System.Drawing.Point(666, 317);
            this.TBOverall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBOverall.Name = "TBOverall";
            this.TBOverall.Size = new System.Drawing.Size(137, 22);
            this.TBOverall.TabIndex = 14;
            // 
            // TbPrice
            // 
            this.TbPrice.Location = new System.Drawing.Point(137, 369);
            this.TbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbPrice.Name = "TbPrice";
            this.TbPrice.Size = new System.Drawing.Size(137, 22);
            this.TbPrice.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Your Cost:";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(137, 409);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(88, 39);
            this.BtnConfirm.TabIndex = 11;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            // 
            // BtnPay
            // 
            this.BtnPay.BackColor = System.Drawing.Color.Green;
            this.BtnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPay.Location = new System.Drawing.Point(689, 352);
            this.BtnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPay.Name = "BtnPay";
            this.BtnPay.Size = new System.Drawing.Size(85, 39);
            this.BtnPay.TabIndex = 10;
            this.BtnPay.Text = "Sum Up";
            this.BtnPay.UseVisualStyleBackColor = false;
            // 
            // DgvMyPurchaes
            // 
            this.DgvMyPurchaes.AllowUserToAddRows = false;
            this.DgvMyPurchaes.AllowUserToDeleteRows = false;
            this.DgvMyPurchaes.AllowUserToResizeColumns = false;
            this.DgvMyPurchaes.AllowUserToResizeRows = false;
            this.DgvMyPurchaes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMyPurchaes.BackgroundColor = System.Drawing.Color.Bisque;
            this.DgvMyPurchaes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMyPurchaes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DgvMyPurchaes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DgvMyPurchaes.Location = new System.Drawing.Point(137, 129);
            this.DgvMyPurchaes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvMyPurchaes.Name = "DgvMyPurchaes";
            this.DgvMyPurchaes.RowHeadersWidth = 51;
            this.DgvMyPurchaes.RowTemplate.Height = 24;
            this.DgvMyPurchaes.Size = new System.Drawing.Size(776, 150);
            this.DgvMyPurchaes.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Order No";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Return Date";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReturnsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelOverallCost);
            this.Controls.Add(this.TBOverall);
            this.Controls.Add(this.TbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnPay);
            this.Controls.Add(this.DgvMyPurchaes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnsForm";
            this.Text = "Returns";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMyPurchaes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOverallCost;
        private System.Windows.Forms.TextBox TBOverall;
        private System.Windows.Forms.TextBox TbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnPay;
        private System.Windows.Forms.DataGridView DgvMyPurchaes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}