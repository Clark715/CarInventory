namespace CarInventory
{
    partial class InventoryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDrivetrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.makeText = new System.Windows.Forms.TextBox();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelText = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.colorText = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.bodyText = new System.Windows.Forms.TextBox();
            this.bodyLabel = new System.Windows.Forms.Label();
            this.transText = new System.Windows.Forms.TextBox();
            this.transLabel = new System.Windows.Forms.Label();
            this.drivetrainText = new System.Windows.Forms.TextBox();
            this.drivetrainLabel = new System.Windows.Forms.Label();
            this.valueText = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carID,
            this.carMake,
            this.carModel,
            this.carYear,
            this.carColor,
            this.carBody,
            this.carTrans,
            this.carDrivetrain,
            this.carValue});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(943, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // carID
            // 
            this.carID.HeaderText = "ID";
            this.carID.Name = "carID";
            this.carID.ReadOnly = true;
            // 
            // carMake
            // 
            this.carMake.HeaderText = "MAKE";
            this.carMake.Name = "carMake";
            this.carMake.ReadOnly = true;
            // 
            // carModel
            // 
            this.carModel.HeaderText = "MODEL";
            this.carModel.Name = "carModel";
            this.carModel.ReadOnly = true;
            // 
            // carYear
            // 
            this.carYear.HeaderText = "YEAR";
            this.carYear.Name = "carYear";
            this.carYear.ReadOnly = true;
            // 
            // carColor
            // 
            this.carColor.HeaderText = "COLOR";
            this.carColor.Name = "carColor";
            this.carColor.ReadOnly = true;
            // 
            // carBody
            // 
            this.carBody.HeaderText = "BODY ";
            this.carBody.Name = "carBody";
            this.carBody.ReadOnly = true;
            // 
            // carTrans
            // 
            this.carTrans.HeaderText = "TRANSMISSION";
            this.carTrans.Name = "carTrans";
            this.carTrans.ReadOnly = true;
            // 
            // carDrivetrain
            // 
            this.carDrivetrain.HeaderText = "DRIVETRAIN";
            this.carDrivetrain.Name = "carDrivetrain";
            this.carDrivetrain.ReadOnly = true;
            // 
            // carValue
            // 
            this.carValue.HeaderText = "VALUE";
            this.carValue.Name = "carValue";
            this.carValue.ReadOnly = true;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(CarInventory.Car);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(812, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(62, 435);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 23);
            this.idText.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(35, 438);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID:";
            // 
            // makeText
            // 
            this.makeText.Location = new System.Drawing.Point(62, 464);
            this.makeText.Name = "makeText";
            this.makeText.Size = new System.Drawing.Size(100, 23);
            this.makeText.TabIndex = 5;
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(18, 467);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(39, 15);
            this.makeLabel.TabIndex = 6;
            this.makeLabel.Text = "Make:";
            // 
            // modelText
            // 
            this.modelText.Location = new System.Drawing.Point(62, 493);
            this.modelText.Name = "modelText";
            this.modelText.Size = new System.Drawing.Size(100, 23);
            this.modelText.TabIndex = 7;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(12, 496);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(44, 15);
            this.modelLabel.TabIndex = 8;
            this.modelLabel.Text = "Model:";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(275, 435);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(100, 23);
            this.yearText.TabIndex = 9;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(237, 438);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 15);
            this.yearLabel.TabIndex = 10;
            this.yearLabel.Text = "Year:";
            // 
            // colorText
            // 
            this.colorText.Location = new System.Drawing.Point(275, 464);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(100, 23);
            this.colorText.TabIndex = 11;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(231, 467);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(39, 15);
            this.colorLabel.TabIndex = 12;
            this.colorLabel.Text = "Color:";
            // 
            // bodyText
            // 
            this.bodyText.Location = new System.Drawing.Point(275, 493);
            this.bodyText.Name = "bodyText";
            this.bodyText.Size = new System.Drawing.Size(100, 23);
            this.bodyText.TabIndex = 13;
            // 
            // bodyLabel
            // 
            this.bodyLabel.AutoSize = true;
            this.bodyLabel.Location = new System.Drawing.Point(205, 496);
            this.bodyLabel.Name = "bodyLabel";
            this.bodyLabel.Size = new System.Drawing.Size(65, 15);
            this.bodyLabel.TabIndex = 14;
            this.bodyLabel.Text = "Body Style:";
            // 
            // transText
            // 
            this.transText.Location = new System.Drawing.Point(530, 435);
            this.transText.Name = "transText";
            this.transText.Size = new System.Drawing.Size(100, 23);
            this.transText.TabIndex = 15;
            // 
            // transLabel
            // 
            this.transLabel.AutoSize = true;
            this.transLabel.Location = new System.Drawing.Point(419, 438);
            this.transLabel.Name = "transLabel";
            this.transLabel.Size = new System.Drawing.Size(105, 15);
            this.transLabel.TabIndex = 16;
            this.transLabel.Text = "Transmission Type:";
            // 
            // drivetrainText
            // 
            this.drivetrainText.Location = new System.Drawing.Point(530, 464);
            this.drivetrainText.Name = "drivetrainText";
            this.drivetrainText.Size = new System.Drawing.Size(100, 23);
            this.drivetrainText.TabIndex = 17;
            // 
            // drivetrainLabel
            // 
            this.drivetrainLabel.AutoSize = true;
            this.drivetrainLabel.Location = new System.Drawing.Point(436, 467);
            this.drivetrainLabel.Name = "drivetrainLabel";
            this.drivetrainLabel.Size = new System.Drawing.Size(88, 15);
            this.drivetrainLabel.TabIndex = 18;
            this.drivetrainLabel.Text = "Drivetrain Type:";
            // 
            // valueText
            // 
            this.valueText.Location = new System.Drawing.Point(530, 493);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(100, 23);
            this.valueText.TabIndex = 19;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(486, 496);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(38, 15);
            this.valueLabel.TabIndex = 20;
            this.valueLabel.Text = "Value:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(663, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(292, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 547);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueText);
            this.Controls.Add(this.drivetrainLabel);
            this.Controls.Add(this.drivetrainText);
            this.Controls.Add(this.transLabel);
            this.Controls.Add(this.transText);
            this.Controls.Add(this.bodyLabel);
            this.Controls.Add(this.bodyText);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.modelText);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.makeText);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventoryForm";
            this.Text = "Car Inventory Simulator";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private BindingSource carBindingSource;
        private TextBox idText;
        private Label idLabel;
        private TextBox makeText;
        private Label makeLabel;
        private TextBox modelText;
        private Label modelLabel;
        private TextBox yearText;
        private Label yearLabel;
        private TextBox colorText;
        private Label colorLabel;
        private TextBox bodyText;
        private Label bodyLabel;
        private TextBox transText;
        private Label transLabel;
        private TextBox drivetrainText;
        private Label drivetrainLabel;
        private TextBox valueText;
        private Label valueLabel;
        private DataGridViewTextBoxColumn carID;
        private DataGridViewTextBoxColumn carMake;
        private DataGridViewTextBoxColumn carModel;
        private DataGridViewTextBoxColumn carYear;
        private DataGridViewTextBoxColumn carColor;
        private DataGridViewTextBoxColumn carBody;
        private DataGridViewTextBoxColumn carTrans;
        private DataGridViewTextBoxColumn carDrivetrain;
        private DataGridViewTextBoxColumn carValue;
        private Button button3;
    }
}