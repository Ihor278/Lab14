using System;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class MainForm : Form
{
    private DogCollection collection = new DogCollection();

    public MainForm()
    {
        InitializeComponent();

        // Ініціалізація ComboBox (гендер)
        cmbGender.Items.Add("Male");
        cmbGender.Items.Add("Female");
        cmbGender.SelectedIndex = 0;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            string id = txtId.Text.Trim();
            string breed = txtBreed.Text.Trim();
            string gender = cmbGender.SelectedItem.ToString();
            decimal price = decimal.Parse(txtPrice.Text);
            int age = int.Parse(txtAge.Text);

            Dog dog = new Dog(id, breed, gender, price, age);
            collection.Add(dog);
            ShowDogs(collection.GetAll());
            ClearInputFields();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Помилка: " + ex.Message);
        }
    }

    private void btnFilterFemale_Click(object sender, EventArgs e)
    {
        List<Dog> filtered = collection.GetByGender("Female");
        ShowDogs(filtered);
    }

    private void btnSort_Click(object sender, EventArgs e)
    {
        collection.SortById();
        ShowDogs(collection.GetAll());
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        SaveFileDialog sfd = new SaveFileDialog();
        sfd.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
        if (sfd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                collection.SaveToFile(sfd.FileName);
                MessageBox.Show("Колекцію збережено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка збереження: " + ex.Message);
            }
        }
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
        if (ofd.ShowDialog() == DialogResult.OK)
        {
            try
            {
                collection.LoadFromFile(ofd.FileName);
                ShowDogs(collection.GetAll());
                MessageBox.Show("Колекцію завантажено.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка завантаження: " + ex.Message);
            }
        }
    }

    private void ShowDogs(List<Dog> dogs)
    {
        lstDogs.Items.Clear();
        foreach (Dog dog in dogs)
        {
            lstDogs.Items.Add(dog.ToString());
        }
    }

    private void ClearInputFields()
    {
        txtId.Text = "";
        txtBreed.Text = "";
        cmbGender.SelectedIndex = 0;
        txtPrice.Text = "";
        txtAge.Text = "";
    }
}
