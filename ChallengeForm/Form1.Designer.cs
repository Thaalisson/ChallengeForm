namespace ChallengeForm
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.gridCSV = new System.Windows.Forms.DataGridView();
            this.bntBroswer = new System.Windows.Forms.Button();
            this.textFile = new System.Windows.Forms.TextBox();
            this.bntSave = new System.Windows.Forms.Button();
            this.bntAlter = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.GroupBox();
            this.btnReturnId = new System.Windows.Forms.Button();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textFileComboBox = new System.Windows.Forms.TextBox();
            this.btnBrowserComboBox = new System.Windows.Forms.Button();
            this.btnLoadComboBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCSV)).BeginInit();
            this.groupComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(944, 32);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 28);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gridCSV
            // 
            this.gridCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCSV.Location = new System.Drawing.Point(22, 82);
            this.gridCSV.Name = "gridCSV";
            this.gridCSV.RowHeadersWidth = 51;
            this.gridCSV.RowTemplate.Height = 24;
            this.gridCSV.Size = new System.Drawing.Size(1021, 253);
            this.gridCSV.TabIndex = 1;
            // 
            // bntBroswer
            // 
            this.bntBroswer.Location = new System.Drawing.Point(841, 32);
            this.bntBroswer.Name = "bntBroswer";
            this.bntBroswer.Size = new System.Drawing.Size(93, 28);
            this.bntBroswer.TabIndex = 2;
            this.bntBroswer.Text = "Broswer";
            this.bntBroswer.UseVisualStyleBackColor = true;
            this.bntBroswer.Click += new System.EventHandler(this.bntBroswer_Click);
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(23, 35);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(815, 22);
            this.textFile.TabIndex = 3;
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(924, 341);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(119, 32);
            this.bntSave.TabIndex = 4;
            this.bntSave.Text = "Save new file";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // bntAlter
            // 
            this.bntAlter.Location = new System.Drawing.Point(693, 341);
            this.bntAlter.Name = "bntAlter";
            this.bntAlter.Size = new System.Drawing.Size(225, 32);
            this.bntAlter.TabIndex = 5;
            this.bntAlter.Text = "Click here to Change \'A\' to \'@\'";
            this.bntAlter.UseVisualStyleBackColor = true;
            this.bntAlter.Click += new System.EventHandler(this.bntAlter_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.Controls.Add(this.btnReturnId);
            this.groupComboBox.Controls.Add(this.comboName);
            this.groupComboBox.Controls.Add(this.groupBox1);
            this.groupComboBox.Controls.Add(this.textFileComboBox);
            this.groupComboBox.Controls.Add(this.btnBrowserComboBox);
            this.groupComboBox.Controls.Add(this.btnLoadComboBox);
            this.groupComboBox.Location = new System.Drawing.Point(22, 379);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(1022, 136);
            this.groupComboBox.TabIndex = 8;
            this.groupComboBox.TabStop = false;
            this.groupComboBox.Text = "ComboBoxing Exemple ";
            // 
            // btnReturnId
            // 
            this.btnReturnId.Location = new System.Drawing.Point(128, 78);
            this.btnReturnId.Name = "btnReturnId";
            this.btnReturnId.Size = new System.Drawing.Size(81, 23);
            this.btnReturnId.TabIndex = 16;
            this.btnReturnId.UseVisualStyleBackColor = true;
            this.btnReturnId.Click += new System.EventHandler(this.btnReturnId_Click);
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(1, 77);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(121, 24);
            this.comboName.TabIndex = 15;
            this.comboName.SelectionChangeCommitted += new System.EventHandler(this.comboName_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 136);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exemple ComboBoxing";
            // 
            // textFileComboBox
            // 
            this.textFileComboBox.Location = new System.Drawing.Point(0, 49);
            this.textFileComboBox.Name = "textFileComboBox";
            this.textFileComboBox.Size = new System.Drawing.Size(815, 22);
            this.textFileComboBox.TabIndex = 11;
            // 
            // btnBrowserComboBox
            // 
            this.btnBrowserComboBox.Location = new System.Drawing.Point(821, 46);
            this.btnBrowserComboBox.Name = "btnBrowserComboBox";
            this.btnBrowserComboBox.Size = new System.Drawing.Size(93, 28);
            this.btnBrowserComboBox.TabIndex = 10;
            this.btnBrowserComboBox.Text = "Broswer";
            this.btnBrowserComboBox.UseVisualStyleBackColor = true;
            this.btnBrowserComboBox.Click += new System.EventHandler(this.btnBrowserComboBox_Click);
            // 
            // btnLoadComboBox
            // 
            this.btnLoadComboBox.Location = new System.Drawing.Point(921, 46);
            this.btnLoadComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadComboBox.Name = "btnLoadComboBox";
            this.btnLoadComboBox.Size = new System.Drawing.Size(100, 28);
            this.btnLoadComboBox.TabIndex = 9;
            this.btnLoadComboBox.Text = "Load";
            this.btnLoadComboBox.UseVisualStyleBackColor = true;
            this.btnLoadComboBox.Click += new System.EventHandler(this.btnLoadComboBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.bntAlter);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.bntBroswer);
            this.Controls.Add(this.gridCSV);
            this.Controls.Add(this.btnLoad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ChallengeAccept";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCSV)).EndInit();
            this.groupComboBox.ResumeLayout(false);
            this.groupComboBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView gridCSV;
        private System.Windows.Forms.Button bntBroswer;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button bntAlter;
        private System.Windows.Forms.GroupBox groupComboBox;
        private System.Windows.Forms.Button btnReturnId;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textFileComboBox;
        private System.Windows.Forms.Button btnBrowserComboBox;
        private System.Windows.Forms.Button btnLoadComboBox;
    }
}

