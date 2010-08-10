using System;
using System.Windows.Forms;

namespace PasswordHasher
{
    public partial class Form1 : Form
    {
        private Hasher _hasher = null;

        private void SetHasher(string valueToHash)
        {
            _hasher = new Hasher(comboHashType.SelectedItem.ToString(), valueToHash);
        }

        private void LoadHashTypesCombobox()
        {
            object[] hashTypes = new object[] { "MD5", "RIPEMD160", "SHA1", "SHA256", "SHA384", "SHA512" };
            comboHashType.Items.AddRange(hashTypes);
            comboHashType.SelectedItem = comboHashType.Items[0];
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHashTypesCombobox();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboHashType.SelectedItem == null)
            {
                MessageBox.Show("Must select a hash algorithm type.");
                return;
            }

            if (txtPassword.Text.Equals(String.Empty))
            {
                MessageBox.Show("Must type in a password to hash.");
                return;
            }

            txtStringHashResult.Text = String.Empty;
            txtHexHashResult.Text = String.Empty;

            txtStringHashResult.Text = _hasher.StringHashResult;
            txtHexHashResult.Text = _hasher.HexHashResult;
        }

        private void comboHashType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPassword.Text))
                SetHasher(txtPassword.Text);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            SetHasher(txtPassword.Text);
        }
    }
}
