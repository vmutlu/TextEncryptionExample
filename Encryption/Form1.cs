using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            var collection = new ServiceCollection();
            collection.AddDataProtection();
            var LockerKey = collection.BuildServiceProvider();

            var locker = ActivatorUtilities.CreateInstance<Security>(LockerKey);
            string encryptKey = locker.Encrypt(txtEncrytion.Text);
            string deencryptKey = locker.Decrypt(encryptKey);

            lblsonucorjin.Text = encryptKey;
            lblsonucsifreli.Text = deencryptKey;
        }

}
}
