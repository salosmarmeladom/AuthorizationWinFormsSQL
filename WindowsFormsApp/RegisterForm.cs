using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Properties;

namespace WindowsFormsApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            InitializeUserField(ref userName, Resource.hintName);
            InitializeUserField(ref userSurname, Resource.hintSurname);
            InitializePasswordField(ref inputPassword, Resource.hintPassword);
            InitializePasswordField(ref confirmPassword, Resource.hintConfirmPassword);
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userName_Enter(object sender, EventArgs e)
        {
            EmptyUserFieldOnClick(ref userName, Resource.hintName);           
        }

        private void userSurname_Enter(object sender, EventArgs e)
        {
            EmptyUserFieldOnClick(ref userSurname, Resource.hintSurname);           
        }

        private void inputPassword_Enter(object sender, EventArgs e)
        {
            EmptyPasswordFieldOnClick(ref inputPassword, Resource.hintPassword);
        }

        private void confirmPassword_Enter(object sender, EventArgs e)
        {
            EmptyPasswordFieldOnClick(ref confirmPassword, Resource.hintConfirmPassword);
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            LeaveUserField(ref userName, Resource.hintName);
        }

        private void userSurname_Leave(object sender, EventArgs e)
        {
            LeaveUserField(ref userSurname, Resource.hintSurname);
        }

        private void inputPassword_Leave(object sender, EventArgs e)
        {
            LeavePasswordField(ref inputPassword, Resource.hintPassword);
        }

        private void confirmPassword_Leave(object sender, EventArgs e)
        {
            LeavePasswordField(ref confirmPassword, Resource.hintConfirmPassword);
        }

        private void LeaveUserField(ref TextBox field, string resource)
        {
            if(field.Text == "")
            {
                FillHintField(ref field, resource);
            }
        }

        private void LeavePasswordField(ref TextBox field, string resource)
        {
            if (field.Text == "")
            {
                field.UseSystemPasswordChar= false;
                FillHintField(ref field, resource);
            }
        }

        private void FillHintField(ref TextBox field, string resource)
        {
            field.Text = resource;
            field.ForeColor = Color.Red;
        }

        private void EmptyUserFieldOnClick (ref TextBox field, string resource)
        {
            if (field.Text == resource)
            {
                field.Text = "";
            }
        }

        private void EmptyPasswordFieldOnClick(ref TextBox field, string resource)
        {
            if (field.Text == resource)
            {
                field.Text = "";
                field.UseSystemPasswordChar= true;
            }
        }

        private void InitializeUserField (ref TextBox field, string resource)
        {
            field.Text = resource;
            field.ForeColor = Color.Red;
        }

        private void InitializePasswordField (ref TextBox field, string resource)
        {
            field.Text = resource;
            field.UseSystemPasswordChar = false;
            field.ForeColor = Color.Red;
        }
    }
}
