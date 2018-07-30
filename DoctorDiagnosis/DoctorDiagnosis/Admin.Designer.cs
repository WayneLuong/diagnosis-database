namespace DoctorDiagnosis
{
    partial class Admin
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
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.symptomsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.symptomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisDataSet1 = new DoctorDiagnosis.DiagnosisDataSet1();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.symptomsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.symptomsTableAdapter = new DoctorDiagnosis.DiagnosisDataSet1TableAdapters.SymptomsTableAdapter();
            this.tableAdapterManager = new DoctorDiagnosis.DiagnosisDataSet1TableAdapters.TableAdapterManager();
            this.searchDiagnosisToolStrip = new System.Windows.Forms.ToolStrip();
            this.diagnosisToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.diagnosisToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchDiagnosisToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomsDataGridView = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.statuslbl = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.symptomsTxt = new System.Windows.Forms.TextBox();
            genderLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingNavigator)).BeginInit();
            this.symptomsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisDataSet1)).BeginInit();
            this.searchDiagnosisToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(48, 259);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(67, 20);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(48, 222);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(48, 185);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(83, 20);
            diagnosisLabel.TabIndex = 3;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(48, 148);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // symptomsBindingNavigator
            // 
            this.symptomsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.symptomsBindingNavigator.BindingSource = this.symptomsBindingSource;
            this.symptomsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.symptomsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.symptomsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.symptomsBindingNavigatorSaveItem});
            this.symptomsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.symptomsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.symptomsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.symptomsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.symptomsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.symptomsBindingNavigator.Name = "symptomsBindingNavigator";
            this.symptomsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.symptomsBindingNavigator.Size = new System.Drawing.Size(1277, 31);
            this.symptomsBindingNavigator.TabIndex = 0;
            this.symptomsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // symptomsBindingSource
            // 
            this.symptomsBindingSource.DataMember = "Symptoms";
            this.symptomsBindingSource.DataSource = this.diagnosisDataSet1;
            // 
            // diagnosisDataSet1
            // 
            this.diagnosisDataSet1.DataSetName = "DiagnosisDataSet1";
            this.diagnosisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // symptomsBindingNavigatorSaveItem
            // 
            this.symptomsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.symptomsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("symptomsBindingNavigatorSaveItem.Image")));
            this.symptomsBindingNavigatorSaveItem.Name = "symptomsBindingNavigatorSaveItem";
            this.symptomsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 28);
            this.symptomsBindingNavigatorSaveItem.Text = "Save Data";
            this.symptomsBindingNavigatorSaveItem.Click += new System.EventHandler(this.symptomsBindingNavigatorSaveItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // symptomsTableAdapter
            // 
            this.symptomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SymptomsTableAdapter = this.symptomsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DoctorDiagnosis.DiagnosisDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // searchDiagnosisToolStrip
            // 
            this.searchDiagnosisToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosisToolStripLabel,
            this.diagnosisToolStripTextBox,
            this.searchDiagnosisToolStripButton});
            this.searchDiagnosisToolStrip.Location = new System.Drawing.Point(0, 31);
            this.searchDiagnosisToolStrip.Name = "searchDiagnosisToolStrip";
            this.searchDiagnosisToolStrip.Size = new System.Drawing.Size(1277, 32);
            this.searchDiagnosisToolStrip.TabIndex = 21;
            this.searchDiagnosisToolStrip.Text = "searchDiagnosisToolStrip";
            // 
            // diagnosisToolStripLabel
            // 
            this.diagnosisToolStripLabel.Name = "diagnosisToolStripLabel";
            this.diagnosisToolStripLabel.Size = new System.Drawing.Size(94, 29);
            this.diagnosisToolStripLabel.Text = "Diagnosis:";
            // 
            // diagnosisToolStripTextBox
            // 
            this.diagnosisToolStripTextBox.Name = "diagnosisToolStripTextBox";
            this.diagnosisToolStripTextBox.Size = new System.Drawing.Size(100, 32);
            // 
            // searchDiagnosisToolStripButton
            // 
            this.searchDiagnosisToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchDiagnosisToolStripButton.Name = "searchDiagnosisToolStripButton";
            this.searchDiagnosisToolStripButton.Size = new System.Drawing.Size(144, 29);
            this.searchDiagnosisToolStripButton.Text = "searchDiagnosis";
            this.searchDiagnosisToolStripButton.Click += new System.EventHandler(this.searchDiagnosisToolStripButton_Click);
            // 
            // genderTextBox
            // 
            this.genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.symptomsBindingSource, "Gender", true));
            this.genderTextBox.Location = new System.Drawing.Point(147, 256);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(177, 26);
            this.genderTextBox.TabIndex = 8;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.symptomsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(147, 219);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(177, 26);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.symptomsBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(147, 182);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(177, 26);
            this.diagnosisTextBox.TabIndex = 4;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.symptomsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(147, 145);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(177, 26);
            this.iDTextBox.TabIndex = 2;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // symptomsDataGridView
            // 
            this.symptomsDataGridView.AutoGenerateColumns = false;
            this.symptomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.symptomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.symptomsDataGridView.DataSource = this.symptomsBindingSource;
            this.symptomsDataGridView.Location = new System.Drawing.Point(368, 145);
            this.symptomsDataGridView.Name = "symptomsDataGridView";
            this.symptomsDataGridView.RowTemplate.Height = 28;
            this.symptomsDataGridView.Size = new System.Drawing.Size(801, 374);
            this.symptomsDataGridView.TabIndex = 9;
            this.symptomsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.symptomsDataGridView_CellContentClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(53, 396);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(123, 33);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(52, 338);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(124, 33);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add New";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(52, 457);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(123, 33);
            this.removeBtn.TabIndex = 12;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslbl.Location = new System.Drawing.Point(46, 564);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(102, 32);
            this.statuslbl.TabIndex = 13;
            this.statuslbl.Text = "Status";
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(201, 338);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(123, 33);
            this.nextBtn.TabIndex = 14;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(201, 396);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(123, 33);
            this.previousBtn.TabIndex = 15;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(993, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 33);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search Symptoms";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // symptomsTxt
            // 
            this.symptomsTxt.Location = new System.Drawing.Point(716, 98);
            this.symptomsTxt.Name = "symptomsTxt";
            this.symptomsTxt.Size = new System.Drawing.Size(257, 26);
            this.symptomsTxt.TabIndex = 19;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 737);
            this.Controls.Add(this.searchDiagnosisToolStrip);
            this.Controls.Add(this.symptomsTxt);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.symptomsDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(diagnosisLabel);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.symptomsBindingNavigator);
            this.Name = "Admin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingNavigator)).EndInit();
            this.symptomsBindingNavigator.ResumeLayout(false);
            this.symptomsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosisDataSet1)).EndInit();
            this.searchDiagnosisToolStrip.ResumeLayout(false);
            this.searchDiagnosisToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.symptomsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DiagnosisDataSet1 diagnosisDataSet1;
        private System.Windows.Forms.BindingSource symptomsBindingSource;
        private DiagnosisDataSet1TableAdapters.SymptomsTableAdapter symptomsTableAdapter;
        private DiagnosisDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator symptomsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton symptomsBindingNavigatorSaveItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip searchDiagnosisToolStrip;
        private System.Windows.Forms.ToolStripLabel diagnosisToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox diagnosisToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchDiagnosisToolStripButton;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView symptomsDataGridView;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox symptomsTxt;
    }
}

