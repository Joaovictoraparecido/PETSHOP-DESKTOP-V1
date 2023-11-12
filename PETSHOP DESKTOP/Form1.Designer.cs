namespace PETSHOP_DESKTOP
{
    partial class PETSHOP
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomePetLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label raçaLabel;
            System.Windows.Forms.Label nomeDoDonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label telefoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PETSHOP));
            this.pETSHOPDataSet = new PETSHOP_DESKTOP.PETSHOPDataSet();
            this.animaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animaisTableAdapter = new PETSHOP_DESKTOP.PETSHOPDataSetTableAdapters.AnimaisTableAdapter();
            this.tableAdapterManager = new PETSHOP_DESKTOP.PETSHOPDataSetTableAdapters.TableAdapterManager();
            this.animaisBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nomePetTextBox = new System.Windows.Forms.TextBox();
            this.corTextBox = new System.Windows.Forms.TextBox();
            this.raçaTextBox = new System.Windows.Forms.TextBox();
            this.nomeDoDonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.animaisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.animaisBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            nomePetLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            raçaLabel = new System.Windows.Forms.Label();
            nomeDoDonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pETSHOPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingNavigator)).BeginInit();
            this.animaisBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pETSHOPDataSet
            // 
            this.pETSHOPDataSet.DataSetName = "PETSHOPDataSet";
            this.pETSHOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animaisBindingSource
            // 
            this.animaisBindingSource.DataMember = "Animais";
            this.animaisBindingSource.DataSource = this.pETSHOPDataSet;
            // 
            // animaisTableAdapter
            // 
            this.animaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnimaisTableAdapter = this.animaisTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = PETSHOP_DESKTOP.PETSHOPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // animaisBindingNavigator
            // 
            this.animaisBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animaisBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.animaisBindingNavigator.BindingSource = this.animaisBindingSource;
            this.animaisBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animaisBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.animaisBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animaisBindingNavigatorSaveItem});
            this.animaisBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animaisBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animaisBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animaisBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animaisBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animaisBindingNavigator.Name = "animaisBindingNavigator";
            this.animaisBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animaisBindingNavigator.Size = new System.Drawing.Size(864, 25);
            this.animaisBindingNavigator.TabIndex = 0;
            this.animaisBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // nomePetLabel
            // 
            nomePetLabel.AutoSize = true;
            nomePetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomePetLabel.Location = new System.Drawing.Point(19, 32);
            nomePetLabel.Name = "nomePetLabel";
            nomePetLabel.Size = new System.Drawing.Size(114, 16);
            nomePetLabel.TabIndex = 1;
            nomePetLabel.Text = "Nome Do  Pet:";
            // 
            // nomePetTextBox
            // 
            this.nomePetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "NomePet", true));
            this.nomePetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomePetTextBox.Location = new System.Drawing.Point(139, 29);
            this.nomePetTextBox.Name = "nomePetTextBox";
            this.nomePetTextBox.Size = new System.Drawing.Size(100, 22);
            this.nomePetTextBox.TabIndex = 2;
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            corLabel.Location = new System.Drawing.Point(21, 83);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(38, 16);
            corLabel.TabIndex = 3;
            corLabel.Text = "Cor:";
            // 
            // corTextBox
            // 
            this.corTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "Cor", true));
            this.corTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corTextBox.Location = new System.Drawing.Point(139, 83);
            this.corTextBox.Name = "corTextBox";
            this.corTextBox.Size = new System.Drawing.Size(100, 22);
            this.corTextBox.TabIndex = 4;
            // 
            // raçaLabel
            // 
            raçaLabel.AutoSize = true;
            raçaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raçaLabel.Location = new System.Drawing.Point(19, 57);
            raçaLabel.Name = "raçaLabel";
            raçaLabel.Size = new System.Drawing.Size(50, 16);
            raçaLabel.TabIndex = 5;
            raçaLabel.Text = "Raça:";
            // 
            // raçaTextBox
            // 
            this.raçaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "Raça", true));
            this.raçaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raçaTextBox.Location = new System.Drawing.Point(139, 57);
            this.raçaTextBox.Name = "raçaTextBox";
            this.raçaTextBox.Size = new System.Drawing.Size(100, 22);
            this.raçaTextBox.TabIndex = 6;
            // 
            // nomeDoDonoLabel
            // 
            nomeDoDonoLabel.AutoSize = true;
            nomeDoDonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeDoDonoLabel.Location = new System.Drawing.Point(0, 145);
            nomeDoDonoLabel.Name = "nomeDoDonoLabel";
            nomeDoDonoLabel.Size = new System.Drawing.Size(123, 16);
            nomeDoDonoLabel.TabIndex = 7;
            nomeDoDonoLabel.Text = "Nome Do Dono:";
            // 
            // nomeDoDonoTextBox
            // 
            this.nomeDoDonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "NomeDoDono", true));
            this.nomeDoDonoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeDoDonoTextBox.Location = new System.Drawing.Point(139, 139);
            this.nomeDoDonoTextBox.Name = "nomeDoDonoTextBox";
            this.nomeDoDonoTextBox.Size = new System.Drawing.Size(179, 22);
            this.nomeDoDonoTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(10, 172);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(139, 169);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(179, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(this.telefoneTextBox);
            this.groupBox1.Controls.Add(nomePetLabel);
            this.groupBox1.Controls.Add(this.nomePetTextBox);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(raçaLabel);
            this.groupBox1.Controls.Add(this.nomeDoDonoTextBox);
            this.groupBox1.Controls.Add(nomeDoDonoLabel);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.raçaTextBox);
            this.groupBox1.Controls.Add(this.corTextBox);
            this.groupBox1.Controls.Add(corLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 226);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PETSHOP";
            // 
            // animaisDataGridView
            // 
            this.animaisDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animaisDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.animaisDataGridView.AutoGenerateColumns = false;
            this.animaisDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.animaisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animaisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.animaisDataGridView.DataSource = this.animaisBindingSource;
            this.animaisDataGridView.Location = new System.Drawing.Point(40, 251);
            this.animaisDataGridView.Name = "animaisDataGridView";
            this.animaisDataGridView.Size = new System.Drawing.Size(748, 216);
            this.animaisDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomePet";
            this.dataGridViewTextBoxColumn2.HeaderText = "NomePet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Raça";
            this.dataGridViewTextBoxColumn4.HeaderText = "Raça";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NomeDoDono";
            this.dataGridViewTextBoxColumn5.HeaderText = "NomeDoDono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(6, 198);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(78, 18);
            telefoneLabel.TabIndex = 10;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animaisBindingSource, "Telefone", true));
            this.telefoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneTextBox.Location = new System.Drawing.Point(139, 198);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(107, 22);
            this.telefoneTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(2, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Informações Do Dono";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // animaisBindingNavigatorSaveItem
            // 
            this.animaisBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animaisBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animaisBindingNavigatorSaveItem.Image")));
            this.animaisBindingNavigatorSaveItem.Name = "animaisBindingNavigatorSaveItem";
            this.animaisBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.animaisBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.animaisBindingNavigatorSaveItem.Click += new System.EventHandler(this.animaisBindingNavigatorSaveItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PETSHOP_DESKTOP.Properties.Resources.Captura_de_tela_2023_11_12_154105;
            this.pictureBox1.Location = new System.Drawing.Point(408, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PETSHOP_DESKTOP.Properties.Resources.Captura_de_tela_2023_11_12_155820;
            this.pictureBox2.Location = new System.Drawing.Point(698, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(803, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PETSHOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.animaisDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.animaisBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PETSHOP";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "PETSHOP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pETSHOPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animaisBindingNavigator)).EndInit();
            this.animaisBindingNavigator.ResumeLayout(false);
            this.animaisBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animaisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PETSHOPDataSet pETSHOPDataSet;
        private System.Windows.Forms.BindingSource animaisBindingSource;
        private PETSHOPDataSetTableAdapters.AnimaisTableAdapter animaisTableAdapter;
        private PETSHOPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animaisBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animaisBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomePetTextBox;
        private System.Windows.Forms.TextBox corTextBox;
        private System.Windows.Forms.TextBox raçaTextBox;
        private System.Windows.Forms.TextBox nomeDoDonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView animaisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

