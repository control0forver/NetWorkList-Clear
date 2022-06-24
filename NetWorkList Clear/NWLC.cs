using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace NetWorkList_Clear
{
    public partial class NWLC : Form
    {
        public NWLC()
        {
            InitializeComponent();
        }

        private RegistryKey registryKey = Registry.LocalMachine;

        private RegistryKey Profile;
        private string[] Profile_folders;
        private string[] Profile_Descriptions;
        private string[] Profile_Names;
        private string[] Profile_List;

        private RegistryKey SignatureUnamed;
        private string[] SignatureUnamed_folders;
        private string[] SignatureUnamed_Descriptions;
        private string[] SignatureUnamed_Names;
        private string[] SignatureUnamed_List;

        private void NWLC_Load(object sender, EventArgs e)
        {
            //Init
            MessageBox.Show("");

            // Profile
            Profile = registryKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles");
            Profile_folders = Profile.GetSubKeyNames();

            Profile_Descriptions = new string[Profile_folders.Length];
            Profile_Names = new string[Profile_folders.Length];
            Profile_List = new string[Profile_folders.Length];
            for (int i = 0; i < Profile_folders.Length; i++)
            {
                Profile_Descriptions[i] = Profile.OpenSubKey(Profile_folders[i]).GetValue("Description").ToString();
                Profile_Names[i] = Profile.OpenSubKey(Profile_folders[i]).GetValue("ProfileName").ToString();
                Profile_List[i] =  Profile_Descriptions[i];
            }
            profileList.Items.AddRange(Profile_List);
            label1.Text = profileList.Items.Count + " Items";

            // SignatureUnamed
            SignatureUnamed = registryKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged");
            SignatureUnamed_folders = SignatureUnamed.GetSubKeyNames();

            SignatureUnamed_Descriptions = new string[SignatureUnamed_folders.Length];
            SignatureUnamed_Names = new string[SignatureUnamed_folders.Length];
            SignatureUnamed_List = new string[SignatureUnamed_folders.Length];
            for (int i = 0; i < Profile_folders.Length; i++)
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
                "\r\nNetwork Name(Description): " + SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("Description").ToString() +
                "\r\nFirstNetwork Name: " + SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("FirstNetwork").ToString() +
                "\r\nProfile Folder Name: " + SignatureUnamed_folders[i];

            textBox2.Text = Info;
        }

        private void refresh_btn1_Click(object sender, EventArgs e)
        {
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
            SignatureUnamed = registryKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged");
            SignatureUnamed_folders = SignatureUnamed.GetSubKeyNames();

            SignatureUnamed_Descriptions = new string[SignatureUnamed_folders.Length];
            SignatureUnamed_Names = new string[SignatureUnamed_folders.Length];
            SignatureUnamed_List = new string[SignatureUnamed_folders.Length];
            for (int i = 0; i < Profile_folders.Length; i++)
            {
                SignatureUnamed_Descriptions[i] = SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("Description").ToString();
                SignatureUnamed_Names[i] = SignatureUnamed.OpenSubKey(SignatureUnamed_folders[i]).GetValue("FirstNetwork").ToString();
                SignatureUnamed_List[i] = SignatureUnamed_Descriptions[i];
            }
            signatureUnamedList.Items.AddRange(SignatureUnamed_List);
            label2.Text = signatureUnamedList.Items.Count + " Items";
        }

        private void del_btn1_Click(object sender, EventArgs e)
        {
            refresh_btn1.PerformClick();
        }

        private void del_btn2_Click(object sender, EventArgs e)
        {
            refresh_btn2.PerformClick();
        }
    }
}
