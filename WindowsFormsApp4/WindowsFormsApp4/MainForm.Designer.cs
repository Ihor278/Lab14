using System;
using System.Windows.Forms;

partial class MainForm
{
    // Поля введення
    private Label lblId;
    private TextBox txtId;
    private Label lblBreed;
    private TextBox txtBreed;
    private Label lblGender;
    private ComboBox cmbGender;
    private Label lblPrice;
    private TextBox txtPrice;
    private Label lblAge;
    private TextBox txtAge;

    // Інші елементи керування
    private ListBox lstDogs;
    private Button btnAdd;
    private Button btnFilterFemale;
    private Button btnSort;
    private Button btnSave;
    private Button btnLoad;
    private ToolTip toolTip;

    private void InitializeComponent()
    {
        // Ініціалізація елементів
        this.lblId = new Label();
        this.lblBreed = new Label();
        this.lblGender = new Label();
        this.lblPrice = new Label();
        this.lblAge = new Label();

        this.txtId = new TextBox();
        this.txtBreed = new TextBox();
        this.cmbGender = new ComboBox();
        this.txtPrice = new TextBox();
        this.txtAge = new TextBox();

        this.lstDogs = new ListBox();
        this.btnAdd = new Button();
        this.btnFilterFemale = new Button();
        this.btnSort = new Button();
        this.btnSave = new Button();
        this.btnLoad = new Button();

        this.toolTip = new ToolTip();

        this.SuspendLayout();

        // lblId
        this.lblId.AutoSize = true;
        this.lblId.Location = new System.Drawing.Point(20, 5);
        this.lblId.Name = "lblId";
        this.lblId.Text = "ID (число):";

        // txtId
        this.txtId.Location = new System.Drawing.Point(20, 25);
        this.txtId.Name = "txtId";
        this.txtId.Size = new System.Drawing.Size(150, 23);
        this.txtId.TabIndex = 0;
        this.toolTip.SetToolTip(this.txtId, "Введіть унікальний числовий ідентифікатор");

        // lblBreed
        this.lblBreed.AutoSize = true;
        this.lblBreed.Location = new System.Drawing.Point(20, 55);
        this.lblBreed.Name = "lblBreed";
        this.lblBreed.Text = "Порода:";

        // txtBreed
        this.txtBreed.Location = new System.Drawing.Point(20, 75);
        this.txtBreed.Name = "txtBreed";
        this.txtBreed.Size = new System.Drawing.Size(150, 23);
        this.txtBreed.TabIndex = 1;
        this.toolTip.SetToolTip(this.txtBreed, "Введіть породу собаки (наприклад: 'Лабрадор', 'Такса')");

        // lblGender
        this.lblGender.AutoSize = true;
        this.lblGender.Location = new System.Drawing.Point(20, 105);
        this.lblGender.Name = "lblGender";
        this.lblGender.Text = "Стать:";

        // cmbGender
        this.cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
        this.cmbGender.Items.AddRange(new object[] { "Самець", "Самка" });
        this.cmbGender.Location = new System.Drawing.Point(20, 125);
        this.cmbGender.Name = "cmbGender";
        this.cmbGender.Size = new System.Drawing.Size(150, 23);
        this.cmbGender.TabIndex = 2;
        this.toolTip.SetToolTip(this.cmbGender, "Оберіть стать тварини");

        // lblPrice
        this.lblPrice.AutoSize = true;
        this.lblPrice.Location = new System.Drawing.Point(20, 155);
        this.lblPrice.Name = "lblPrice";
        this.lblPrice.Text = "Ціна (грн):";

        // txtPrice
        this.txtPrice.Location = new System.Drawing.Point(20, 175);
        this.txtPrice.Name = "txtPrice";
        this.txtPrice.Size = new System.Drawing.Size(150, 23);
        this.txtPrice.TabIndex = 3;
        this.toolTip.SetToolTip(this.txtPrice, "Введіть ціну в гривнях (наприклад: 1500)");

        // lblAge
        this.lblAge.AutoSize = true;
        this.lblAge.Location = new System.Drawing.Point(20, 205);
        this.lblAge.Name = "lblAge";
        this.lblAge.Text = "Вік (років):";

        // txtAge
        this.txtAge.Location = new System.Drawing.Point(20, 225);
        this.txtAge.Name = "txtAge";
        this.txtAge.Size = new System.Drawing.Size(150, 23);
        this.txtAge.TabIndex = 4;
        this.toolTip.SetToolTip(this.txtAge, "Введіть вік собаки в роках");

        // lstDogs
        this.lstDogs.FormattingEnabled = true;
        this.lstDogs.ItemHeight = 15;
        this.lstDogs.Location = new System.Drawing.Point(200, 25);
        this.lstDogs.Name = "lstDogs";
        this.lstDogs.Size = new System.Drawing.Size(350, 250);
        this.lstDogs.TabIndex = 5;

        // btnAdd
        this.btnAdd.Location = new System.Drawing.Point(20, 260);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(150, 30);
        this.btnAdd.TabIndex = 6;
        this.btnAdd.Text = "Додати собаку";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

        // btnFilterFemale
        this.btnFilterFemale.Location = new System.Drawing.Point(20, 300);
        this.btnFilterFemale.Name = "btnFilterFemale";
        this.btnFilterFemale.Size = new System.Drawing.Size(150, 30);
        this.btnFilterFemale.TabIndex = 7;
        this.btnFilterFemale.Text = "Показати самок";
        this.btnFilterFemale.UseVisualStyleBackColor = true;
        this.btnFilterFemale.Click += new EventHandler(this.btnFilterFemale_Click);

        // btnSort
        this.btnSort.Location = new System.Drawing.Point(200, 285);
        this.btnSort.Name = "btnSort";
        this.btnSort.Size = new System.Drawing.Size(150, 30);
        this.btnSort.TabIndex = 8;
        this.btnSort.Text = "Сортувати за ID";
        this.btnSort.UseVisualStyleBackColor = true;
        this.btnSort.Click += new EventHandler(this.btnSort_Click);

        // btnSave
        this.btnSave.Location = new System.Drawing.Point(200, 320);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(150, 30);
        this.btnSave.TabIndex = 9;
        this.btnSave.Text = "Зберегти дані";
        this.btnSave.UseVisualStyleBackColor = true;
        this.btnSave.Click += new EventHandler(this.btnSave_Click);

        // btnLoad
        this.btnLoad.Location = new System.Drawing.Point(370, 320);
        this.btnLoad.Name = "btnLoad";
        this.btnLoad.Size = new System.Drawing.Size(150, 30);
        this.btnLoad.TabIndex = 10;
        this.btnLoad.Text = "Завантажити дані";
        this.btnLoad.UseVisualStyleBackColor = true;
        this.btnLoad.Click += new EventHandler(this.btnLoad_Click);

        // MainForm
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(600, 370);

        this.Controls.Add(this.lblId);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblBreed);
        this.Controls.Add(this.txtBreed);
        this.Controls.Add(this.lblGender);
        this.Controls.Add(this.cmbGender);
        this.Controls.Add(this.lblPrice);
        this.Controls.Add(this.txtPrice);
        this.Controls.Add(this.lblAge);
        this.Controls.Add(this.txtAge);
        this.Controls.Add(this.lstDogs);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnFilterFemale);
        this.Controls.Add(this.btnSort);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.btnLoad);

        this.Name = "MainForm";
        this.Text = "Каталог собак";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
