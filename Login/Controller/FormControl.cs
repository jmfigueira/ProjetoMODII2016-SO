using NodeFS.View;
using System.Windows.Forms;
using UsersAndGroups.View;

namespace Login.Controller
{
    public class FormControl
    {
        #region Atributes
        private ControllerLogin _control;
        private static Start _principal;
        private static Node _inicio;
        #endregion

        #region Constructor
        public FormControl(Form form)
        {
            _principal = new Start(form);
            _control = new ControllerLogin();
            _inicio = new Node(form);
        }
        #endregion

        #region Public Methods
        public void Login(TextBox textName, TextBox textPass, Form thisForm)
        {
            if (textName.Text == "Admin" && textPass.Text == "Admin")
            {
                thisForm.Hide();
                textName.Text = string.Empty;
                textPass.Text = string.Empty;
                _principal.Show();
            }
            else if (_control.ValidUser(textName.Text, textPass.Text))
            {
                thisForm.Hide();
                _inicio.SetName(textName.Text);
                textName.Text = string.Empty;
                textPass.Text = string.Empty;
                _inicio.Show();
            }
            else
            {
                MessageBox.Show("O usuário não existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
