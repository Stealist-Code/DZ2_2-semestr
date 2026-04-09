namespace Brewery.Forms
{
    partial class MainForm
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
            TreeNode treeNode1 = new TreeNode("Пиво");
            TreeNode treeNode2 = new TreeNode("Рецепты");
            TreeNode treeNode3 = new TreeNode("Ингредиенты");
            mainTreeView = new TreeView();
            dataGridView1 = new DataGridView();
            splitContainer1 = new SplitContainer();
            pictureBoxBeer = new PictureBox();
            mainMenuStrip = new MenuStrip();
            импортироватьДанныеToolStripMenuItem = new ToolStripMenuItem();
            импортИнгредиентовToolStripMenuItem = new ToolStripMenuItem();
            импортРецептовToolStripMenuItem = new ToolStripMenuItem();
            экспортироватьДанныеToolStripMenuItem = new ToolStripMenuItem();
            экспортВJSONToolStripMenuItem = new ToolStripMenuItem();
            importOpenFileDialog = new OpenFileDialog();
            tabControlMain = new TabControl();
            tagPageStorage = new TabPage();
            tabPageBrewery = new TabPage();
            pictureBox1 = new PictureBox();
            splitter2 = new Splitter();
            buttonStartBrew = new Button();
            splitter1 = new Splitter();
            labelMainText = new Label();
            comboBoxRecipe = new ComboBox();
            labelForComboBox = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBeer).BeginInit();
            mainMenuStrip.SuspendLayout();
            tabControlMain.SuspendLayout();
            tagPageStorage.SuspendLayout();
            tabPageBrewery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainTreeView
            // 
            mainTreeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTreeView.Location = new Point(3, 110);
            mainTreeView.Name = "mainTreeView";
            treeNode1.Name = "BeerNode";
            treeNode1.Tag = "BeerNode";
            treeNode1.Text = "Пиво";
            treeNode2.Name = "RecipeNode";
            treeNode2.Tag = "RecipeNode";
            treeNode2.Text = "Рецепты";
            treeNode3.Name = "IngredientNode";
            treeNode3.Tag = "IngredientNode";
            treeNode3.Text = "Ингредиенты";
            mainTreeView.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            mainTreeView.Size = new Size(259, 364);
            mainTreeView.TabIndex = 0;
            mainTreeView.AfterSelect += mainTreeView_AfterSelect;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(661, 443);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(6, 6);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBoxBeer);
            splitContainer1.Panel1.Controls.Add(mainTreeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(mainMenuStrip);
            splitContainer1.Size = new Size(936, 465);
            splitContainer1.SplitterDistance = 265;
            splitContainer1.TabIndex = 3;
            // 
            // pictureBoxBeer
            // 
            pictureBoxBeer.Dock = DockStyle.Top;
            pictureBoxBeer.Image = Properties.Resources.beer_logo;
            pictureBoxBeer.Location = new Point(0, 0);
            pictureBoxBeer.Name = "pictureBoxBeer";
            pictureBoxBeer.Size = new Size(265, 104);
            pictureBoxBeer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBeer.TabIndex = 1;
            pictureBoxBeer.TabStop = false;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.ImageScalingSize = new Size(20, 20);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { импортироватьДанныеToolStripMenuItem, экспортироватьДанныеToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(667, 28);
            mainMenuStrip.TabIndex = 2;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // импортироватьДанныеToolStripMenuItem
            // 
            импортироватьДанныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { импортИнгредиентовToolStripMenuItem, импортРецептовToolStripMenuItem });
            импортироватьДанныеToolStripMenuItem.Name = "импортироватьДанныеToolStripMenuItem";
            импортироватьДанныеToolStripMenuItem.Size = new Size(192, 24);
            импортироватьДанныеToolStripMenuItem.Text = "Импортировать данные";
            // 
            // импортИнгредиентовToolStripMenuItem
            // 
            импортИнгредиентовToolStripMenuItem.Name = "импортИнгредиентовToolStripMenuItem";
            импортИнгредиентовToolStripMenuItem.Size = new Size(249, 26);
            импортИнгредиентовToolStripMenuItem.Text = "Импорт ингредиентов";
            импортИнгредиентовToolStripMenuItem.Click += импортИнгредиентовToolStripMenuItem_Click;
            // 
            // импортРецептовToolStripMenuItem
            // 
            импортРецептовToolStripMenuItem.Name = "импортРецептовToolStripMenuItem";
            импортРецептовToolStripMenuItem.Size = new Size(249, 26);
            импортРецептовToolStripMenuItem.Text = "Импорт рецептов";
            импортРецептовToolStripMenuItem.Click += импортРецептовToolStripMenuItem_Click;
            // 
            // экспортироватьДанныеToolStripMenuItem
            // 
            экспортироватьДанныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { экспортВJSONToolStripMenuItem });
            экспортироватьДанныеToolStripMenuItem.Name = "экспортироватьДанныеToolStripMenuItem";
            экспортироватьДанныеToolStripMenuItem.Size = new Size(193, 24);
            экспортироватьДанныеToolStripMenuItem.Text = "Экспортировать данные";
            // 
            // экспортВJSONToolStripMenuItem
            // 
            экспортВJSONToolStripMenuItem.Name = "экспортВJSONToolStripMenuItem";
            экспортВJSONToolStripMenuItem.Size = new Size(199, 26);
            экспортВJSONToolStripMenuItem.Text = "Экспорт в JSON";
            экспортВJSONToolStripMenuItem.Click += экспортВJSONToolStripMenuItem_Click;
            // 
            // importOpenFileDialog
            // 
            importOpenFileDialog.FileName = "openFileDialog1";
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tagPageStorage);
            tabControlMain.Controls.Add(tabPageBrewery);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(971, 525);
            tabControlMain.TabIndex = 4;
            // 
            // tagPageStorage
            // 
            tagPageStorage.Controls.Add(splitContainer1);
            tagPageStorage.Location = new Point(4, 29);
            tagPageStorage.Name = "tagPageStorage";
            tagPageStorage.Padding = new Padding(3);
            tagPageStorage.Size = new Size(963, 492);
            tagPageStorage.TabIndex = 0;
            tagPageStorage.Text = "Склад";
            tagPageStorage.UseVisualStyleBackColor = true;
            // 
            // tabPageBrewery
            // 
            tabPageBrewery.Controls.Add(pictureBox1);
            tabPageBrewery.Controls.Add(splitter2);
            tabPageBrewery.Controls.Add(buttonStartBrew);
            tabPageBrewery.Controls.Add(splitter1);
            tabPageBrewery.Controls.Add(labelMainText);
            tabPageBrewery.Controls.Add(comboBoxRecipe);
            tabPageBrewery.Controls.Add(labelForComboBox);
            tabPageBrewery.Location = new Point(4, 29);
            tabPageBrewery.Name = "tabPageBrewery";
            tabPageBrewery.Padding = new Padding(3);
            tabPageBrewery.Size = new Size(963, 492);
            tabPageBrewery.TabIndex = 1;
            tabPageBrewery.Text = "Варочная";
            tabPageBrewery.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wooden;
            pictureBox1.Location = new Point(35, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(7, 3);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(390, 486);
            splitter2.TabIndex = 9;
            splitter2.TabStop = false;
            // 
            // buttonStartBrew
            // 
            buttonStartBrew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonStartBrew.Location = new Point(592, 306);
            buttonStartBrew.Name = "buttonStartBrew";
            buttonStartBrew.Size = new Size(118, 30);
            buttonStartBrew.TabIndex = 6;
            buttonStartBrew.Text = "Начать варить";
            buttonStartBrew.UseVisualStyleBackColor = true;
            buttonStartBrew.Click += buttonStartBrew_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 3);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 486);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // labelMainText
            // 
            labelMainText.AutoSize = true;
            labelMainText.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelMainText.Location = new Point(576, 68);
            labelMainText.Name = "labelMainText";
            labelMainText.Size = new Size(160, 41);
            labelMainText.TabIndex = 3;
            labelMainText.Text = "Варочная";
            // 
            // comboBoxRecipe
            // 
            comboBoxRecipe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxRecipe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRecipe.FormattingEnabled = true;
            comboBoxRecipe.Location = new Point(702, 210);
            comboBoxRecipe.Name = "comboBoxRecipe";
            comboBoxRecipe.Size = new Size(159, 28);
            comboBoxRecipe.TabIndex = 0;
            // 
            // labelForComboBox
            // 
            labelForComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelForComboBox.AutoSize = true;
            labelForComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelForComboBox.Location = new Point(465, 207);
            labelForComboBox.Name = "labelForComboBox";
            labelForComboBox.Size = new Size(170, 28);
            labelForComboBox.TabIndex = 4;
            labelForComboBox.Text = "Выберите рецепт";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 549);
            Controls.Add(tabControlMain);
            Name = "MainForm";
            Text = "Главное окно";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBeer).EndInit();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            tabControlMain.ResumeLayout(false);
            tagPageStorage.ResumeLayout(false);
            tabPageBrewery.ResumeLayout(false);
            tabPageBrewery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView mainTreeView;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer1;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem импортироватьДанныеToolStripMenuItem;
        private ToolStripMenuItem экспортироватьДанныеToolStripMenuItem;
        private OpenFileDialog importOpenFileDialog;
        private ToolStripMenuItem экспортВJSONToolStripMenuItem;
        private PictureBox pictureBoxBeer;
        private ToolStripMenuItem импортИнгредиентовToolStripMenuItem;
        private ToolStripMenuItem импортРецептовToolStripMenuItem;
        private TabControl tabControlMain;
        private TabPage tagPageStorage;
        private TabPage tabPageBrewery;
        private Label labelForComboBox;
        private Label labelMainText;
        private ComboBox comboBoxRecipe;
        private Button buttonStartBrew;
        private Splitter splitter1;
        private Splitter splitter2;
        private PictureBox pictureBox1;
    }
}