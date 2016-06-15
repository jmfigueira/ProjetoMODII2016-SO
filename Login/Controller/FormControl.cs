namespace Login.Controller
{
    using System.Windows.Forms;

    using NodeFS.View;

    using UsersAndGroups.View;

    /// <summary>
    ///     The form control.
    /// </summary>
    public class FormControl
    {
        private static Node _inicio;

        private static Start _principal;

        private readonly ControllerLogin _control;

        public FormControl(Form form)
        {
            _principal = new Start(form);
            this._control = new ControllerLogin();
            _inicio = new Node(form);
        }

        public void Login(TextBox textName, TextBox textPass, Form thisForm)
        {
            if (textName.Text == @"Admin" && textPass.Text == @"Admin")
            {
                thisForm.Hide();
                textName.Text = string.Empty;
                textPass.Text = string.Empty;
                _principal.Show();
            }
            else if (this._control.ValidUser(textName.Text, textPass.Text))
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
    }
}