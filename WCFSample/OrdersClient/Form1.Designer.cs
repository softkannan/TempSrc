namespace OrdersClient
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.customerDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.productDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.placeOrderButton = new System.Windows.Forms.Button();
      this.quantityTextBox = new System.Windows.Forms.TextBox();
      this.Label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // Label2
      // 
      this.Label2.AutoSize = true;
      this.Label2.Location = new System.Drawing.Point(29, 255);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(111, 17);
      this.Label2.TabIndex = 18;
      this.Label2.Text = "Select a product";
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Location = new System.Drawing.Point(29, 43);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(121, 17);
      this.Label1.TabIndex = 17;
      this.Label1.Text = "Select a customer";
      // 
      // customerDataGridView
      // 
      this.customerDataGridView.AllowUserToAddRows = false;
      this.customerDataGridView.AllowUserToDeleteRows = false;
      this.customerDataGridView.AutoGenerateColumns = false;
      this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
      this.customerDataGridView.DataSource = this.customerBindingSource;
      this.customerDataGridView.Location = new System.Drawing.Point(32, 78);
      this.customerDataGridView.Name = "customerDataGridView";
      this.customerDataGridView.ReadOnly = true;
      this.customerDataGridView.RowHeadersVisible = false;
      this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.customerDataGridView.Size = new System.Drawing.Size(323, 152);
      this.customerDataGridView.TabIndex = 19;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "CompanyName";
      this.dataGridViewTextBoxColumn3.HeaderText = "Customer";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 200;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Balance";
      dataGridViewCellStyle1.Format = "C";
      this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewTextBoxColumn2.HeaderText = "Balance";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      // 
      // customerBindingSource
      // 
      this.customerBindingSource.DataSource = typeof(OrdersClient.OrdersService.Customer);
      // 
      // productDataGridView
      // 
      this.productDataGridView.AllowUserToAddRows = false;
      this.productDataGridView.AllowUserToDeleteRows = false;
      this.productDataGridView.AutoGenerateColumns = false;
      this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5});
      this.productDataGridView.DataSource = this.productBindingSource;
      this.productDataGridView.Location = new System.Drawing.Point(32, 292);
      this.productDataGridView.Name = "productDataGridView";
      this.productDataGridView.ReadOnly = true;
      this.productDataGridView.RowHeadersVisible = false;
      this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.productDataGridView.Size = new System.Drawing.Size(320, 152);
      this.productDataGridView.TabIndex = 19;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductName";
      this.dataGridViewTextBoxColumn8.HeaderText = "Product";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "Price";
      dataGridViewCellStyle2.Format = "C";
      this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewTextBoxColumn6.HeaderText = "Price";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "OnHand";
      this.dataGridViewTextBoxColumn5.HeaderText = "On Hand";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      // 
      // productBindingSource
      // 
      this.productBindingSource.DataSource = typeof(OrdersClient.OrdersService.Product);
      // 
      // placeOrderButton
      // 
      this.placeOrderButton.Location = new System.Drawing.Point(190, 483);
      this.placeOrderButton.Name = "placeOrderButton";
      this.placeOrderButton.Size = new System.Drawing.Size(100, 39);
      this.placeOrderButton.TabIndex = 25;
      this.placeOrderButton.Text = "Place order";
      this.placeOrderButton.UseVisualStyleBackColor = true;
      this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
      // 
      // quantityTextBox
      // 
      this.quantityTextBox.Location = new System.Drawing.Point(112, 491);
      this.quantityTextBox.Name = "quantityTextBox";
      this.quantityTextBox.Size = new System.Drawing.Size(50, 23);
      this.quantityTextBox.TabIndex = 23;
      // 
      // Label4
      // 
      this.Label4.AutoSize = true;
      this.Label4.Location = new System.Drawing.Point(29, 494);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(61, 17);
      this.Label4.TabIndex = 29;
      this.Label4.Text = "Quantity";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 565);
      this.Controls.Add(this.placeOrderButton);
      this.Controls.Add(this.quantityTextBox);
      this.Controls.Add(this.Label4);
      this.Controls.Add(this.productDataGridView);
      this.Controls.Add(this.customerDataGridView);
      this.Controls.Add(this.Label2);
      this.Controls.Add(this.Label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Orders";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.Label Label1;
    private System.Windows.Forms.BindingSource customerBindingSource;
    private System.Windows.Forms.DataGridView customerDataGridView;
    private System.Windows.Forms.BindingSource productBindingSource;
    private System.Windows.Forms.DataGridView productDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    internal System.Windows.Forms.Button placeOrderButton;
    internal System.Windows.Forms.TextBox quantityTextBox;
    internal System.Windows.Forms.Label Label4;
  }
}

