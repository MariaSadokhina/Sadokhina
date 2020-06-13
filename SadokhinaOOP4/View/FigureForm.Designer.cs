namespace View
{
    partial class FigureForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddFigure = new System.Windows.Forms.Button();
            this.buttonRemoveFigure = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewType = new System.Windows.Forms.ListView();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure List";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 21);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonAddFigure
            // 
            this.buttonAddFigure.Location = new System.Drawing.Point(18, 222);
            this.buttonAddFigure.Name = "buttonAddFigure";
            this.buttonAddFigure.Size = new System.Drawing.Size(119, 33);
            this.buttonAddFigure.TabIndex = 1;
            this.buttonAddFigure.Text = "Add Figure";
            this.buttonAddFigure.UseVisualStyleBackColor = true;
            this.buttonAddFigure.Click += new System.EventHandler(this.ButtonAddFigure_Click);
            // 
            // buttonRemoveFigure
            // 
            this.buttonRemoveFigure.Location = new System.Drawing.Point(156, 222);
            this.buttonRemoveFigure.Name = "buttonRemoveFigure";
            this.buttonRemoveFigure.Size = new System.Drawing.Size(119, 33);
            this.buttonRemoveFigure.TabIndex = 2;
            this.buttonRemoveFigure.Text = "Remove Figure";
            this.buttonRemoveFigure.UseVisualStyleBackColor = true;
            this.buttonRemoveFigure.Click += new System.EventHandler(this.ButtonRemoveFigure_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewType);
            this.groupBox2.Location = new System.Drawing.Point(336, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 191);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Figure";
            // 
            // listViewType
            // 
            this.listViewType.HideSelection = false;
            this.listViewType.Location = new System.Drawing.Point(17, 22);
            this.listViewType.Name = "listViewType";
            this.listViewType.Size = new System.Drawing.Size(177, 148);
            this.listViewType.TabIndex = 0;
            this.listViewType.UseCompatibleStateImageBehavior = false;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(18, 271);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(119, 32);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(336, 222);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 33);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(336, 271);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(119, 32);
            this.buttonDownload.TabIndex = 6;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // FigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 315);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRemoveFigure);
            this.Controls.Add(this.buttonAddFigure);
            this.Controls.Add(this.groupBox1);
            this.Name = "FigureForm";
            this.Text = "FigureForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAddFigure;
        private System.Windows.Forms.Button buttonRemoveFigure;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewType;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDownload;
    }
}

