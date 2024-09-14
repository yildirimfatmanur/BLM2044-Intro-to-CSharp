namespace Veritabani
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SELECT = new System.Windows.Forms.Button();
            this.INSERT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Order_id = new System.Windows.Forms.Label();
            this.Product_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(865, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // SELECT
            // 
            this.SELECT.Location = new System.Drawing.Point(931, 12);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(151, 47);
            this.SELECT.TabIndex = 1;
            this.SELECT.Text = "SELECT";
            this.SELECT.UseVisualStyleBackColor = true;
            this.SELECT.Click += new System.EventHandler(this.SELECT_Click);
            // 
            // INSERT
            // 
            this.INSERT.Location = new System.Drawing.Point(931, 84);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(151, 47);
            this.INSERT.TabIndex = 2;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(931, 151);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(151, 47);
            this.DELETE.TabIndex = 3;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.Location = new System.Drawing.Point(931, 218);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(151, 47);
            this.UPDATE.TabIndex = 4;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1027, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1027, 379);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 22);
            this.textBox2.TabIndex = 6;
            // 
            // Order_id
            // 
            this.Order_id.AutoSize = true;
            this.Order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Order_id.Location = new System.Drawing.Point(916, 319);
            this.Order_id.Name = "Order_id";
            this.Order_id.Size = new System.Drawing.Size(74, 20);
            this.Order_id.TabIndex = 7;
            this.Order_id.Text = "Order_id";
            // 
            // Product_id
            // 
            this.Product_id.AutoSize = true;
            this.Product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Product_id.Location = new System.Drawing.Point(916, 379);
            this.Product_id.Name = "Product_id";
            this.Product_id.Size = new System.Drawing.Size(89, 20);
            this.Product_id.TabIndex = 8;
            this.Product_id.Text = "Product_id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 450);
            this.Controls.Add(this.Product_id);
            this.Controls.Add(this.Order_id);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.INSERT);
            this.Controls.Add(this.SELECT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SELECT;
        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Order_id;
        private System.Windows.Forms.Label Product_id;
    }
}

