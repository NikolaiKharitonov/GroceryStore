
namespace PracticaBDMagazin
{
    partial class Profile__buyer_
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
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label patronymicLabel1;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label estimationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile__buyer_));
            System.Windows.Forms.Label otzavLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groceryStoreDataSet = new PracticaBDMagazin.GroceryStoreDataSet();
            this.usersPracticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersPracticaTableAdapter = new PracticaBDMagazin.GroceryStoreDataSetTableAdapters.UsersPracticaTableAdapter();
            this.tableAdapterManager = new PracticaBDMagazin.GroceryStoreDataSetTableAdapters.TableAdapterManager();
            this.buyerTableAdapter = new PracticaBDMagazin.GroceryStoreDataSetTableAdapters.BuyerTableAdapter();
            this.buyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox1 = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.estimationTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.otzavTextBox = new System.Windows.Forms.TextBox();
            surnameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            patronymicLabel1 = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            estimationLabel = new System.Windows.Forms.Label();
            otzavLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersPracticaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(67, 239);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(132, 33);
            surnameLabel.TabIndex = 25;
            surnameLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(126, 288);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(73, 33);
            nameLabel.TabIndex = 27;
            nameLabel.Text = "Имя:";
            // 
            // patronymicLabel1
            // 
            patronymicLabel1.AutoSize = true;
            patronymicLabel1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            patronymicLabel1.Location = new System.Drawing.Point(72, 333);
            patronymicLabel1.Name = "patronymicLabel1";
            patronymicLabel1.Size = new System.Drawing.Size(133, 33);
            patronymicLabel1.TabIndex = 29;
            patronymicLabel1.Text = "Отчество:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            telephoneLabel.Location = new System.Drawing.Point(82, 387);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(123, 33);
            telephoneLabel.TabIndex = 31;
            telephoneLabel.Text = "Телефон:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(104, 440);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(95, 33);
            addressLabel.TabIndex = 33;
            addressLabel.Text = "Адрес:";
            // 
            // estimationLabel
            // 
            estimationLabel.AutoSize = true;
            estimationLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            estimationLabel.Location = new System.Drawing.Point(88, 553);
            estimationLabel.Name = "estimationLabel";
            estimationLabel.Size = new System.Drawing.Size(111, 33);
            estimationLabel.TabIndex = 38;
            estimationLabel.Text = "Оценка:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(200)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 120);
            this.panel1.TabIndex = 11;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(1056, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 58);
            this.button7.TabIndex = 71;
            this.button7.Text = "Выход";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(45, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 58);
            this.button4.TabIndex = 30;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(410, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(424, 49);
            this.label8.TabIndex = 2;
            this.label8.Text = "Продуктовый магазин";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(200)))), ((int)(((byte)(227)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 70);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(514, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "Мой профиль";
            // 
            // groceryStoreDataSet
            // 
            this.groceryStoreDataSet.DataSetName = "GroceryStoreDataSet";
            this.groceryStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersPracticaBindingSource
            // 
            this.usersPracticaBindingSource.DataMember = "UsersPractica";
            this.usersPracticaBindingSource.DataSource = this.groceryStoreDataSet;
            // 
            // usersPracticaTableAdapter
            // 
            this.usersPracticaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuyerTableAdapter = this.buyerTableAdapter;
            this.tableAdapterManager.ProductBAZATableAdapter = null;
            this.tableAdapterManager.ProductRegistrationTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseTableAdapter = null;
            this.tableAdapterManager.SellerTableAdapter = null;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PracticaBDMagazin.GroceryStoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersPracticaTableAdapter = this.usersPracticaTableAdapter;
            this.tableAdapterManager.WorkScheduleTableAdapter = null;
            // 
            // buyerTableAdapter
            // 
            this.buyerTableAdapter.ClearBeforeFill = true;
            // 
            // buyerBindingSource
            // 
            this.buyerBindingSource.DataMember = "Buyer";
            this.buyerBindingSource.DataSource = this.groceryStoreDataSet;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyerBindingSource, "Surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.Location = new System.Drawing.Point(244, 236);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(462, 39);
            this.surnameTextBox.TabIndex = 26;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyerBindingSource, "Name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(244, 282);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(462, 39);
            this.nameTextBox.TabIndex = 28;
            // 
            // patronymicTextBox1
            // 
            this.patronymicTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyerBindingSource, "Patronymic", true));
            this.patronymicTextBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicTextBox1.Location = new System.Drawing.Point(244, 330);
            this.patronymicTextBox1.Name = "patronymicTextBox1";
            this.patronymicTextBox1.Size = new System.Drawing.Size(462, 39);
            this.patronymicTextBox1.TabIndex = 30;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyerBindingSource, "Telephone", true));
            this.telephoneTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneTextBox.Location = new System.Drawing.Point(244, 384);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(462, 39);
            this.telephoneTextBox.TabIndex = 32;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyerBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(244, 437);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(462, 39);
            this.addressTextBox.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(200)))), ((int)(((byte)(227)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(578, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 51);
            this.button1.TabIndex = 35;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(200)))), ((int)(((byte)(227)))));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(913, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 51);
            this.button2.TabIndex = 37;
            this.button2.Text = "Загрузить фото";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // estimationTextBox
            // 
            this.estimationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyerBindingSource, "Estimation", true));
            this.estimationTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.estimationTextBox.Location = new System.Drawing.Point(244, 550);
            this.estimationTextBox.Name = "estimationTextBox";
            this.estimationTextBox.Size = new System.Drawing.Size(73, 39);
            this.estimationTextBox.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(854, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // otzavLabel
            // 
            otzavLabel.AutoSize = true;
            otzavLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            otzavLabel.Location = new System.Drawing.Point(104, 500);
            otzavLabel.Name = "otzavLabel";
            otzavLabel.Size = new System.Drawing.Size(98, 33);
            otzavLabel.TabIndex = 40;
            otzavLabel.Text = "Отзыв:";
            otzavLabel.Click += new System.EventHandler(this.otzavLabel_Click);
            // 
            // otzavTextBox
            // 
            this.otzavTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buyerBindingSource, "Otzav", true));
            this.otzavTextBox.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otzavTextBox.Location = new System.Drawing.Point(244, 497);
            this.otzavTextBox.Name = "otzavTextBox";
            this.otzavTextBox.Size = new System.Drawing.Size(462, 39);
            this.otzavTextBox.TabIndex = 41;
            this.otzavTextBox.TextChanged += new System.EventHandler(this.otzavTextBox_TextChanged);
            // 
            // Profile__buyer_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 691);
            this.Controls.Add(otzavLabel);
            this.Controls.Add(this.otzavTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(estimationLabel);
            this.Controls.Add(this.estimationTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(patronymicLabel1);
            this.Controls.Add(this.patronymicTextBox1);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Profile__buyer_";
            this.Text = "Profile__buyer_";
            this.Load += new System.EventHandler(this.Profile__buyer__Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groceryStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersPracticaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
        private GroceryStoreDataSet groceryStoreDataSet;
        private System.Windows.Forms.BindingSource usersPracticaBindingSource;
        private GroceryStoreDataSetTableAdapters.UsersPracticaTableAdapter usersPracticaTableAdapter;
        private GroceryStoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private GroceryStoreDataSetTableAdapters.BuyerTableAdapter buyerTableAdapter;
        private System.Windows.Forms.BindingSource buyerBindingSource;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox1;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox estimationTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox otzavTextBox;
    }
}