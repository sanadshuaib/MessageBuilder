namespace MessageBuilder
{
    partial class frmMain
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
            this.lblMessageCode = new System.Windows.Forms.Label();
            this.lblMessageTitle = new System.Windows.Forms.Label();
            this.lblMessageBody = new System.Windows.Forms.Label();
            this.lblMessageType = new System.Windows.Forms.Label();
            this.txtMessageCode = new System.Windows.Forms.TextBox();
            this.txtMessageTitle = new System.Windows.Forms.TextBox();
            this.txtMessageBody = new System.Windows.Forms.TextBox();
            this.cboMessageType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgMessages = new System.Windows.Forms.DataGridView();
            this.lblHead1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblHead2 = new System.Windows.Forms.Label();
            this.messageHandlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messageCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageBodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageHandlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessageCode
            // 
            this.lblMessageCode.AutoSize = true;
            this.lblMessageCode.Location = new System.Drawing.Point(43, 47);
            this.lblMessageCode.Name = "lblMessageCode";
            this.lblMessageCode.Size = new System.Drawing.Size(77, 13);
            this.lblMessageCode.TabIndex = 0;
            this.lblMessageCode.Text = "Message Code";
            // 
            // lblMessageTitle
            // 
            this.lblMessageTitle.AutoSize = true;
            this.lblMessageTitle.Location = new System.Drawing.Point(43, 79);
            this.lblMessageTitle.Name = "lblMessageTitle";
            this.lblMessageTitle.Size = new System.Drawing.Size(72, 13);
            this.lblMessageTitle.TabIndex = 1;
            this.lblMessageTitle.Text = "Message Title";
            // 
            // lblMessageBody
            // 
            this.lblMessageBody.AutoSize = true;
            this.lblMessageBody.Location = new System.Drawing.Point(43, 111);
            this.lblMessageBody.Name = "lblMessageBody";
            this.lblMessageBody.Size = new System.Drawing.Size(76, 13);
            this.lblMessageBody.TabIndex = 2;
            this.lblMessageBody.Text = "Message Body";
            // 
            // lblMessageType
            // 
            this.lblMessageType.AutoSize = true;
            this.lblMessageType.Location = new System.Drawing.Point(43, 143);
            this.lblMessageType.Name = "lblMessageType";
            this.lblMessageType.Size = new System.Drawing.Size(76, 13);
            this.lblMessageType.TabIndex = 3;
            this.lblMessageType.Text = "Message Type";
            // 
            // txtMessageCode
            // 
            this.txtMessageCode.Location = new System.Drawing.Point(127, 44);
            this.txtMessageCode.Name = "txtMessageCode";
            this.txtMessageCode.Size = new System.Drawing.Size(164, 20);
            this.txtMessageCode.TabIndex = 4;
            // 
            // txtMessageTitle
            // 
            this.txtMessageTitle.Location = new System.Drawing.Point(127, 75);
            this.txtMessageTitle.Name = "txtMessageTitle";
            this.txtMessageTitle.Size = new System.Drawing.Size(164, 20);
            this.txtMessageTitle.TabIndex = 5;
            // 
            // txtMessageBody
            // 
            this.txtMessageBody.Location = new System.Drawing.Point(127, 106);
            this.txtMessageBody.Name = "txtMessageBody";
            this.txtMessageBody.Size = new System.Drawing.Size(164, 20);
            this.txtMessageBody.TabIndex = 6;
            // 
            // cboMessageType
            // 
            this.cboMessageType.FormattingEnabled = true;
            this.cboMessageType.Location = new System.Drawing.Point(127, 137);
            this.cboMessageType.Name = "cboMessageType";
            this.cboMessageType.Size = new System.Drawing.Size(164, 21);
            this.cboMessageType.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(216, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // dgMessages
            // 
            this.dgMessages.AutoGenerateColumns = false;
            this.dgMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.messageCodeDataGridViewTextBoxColumn,
            this.messageTitleDataGridViewTextBoxColumn,
            this.messageBodyDataGridViewTextBoxColumn,
            this.messageTypeDataGridViewTextBoxColumn});
            this.dgMessages.DataSource = this.messageHandlerBindingSource;
            this.dgMessages.Location = new System.Drawing.Point(297, 41);
            this.dgMessages.Name = "dgMessages";
            this.dgMessages.Size = new System.Drawing.Size(467, 163);
            this.dgMessages.TabIndex = 10;
            // 
            // lblHead1
            // 
            this.lblHead1.AutoSize = true;
            this.lblHead1.Location = new System.Drawing.Point(43, 17);
            this.lblHead1.Name = "lblHead1";
            this.lblHead1.Size = new System.Drawing.Size(313, 13);
            this.lblHead1.TabIndex = 11;
            this.lblHead1.Text = "Enter the message details as shown below and then click \"Save\"";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(680, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblHead2
            // 
            this.lblHead2.AutoSize = true;
            this.lblHead2.Location = new System.Drawing.Point(455, 17);
            this.lblHead2.Name = "lblHead2";
            this.lblHead2.Size = new System.Drawing.Size(219, 13);
            this.lblHead2.TabIndex = 13;
            this.lblHead2.Text = "Choose where to save your list of messages";
            // 
            // messageHandlerBindingSource
            // 
            this.messageHandlerBindingSource.DataSource = typeof(MessageBuilder.MessageHandler);
            // 
            // messageCodeDataGridViewTextBoxColumn
            // 
            this.messageCodeDataGridViewTextBoxColumn.DataPropertyName = "MessageCode";
            this.messageCodeDataGridViewTextBoxColumn.HeaderText = "MessageCode";
            this.messageCodeDataGridViewTextBoxColumn.Name = "messageCodeDataGridViewTextBoxColumn";
            // 
            // messageTitleDataGridViewTextBoxColumn
            // 
            this.messageTitleDataGridViewTextBoxColumn.DataPropertyName = "MessageTitle";
            this.messageTitleDataGridViewTextBoxColumn.HeaderText = "MessageTitle";
            this.messageTitleDataGridViewTextBoxColumn.Name = "messageTitleDataGridViewTextBoxColumn";
            // 
            // messageBodyDataGridViewTextBoxColumn
            // 
            this.messageBodyDataGridViewTextBoxColumn.DataPropertyName = "MessageBody";
            this.messageBodyDataGridViewTextBoxColumn.HeaderText = "MessageBody";
            this.messageBodyDataGridViewTextBoxColumn.Name = "messageBodyDataGridViewTextBoxColumn";
            // 
            // messageTypeDataGridViewTextBoxColumn
            // 
            this.messageTypeDataGridViewTextBoxColumn.DataPropertyName = "MessageType";
            this.messageTypeDataGridViewTextBoxColumn.HeaderText = "MessageType";
            this.messageTypeDataGridViewTextBoxColumn.Name = "messageTypeDataGridViewTextBoxColumn";
            this.messageTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.messageTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(426, 211);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAll.TabIndex = 14;
            this.btnSaveAll.Text = "Save all";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(643, 211);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(523, 211);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(776, 240);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.lblHead2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblHead1);
            this.Controls.Add(this.dgMessages);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboMessageType);
            this.Controls.Add(this.txtMessageBody);
            this.Controls.Add(this.txtMessageTitle);
            this.Controls.Add(this.txtMessageCode);
            this.Controls.Add(this.lblMessageType);
            this.Controls.Add(this.lblMessageBody);
            this.Controls.Add(this.lblMessageTitle);
            this.Controls.Add(this.lblMessageCode);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Builder";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageHandlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessageCode;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Label lblMessageBody;
        private System.Windows.Forms.Label lblMessageType;
        private System.Windows.Forms.TextBox txtMessageCode;
        private System.Windows.Forms.TextBox txtMessageTitle;
        private System.Windows.Forms.TextBox txtMessageBody;
        private System.Windows.Forms.ComboBox cboMessageType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgMessages;
        private System.Windows.Forms.Label lblHead1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblHead2;
        private System.Windows.Forms.BindingSource messageHandlerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageBodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn messageTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.FolderBrowserDialog browser;
    }
}

