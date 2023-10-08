namespace ADOExam
{
    partial class MainFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormAdmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.buttonShowDB = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.examDataSet1 = new ADOExam.ExamDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT * FROM Items";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Items] ([ItemName], [ItemPrice]) VALUES (@ItemName, @ItemPrice);\r\nSE" +
    "LECT ItemID, ItemName, ItemPrice FROM Items WHERE (ItemID = SCOPE_IDENTITY())";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ItemName", System.Data.SqlDbType.NVarChar, 0, "ItemName"),
            new System.Data.SqlClient.SqlParameter("@ItemPrice", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(2)), "ItemPrice", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ItemName", System.Data.SqlDbType.NVarChar, 0, "ItemName"),
            new System.Data.SqlClient.SqlParameter("@ItemPrice", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(2)), "ItemPrice", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@Original_ItemID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ItemID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ItemName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ItemName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ItemPrice", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(2)), "ItemPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@ItemID", System.Data.SqlDbType.Int, 4, "ItemID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Items] WHERE (([ItemID] = @Original_ItemID) AND ([ItemName] = @Origi" +
    "nal_ItemName) AND ([ItemPrice] = @Original_ItemPrice))";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ItemID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ItemID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ItemName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ItemName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ItemPrice", System.Data.SqlDbType.Decimal, 0, System.Data.ParameterDirection.Input, false, ((byte)(8)), ((byte)(2)), "ItemPrice", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Items", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ItemID", "ItemID"),
                        new System.Data.Common.DataColumnMapping("ItemName", "ItemName"),
                        new System.Data.Common.DataColumnMapping("ItemPrice", "ItemPrice")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-U9JF46C;Initial Catalog=ADOExamDB;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // buttonShowDB
            // 
            this.buttonShowDB.Location = new System.Drawing.Point(13, 13);
            this.buttonShowDB.Name = "buttonShowDB";
            this.buttonShowDB.Size = new System.Drawing.Size(166, 23);
            this.buttonShowDB.TabIndex = 1;
            this.buttonShowDB.Text = "Показать БД";
            this.buttonShowDB.UseVisualStyleBackColor = true;
            this.buttonShowDB.Click += new System.EventHandler(this.buttonShowDB_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(429, 13);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(173, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Внести изменения";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(608, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(180, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить строку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // examDataSet1
            // 
            this.examDataSet1.DataSetName = "ExamDataSet";
            this.examDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonShowDB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainFormAdmin";
            this.Text = "MainFormAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Button buttonShowDB;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private ExamDataSet examDataSet1;
    }
}