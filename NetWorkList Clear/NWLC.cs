using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NetWorkList_Clear
{
    public partial class NWLC : Form
    {
        public NWLC()
        {
            InitializeComponent();

            InfoThread = new Thread(() =>
            {
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("NWLC --- NetWorkList Clear is an open-source project,\r\nyou can visit https://github.com/control0forver/NetWorkList-Clear to see it.\r\nOpen browser?", "Hello, I'm NWLC", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                    Process.Start("https://github.com/control0forver/NetWorkList-Clear");
            });
        }

        private RegistryKey registryKey = Registry.LocalMachine;

        private RegistryKey Profile;
        private string[] Profile_folders;
        private string[] Profile_Descriptions;
        private string[] Profile_Names;
        private string[] Profile_List;
        public readonly string Profile_Path =@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles";

        private RegistryKey SignatureUnamed;
        private string[] SignatureUnamed_folders;
        private string[] SignatureUnamed_Descriptions;
        private string[] SignatureUnamed_Names;
        private string[] SignatureUnamed_List;
        public readonly string SignatureUnamed_Path = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged";

        private Thread InfoThread = null;

        private void NWLC_Load(object sender, EventArgs e)
        {
            //Init
            InfoThread.Start();

            // Profile
            Profile = registryKey.OpenSubKey(Profile_Path);
            Profile_folders = Profile.GetSubKeyNames();

            Profile_Descriptions = new string[Profile_folders.Length];
            Profile_Names = new string[Profile_folders.Length];
            Profile_List = new string[Profile_folders.Length];
            for (int i = 0; i < Profile_folders.Length; i++)
            {
                Profile_Descriptions[i] = Profile.OpenSubKey(Profile_folders[i]).GetValue("Description").ToString();
                Profile_Names[i] = Profile.OpenSubKey(Profile_folders[i]).GetValue("ProfileName").ToString();
                Profile_List[i] = Profile_Descriptions[i];
            }
            profileList.Items.AddRange(Profile_List);
            label1.Text = profileList.Items.Count + " Items";

            // SignatureUnamed
            SignatureUnamed = registryKey.OpenSubKey(SignatureUnamed_Path);
            SignatureUnamed_folders = SignatureUnamed.GetSubKeyNames();

            SignatureUnamed_Descriptions = new string[SignatureUnamed_folders.Length];
            SignatureUnamed_Names = new string[SignatureUnamed_folders.Length];
            SignatureUnamed_List = new string[SignatureUnamed_folders.Length];
            for (int i = 0; i < SignatureUnamed_folders.Length; i++)
            {
                SignatureUnamed_Descriptions[i] = SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("Description").ToString();
                SignatureUnamed_Names[i] = SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("FirstNetwork").ToString();
                SignatureUnamed_List[i] = SignatureUnamed_Descriptions[i];
            }
            signatureUnamedList.Items.AddRange(SignatureUnamed_List);
            label2.Text = signatureUnamedList.Items.Count + " Items";
        }

        private void profileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Info;
            int i = profileList.SelectedIndex;

            Info = "Profile Info" +
                "\r\n (on "+ Profile_Path +")"+
                "\r\nNetwork Name(Description): " + Profile.OpenSubKey(Profile_folders[i]).GetValue("Description").ToString() +
                "\r\nReal Network Name: " + Profile.OpenSubKey(Profile_folders[i]).GetValue("ProfileName").ToString() +
                "\r\nProfile Folder Name: " + Profile_folders[i];

            textBox1.Text = Info;
        }

        private void signatureUnamedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Info;
            int i = signatureUnamedList.SelectedIndex;

            Info = "Unsignaure Unamed Info" +
                "\r\n (on " + SignatureUnamed_Path + ")" +
                "\r\nNetwork Name(Description): " + SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("Description").ToString() +
                "\r\nFirstNetwork Name: " + SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("FirstNetwork").ToString() +
                "\r\nProfile Folder Name: " + SignatureUnamed_folders[i];

            textBox2.Text = Info;
        }

        private void refresh_btn1_Click(object sender, EventArgs e)
        {
            profileList.Items.Clear();

            Profile = registryKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles");
            Profile_folders = Profile.GetSubKeyNames();

            Profile_Descriptions = new string[Profile_folders.Length];
            Profile_Names = new string[Profile_folders.Length];
            Profile_List = new string[Profile_folders.Length];
            for (int i = 0; i < Profile_folders.Length; i++)
            {
                Profile_Descriptions[i] = Profile.OpenSubKey(Profile_folders[i]).GetValue("Description").ToString();
                Profile_Names[i] = Profile.OpenSubKey(Profile_folders[i]).GetValue("ProfileName").ToString();
                Profile_List[i] = Profile_Descriptions[i];
            }
            profileList.Items.AddRange(Profile_List);
            label1.Text = profileList.Items.Count + " Items";
        }

        private void refresh_btn2_Click(object sender, EventArgs e)
        {
            signatureUnamedList.Items.Clear();

            SignatureUnamed = registryKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged");
            SignatureUnamed_folders = SignatureUnamed.GetSubKeyNames();

            SignatureUnamed_Descriptions = new string[SignatureUnamed_folders.Length];
            SignatureUnamed_Names = new string[SignatureUnamed_folders.Length];
            SignatureUnamed_List = new string[SignatureUnamed_folders.Length];
            for (int i = 0; i < SignatureUnamed_folders.Length; i++)
            {
                SignatureUnamed_Descriptions[i] = SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("Description").ToString();
                SignatureUnamed_Names[i] = SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("FirstNetwork").ToString();
                SignatureUnamed_List[i] = SignatureUnamed_Descriptions[i];
            }
            signatureUnamedList.Items.AddRange(SignatureUnamed_List);
            label2.Text = signatureUnamedList.Items.Count + " Items";
        }

        private bool AreYouSure()
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to DELETE?\r\nThe item you selected will be DELETED!!", "ARE YOU SURE?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Cancel) return false;
            return true;
        }

        private void del_btn1_Click(object sender, EventArgs e)
        {
            if (!AreYouSure()) return;

            // Get checked item index
            int[] checkedIndex = new int[profileList.Items.Count];
            int _i = 0;
            for (int i = 0; i < profileList.Items.Count; i++)
            {
                if (profileList.GetItemChecked(i))
                {
                    checkedIndex[_i] = i;
                    _i++;
                }
            }

            RegistryKey sys = registryKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles", true);
            // Delete Profiles
            for (int i = 0; i < profileList.CheckedItems.Count; i++)
            {
                try
                {
                    sys.DeleteSubKeyTree(Profile_folders[checkedIndex[i]]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
            }

            MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            refresh_btn1.PerformClick();
        }

        private void del_btn2_Click(object sender, EventArgs e)
        {
            if (!AreYouSure()) return;

            // Get checked item index
            int[] checkedIndex = new int[signatureUnamedList.Items.Count];
            int _i = 0;
            for (int i = 0; i < signatureUnamedList.Items.Count; i++)
            {
                if (signatureUnamedList.GetItemChecked(i))
                {
                    checkedIndex[_i] = i;
                    _i++;
                }
            }

            RegistryKey sys = registryKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged", true);
            // Delete SignatureUnamed
            for (int i = 0; i < signatureUnamedList.CheckedItems.Count; i++)
            {
                try
                {
                    sys.DeleteSubKeyTree(SignatureUnamed_folders[checkedIndex[i]]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return;
                }
            }

            MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            refresh_btn2.PerformClick();
        }

        private void SelectAll_btn1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < profileList.Items.Count; i++)
                profileList.SetItemChecked(i, true);
        }

        private void UnSelectAll_btn1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < profileList.Items.Count; i++)
                profileList.SetItemChecked(i, false);
        }

        private void SelectAll_btn2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < signatureUnamedList.Items.Count; i++)
                signatureUnamedList.SetItemChecked(i, true);
        }

        private void UnSelectAll_btn2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < signatureUnamedList.Items.Count; i++)
                signatureUnamedList.SetItemChecked(i, false);
        }
    }
}
