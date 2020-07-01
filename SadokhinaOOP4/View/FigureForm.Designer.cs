﻿namespace View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FigureForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddFigure = new System.Windows.Forms.Button();
            this.buttonRemoveFigure = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewType = new System.Windows.Forms.ListView();
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
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(18, 271);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(257, 32);
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
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(336, 271);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(119, 32);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "circle.png");
            this.imageList1.Images.SetKeyName(1, "triangle.png");
            this.imageList1.Images.SetKeyName(2, "rectangle.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewType);
            this.groupBox2.Location = new System.Drawing.Point(336, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 191);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of Figure";
            // 
            // listViewType
            // 
            this.listViewType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewType.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewType.HideSelection = false;
            this.listViewType.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewType.Location = new System.Drawing.Point(12, 22);
            this.listViewType.MultiSelect = false;
            this.listViewType.Name = "listViewType";
            this.listViewType.Scrollable = false;
            this.listViewType.Size = new System.Drawing.Size(96, 148);
            this.listViewType.TabIndex = 0;
            this.listViewType.UseCompatibleStateImageBehavior = false;
            this.listViewType.View = System.Windows.Forms.View.Details;
            this.listViewType.SelectedIndexChanged += new System.EventHandler(this.listViewType_SelectedIndexChanged);
            // 
            // FigureForm
            // 
            this.AcceptButton = this.buttonRemoveFigure;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 313);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRemoveFigure);
            this.Controls.Add(this.buttonAddFigure);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

