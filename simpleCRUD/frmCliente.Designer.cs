﻿
namespace simpleCRUD
{
    partial class frmCliente
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
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNames = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lNew = new MetroFramework.Controls.MetroLink();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.actions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabForm = new MetroFramework.Controls.MetroTabPage();
            this.txtMobile = new MetroFramework.Controls.MetroTextBox();
            this.txtTelephon = new MetroFramework.Controls.MetroTextBox();
            this.tabData = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.actions.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabData.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1289, 799);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(83, 231);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Celular";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(83, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Telefono";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(210, 115);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(303, 23);
            this.txtAddress.TabIndex = 19;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(83, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Direccion";
            // 
            // txtNames
            // 
            // 
            // 
            // 
            this.txtNames.CustomButton.Image = null;
            this.txtNames.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtNames.CustomButton.Name = "";
            this.txtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNames.CustomButton.TabIndex = 1;
            this.txtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNames.CustomButton.UseSelectable = true;
            this.txtNames.CustomButton.Visible = false;
            this.txtNames.Lines = new string[0];
            this.txtNames.Location = new System.Drawing.Point(210, 69);
            this.txtNames.MaxLength = 32767;
            this.txtNames.Name = "txtNames";
            this.txtNames.PasswordChar = '\0';
            this.txtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNames.SelectedText = "";
            this.txtNames.SelectionLength = 0;
            this.txtNames.SelectionStart = 0;
            this.txtNames.ShortcutsEnabled = true;
            this.txtNames.Size = new System.Drawing.Size(303, 23);
            this.txtNames.TabIndex = 17;
            this.txtNames.UseSelectable = true;
            this.txtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(210, 25);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(101, 23);
            this.txtId.TabIndex = 16;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Nombres";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(64, 19);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Cliente Id";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(788, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 28);
            this.btnExit.Style = MetroFramework.MetroColorStyle.White;
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Salir";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseStyleColors = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(65, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "CLIENTES";
            // 
            // lNew
            // 
            this.lNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lNew.Location = new System.Drawing.Point(151, 27);
            this.lNew.Name = "lNew";
            this.lNew.Size = new System.Drawing.Size(93, 23);
            this.lNew.TabIndex = 29;
            this.lNew.Text = "| new cliente";
            this.lNew.UseSelectable = true;
            this.lNew.Click += new System.EventHandler(this.lNew_Click);
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.AllowUserToResizeColumns = false;
            this.dtgCliente.AllowUserToResizeRows = false;
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCliente.BackgroundColor = System.Drawing.Color.White;
            this.dtgCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.ContextMenuStrip = this.actions;
            this.dtgCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgCliente.Location = new System.Drawing.Point(13, 17);
            this.dtgCliente.MultiSelect = false;
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCliente.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(772, 263);
            this.dtgCliente.TabIndex = 32;
            // 
            // actions
            // 
            this.actions.BackColor = System.Drawing.Color.White;
            this.actions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.actions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.actions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.delete});
            this.actions.Name = "actions";
            this.actions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.actions.ShowImageMargin = false;
            this.actions.Size = new System.Drawing.Size(156, 74);
            this.actions.Style = MetroFramework.MetroColorStyle.Blue;
            this.actions.Text = "Actions";
            this.actions.UseCustomBackColor = true;
            this.actions.UseCustomForeColor = true;
            this.actions.UseStyleColors = true;
            this.actions.UseWaitCursor = true;
            this.actions.Opening += new System.ComponentModel.CancelEventHandler(this.actions_Opening);
            // 
            // edit
            // 
            this.edit.AutoToolTip = true;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(155, 24);
            this.edit.Text = "Edit";
            this.edit.ToolTipText = "Edit Book";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.AutoToolTip = true;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(155, 24);
            this.delete.Text = "Delete";
            this.delete.ToolTipText = "Delete Book";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(532, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 33);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(408, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 33);
            this.btnSave.Style = MetroFramework.MetroColorStyle.White;
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.UseStyleColors = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabForm);
            this.tabs.Controls.Add(this.tabData);
            this.tabs.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabs.Location = new System.Drawing.Point(75, 75);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(823, 374);
            this.tabs.TabIndex = 33;
            this.tabs.UseSelectable = true;
            // 
            // tabForm
            // 
            this.tabForm.BackColor = System.Drawing.SystemColors.Control;
            this.tabForm.Controls.Add(this.txtMobile);
            this.tabForm.Controls.Add(this.txtTelephon);
            this.tabForm.Controls.Add(this.btnCancel);
            this.tabForm.Controls.Add(this.btnSave);
            this.tabForm.Controls.Add(this.metroLabel4);
            this.tabForm.Controls.Add(this.lblId);
            this.tabForm.Controls.Add(this.txtAddress);
            this.tabForm.Controls.Add(this.metroLabel2);
            this.tabForm.Controls.Add(this.metroLabel5);
            this.tabForm.Controls.Add(this.metroLabel3);
            this.tabForm.Controls.Add(this.txtId);
            this.tabForm.Controls.Add(this.txtNames);
            this.tabForm.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabForm.HorizontalScrollbarBarColor = true;
            this.tabForm.HorizontalScrollbarHighlightOnWheel = false;
            this.tabForm.HorizontalScrollbarSize = 10;
            this.tabForm.Location = new System.Drawing.Point(4, 34);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(815, 336);
            this.tabForm.TabIndex = 0;
            this.tabForm.Text = "CLIENTE FORM";
            this.tabForm.VerticalScrollbarBarColor = true;
            this.tabForm.VerticalScrollbarHighlightOnWheel = false;
            this.tabForm.VerticalScrollbarSize = 10;
            this.tabForm.Click += new System.EventHandler(this.tabForm_Click);
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.CustomButton.Image = null;
            this.txtMobile.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtMobile.CustomButton.Name = "";
            this.txtMobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMobile.CustomButton.TabIndex = 1;
            this.txtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMobile.CustomButton.UseSelectable = true;
            this.txtMobile.CustomButton.Visible = false;
            this.txtMobile.Lines = new string[0];
            this.txtMobile.Location = new System.Drawing.Point(210, 231);
            this.txtMobile.MaxLength = 32767;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.PasswordChar = '\0';
            this.txtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMobile.SelectedText = "";
            this.txtMobile.SelectionLength = 0;
            this.txtMobile.SelectionStart = 0;
            this.txtMobile.ShortcutsEnabled = true;
            this.txtMobile.Size = new System.Drawing.Size(187, 23);
            this.txtMobile.TabIndex = 31;
            this.txtMobile.UseSelectable = true;
            this.txtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMobile.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelephon
            // 
            // 
            // 
            // 
            this.txtTelephon.CustomButton.Image = null;
            this.txtTelephon.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtTelephon.CustomButton.Name = "";
            this.txtTelephon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelephon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelephon.CustomButton.TabIndex = 1;
            this.txtTelephon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelephon.CustomButton.UseSelectable = true;
            this.txtTelephon.CustomButton.Visible = false;
            this.txtTelephon.Lines = new string[0];
            this.txtTelephon.Location = new System.Drawing.Point(210, 161);
            this.txtTelephon.MaxLength = 32767;
            this.txtTelephon.Name = "txtTelephon";
            this.txtTelephon.PasswordChar = '\0';
            this.txtTelephon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelephon.SelectedText = "";
            this.txtTelephon.SelectionLength = 0;
            this.txtTelephon.SelectionStart = 0;
            this.txtTelephon.ShortcutsEnabled = true;
            this.txtTelephon.Size = new System.Drawing.Size(187, 23);
            this.txtTelephon.TabIndex = 30;
            this.txtTelephon.UseSelectable = true;
            this.txtTelephon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelephon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dtgCliente);
            this.tabData.HorizontalScrollbarBarColor = true;
            this.tabData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabData.HorizontalScrollbarSize = 10;
            this.tabData.Location = new System.Drawing.Point(4, 34);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(815, 336);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "CLIENTE LIST";
            this.tabData.VerticalScrollbarBarColor = true;
            this.tabData.VerticalScrollbarHighlightOnWheel = false;
            this.tabData.VerticalScrollbarSize = 10;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 535);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.lNew);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libary | Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.actions.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNames;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink lNew;
        private System.Windows.Forms.DataGridView dtgCliente;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabForm;
        private MetroFramework.Controls.MetroTabPage tabData;
        public MetroFramework.Controls.MetroContextMenu actions;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private MetroFramework.Controls.MetroTextBox txtMobile;
        private MetroFramework.Controls.MetroTextBox txtTelephon;
    }
}

