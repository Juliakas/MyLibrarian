﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrarian.Data;

namespace MyLibrarian.Forms
{
    public partial class RegistrationWindow : Form
    {

        public RegistrationWindow()
        {
            InitializeComponent();

            LastNamePlaceholderText();
            PasswordPlaceholderText();
            ConfirmPasswordPlaceholderText();

            LockCreateAccountButton();
        }

        #region Placeholder text methods

        private void FirstNamePlaceholderText()
        {
            FirstNameBox.ForeColor = Color.Gray;
            FirstNameBox.Text = "First name";
        }

        private void LoseFirstNamePlaceholderText()
        {
            FirstNameBox.Text = "";
            FirstNameBox.ForeColor = Color.Black;
        }

        private void LastNamePlaceholderText()
        {
            LastNameBox.ForeColor = Color.Gray;
            LastNameBox.Text = "Last name";
        }

        private void LoseLastNamePlaceholderText()
        {
            LastNameBox.Text = "";
            LastNameBox.ForeColor = Color.Black;
        }

        private void PasswordPlaceholderText()
        {
            PasswordBox.ForeColor = Color.Gray;
            PasswordBox.PasswordChar = '\0';
            PasswordBox.Text = "Password";
        }

        private void LosePasswordPlaceholderText()
        {
            PasswordBox.Text = "";
            PasswordBox.ForeColor = Color.Black;
            PasswordBox.PasswordChar = '*';
        }

        private void ConfirmPasswordPlaceholderText()
        {
            ConfirmPasswordBox.ForeColor = Color.Gray;
            ConfirmPasswordBox.PasswordChar = '\0';
            ConfirmPasswordBox.Text = "Confirm Password";
        }

        private void LoseConfirmPasswordPlaceholderText()
        {
            ConfirmPasswordBox.Text = "";
            ConfirmPasswordBox.ForeColor = Color.Black;
            ConfirmPasswordBox.PasswordChar = '*';
        }

        #endregion

        #region Requirement check methods
        private bool CanCreateAccount(string password1, string password2)
        {
            return (password1 == password2)
                && (password1.Length >= 6)
                && (FirstNameBox.ForeColor == Color.Black)
                && (LastNameBox.ForeColor == Color.Black)
                && (FirstNameBox.Text.Length > 0)
                && (LastNameBox.Text.Length > 0);
        }

        private void LockCreateAccountButton()
        {
            CreateAccountButton.Enabled = false;
            CreateAccountButton.ForeColor = Color.Gray;
        }

        private void UnlockCreateAccountButton()
        {
            CreateAccountButton.Enabled = true;
            CreateAccountButton.ForeColor = Color.Black;
        }
        #endregion

        #region Enter/Lose focus methods
        private void FirstNameBox_Enter(object sender, EventArgs e)
        {
            if(FirstNameBox.ForeColor == Color.Gray)
            {
                LoseFirstNamePlaceholderText();
            }
        }

        private void FirstNameBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FirstNameBox.Text))
            {
                FirstNamePlaceholderText();
            }
        }

        private void LastNameBox_Enter(object sender, EventArgs e)
        {
            if (LastNameBox.ForeColor == Color.Gray)
            {
                LoseLastNamePlaceholderText();
            }
        }

        private void LastNameBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(LastNameBox.Text))
            {
                LastNamePlaceholderText();
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.ForeColor == Color.Gray)
            {
                LosePasswordPlaceholderText();
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordBox.Text))
            {
                PasswordPlaceholderText();
            }
        }

        private void ConfirmPasswordBox_Enter(object sender, EventArgs e)
        {
            if (ConfirmPasswordBox.ForeColor == Color.Gray)
            {
                LoseConfirmPasswordPlaceholderText();
            }
        }

        private void ConfirmPasswordBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ConfirmPasswordBox.Text))
            {
                ConfirmPasswordPlaceholderText();
            }
        }
        #endregion methods

        #region Key Press methods
        private void LastNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnyTextBox_KeyPress();
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void FirstNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AnyTextBox_KeyPress();
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                if(PasswordBox.Text.Length == 0)
                {
                    return;
                }
                AnyTextBox_KeyPress(PasswordBox.Text.Remove(PasswordBox.Text.Length - 1), ConfirmPasswordBox.Text);
            }
            else
            {
                AnyTextBox_KeyPress(PasswordBox.Text + e.KeyChar, ConfirmPasswordBox.Text);
            }

            if (PasswordBox.Text.Length + 1 >= 6)
            {
                ShortPasswordLabel.Hide();
            }
            else
            {
                ShortPasswordLabel.Show();
            }

            if (ConfirmPasswordBox.Text == PasswordBox.Text + e.KeyChar
                || (e.KeyChar == (char)Keys.Back && ConfirmPasswordBox.Text == PasswordBox.Text.Remove(PasswordBox.Text.Length - 1)))
            {
                PasswordDoesNotMatchLabel.Hide();
            }
            else
            {
                PasswordDoesNotMatchLabel.Show();
            }
        }

        private void ConfirmPasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                if (ConfirmPasswordBox.Text.Length == 0)
                {
                    return;
                }
                AnyTextBox_KeyPress(PasswordBox.Text, ConfirmPasswordBox.Text.Remove(ConfirmPasswordBox.Text.Length - 1));
            }
            else
            {
                AnyTextBox_KeyPress(PasswordBox.Text, ConfirmPasswordBox.Text + e.KeyChar);
            }

            if (ConfirmPasswordBox.Text + e.KeyChar == PasswordBox.Text
                || (e.KeyChar == (char)Keys.Back && PasswordBox.Text == ConfirmPasswordBox.Text.Remove(ConfirmPasswordBox.Text.Length - 1)))
            {
                PasswordDoesNotMatchLabel.Hide();
            }
            else
            {
                PasswordDoesNotMatchLabel.Show();
            }
        }

        private void AnyTextBox_KeyPress(string password1, string password2)
        {
            if (CanCreateAccount(password1, password2) && !CreateAccountButton.Enabled)
            {
                UnlockCreateAccountButton();
            }
            else if (!CanCreateAccount(password1, password2) && CreateAccountButton.Enabled)
            {
                LockCreateAccountButton();
            }
        }

        private void AnyTextBox_KeyPress()
        {
            AnyTextBox_KeyPress(PasswordBox.Text, ConfirmPasswordBox.Text);
        }
        #endregion

        private void BackButton_Click(object sender, EventArgs e)
        {
            AuthWindow.Instance.Show();
            this.Dispose();
        }

        private void RegistrationWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            int id;
            string firstName = FirstNameBox.Text;
            string lastName = LastNameBox.Text;
            string passwordHash = new Hashing().GenerateHash(PasswordBox.Text);

            ControllerDB database = AuthWindow.Instance.Database;
            DataTable table = database.GetDataTable(ControllerDB.Table.Reader);
            try
            {
                DataRow row = table.Rows[table.Rows.Count - 1];
                id = (int)row["ID"] + 1;
            }
            catch (IndexOutOfRangeException ex)
            {
                id = 1710000;
            }
            
            database.InsertToReader(new Reader(id, firstName, lastName, passwordHash));
            
            MessageManager.ShowMessageBox(String.Format("{0:D7}",id.ToString()), "Your ID");
            this.Hide();
            AuthWindow.Instance.Show();
        }


    }
}
