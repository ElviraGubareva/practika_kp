namespace _30_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.туристыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTur_firmDataSet2 = new _30_1.DBTur_firmDataSet2();
            this.туристыTableAdapter = new _30_1.DBTur_firmDataSet2TableAdapters.ТуристыTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.турыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTur_firmDataSet1 = new _30_1.DBTur_firmDataSet1();
            this.туристыTableAdapter1 = new _30_1.DBTur_firmDataSet2TableAdapters.ТуристыTableAdapter();
            this.турыTableAdapter = new _30_1.DBTur_firmDataSet1TableAdapters.ТурыTableAdapter();
            this.dBTurfirmDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.турыTableAdapter1 = new _30_1.DBTur_firmDataSet1TableAdapters.ТурыTableAdapter();
            this.dbDataSet = new _30_1.dbDataSet();
            this.турыTableAdapter2 = new _30_1.dbDataSetTableAdapters.ТурыTableAdapter();
            this.tableAdapterManager = new _30_1.dbDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Код_тура = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Информация = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Код_туриста = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.туристыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTur_firmDataSet2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTur_firmDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTurfirmDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // туристыBindingSource
            // 
            this.туристыBindingSource.DataMember = "Туристы";
            this.туристыBindingSource.DataSource = this.dBTur_firmDataSet2;
            // 
            // dBTur_firmDataSet2
            // 
            this.dBTur_firmDataSet2.DataSetName = "DBTur_firmDataSet2";
            this.dBTur_firmDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // туристыTableAdapter
            // 
            this.туристыTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(132, 22);
            this.toolStripLabel1.Text = "Добавить туриста";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel2.Text = "Удалить тур";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(134, 22);
            this.toolStripLabel3.Text = "Изменить туриста";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // турыBindingSource
            // 
            this.турыBindingSource.DataMember = "Туры";
            this.турыBindingSource.DataSource = this.dBTur_firmDataSet1;
            // 
            // dBTur_firmDataSet1
            // 
            this.dBTur_firmDataSet1.DataSetName = "DBTur_firmDataSet1";
            this.dBTur_firmDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // туристыTableAdapter1
            // 
            this.туристыTableAdapter1.ClearBeforeFill = true;
            // 
            // турыTableAdapter
            // 
            this.турыTableAdapter.ClearBeforeFill = true;
            // 
            // dBTurfirmDataSet1BindingSource
            // 
            this.dBTurfirmDataSet1BindingSource.DataSource = this.dBTur_firmDataSet1;
            this.dBTurfirmDataSet1BindingSource.Position = 0;
            // 
            // турыTableAdapter1
            // 
            this.турыTableAdapter1.ClearBeforeFill = true;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // турыTableAdapter2
            // 
            this.турыTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = _30_1.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ТуристыTableAdapter = null;
            this.tableAdapterManager.ТурыTableAdapter = this.турыTableAdapter2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_тура,
            this.Название,
            this.Цена,
            this.Информация});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 225);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Код_тура
            // 
            this.Код_тура.HeaderText = "Код_тура";
            this.Код_тура.MinimumWidth = 6;
            this.Код_тура.Name = "Код_тура";
            this.Код_тура.Width = 125;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.MinimumWidth = 6;
            this.Название.Name = "Название";
            this.Название.Width = 125;
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.MinimumWidth = 6;
            this.Цена.Name = "Цена";
            this.Цена.Width = 125;
            // 
            // Информация
            // 
            this.Информация.HeaderText = "Информация";
            this.Информация.MinimumWidth = 6;
            this.Информация.Name = "Информация";
            this.Информация.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_туриста,
            this.Имя,
            this.Фамилия,
            this.Отчество});
            this.dataGridView2.Location = new System.Drawing.Point(0, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(629, 260);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Код_туриста
            // 
            this.Код_туриста.HeaderText = "Код_туриста";
            this.Код_туриста.MinimumWidth = 6;
            this.Код_туриста.Name = "Код_туриста";
            this.Код_туриста.Width = 125;
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.MinimumWidth = 6;
            this.Имя.Name = "Имя";
            this.Имя.Width = 125;
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.MinimumWidth = 6;
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Width = 125;
            // 
            // Отчество
            // 
            this.Отчество.HeaderText = "Отчество";
            this.Отчество.MinimumWidth = 6;
            this.Отчество.Name = "Отчество";
            this.Отчество.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 553);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.туристыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTur_firmDataSet2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.турыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTur_firmDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTurfirmDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DBTur_firmDataSet1 dBTur_firmDataSet1;
        private System.Windows.Forms.BindingSource турыBindingSource;
        private DBTur_firmDataSet1TableAdapters.ТурыTableAdapter турыTableAdapter;
        private DBTur_firmDataSet2 dBTur_firmDataSet2;
        private System.Windows.Forms.BindingSource туристыBindingSource;
        private DBTur_firmDataSet2TableAdapters.ТуристыTableAdapter туристыTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.BindingSource dBTurfirmDataSet1BindingSource;
        private DBTur_firmDataSet1TableAdapters.ТурыTableAdapter турыTableAdapter1;
        private DBTur_firmDataSet2TableAdapters.ТуристыTableAdapter туристыTableAdapter1;
        private dbDataSet dbDataSet;
        private dbDataSetTableAdapters.ТурыTableAdapter турыTableAdapter2;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_тура;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Информация;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_туриста;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отчество;
    }
}

