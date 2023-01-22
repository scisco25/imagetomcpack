using Newtonsoft.Json.Linq;
using System.IO.Compression;

namespace imagetomcpack
{
    public partial class Form1 : Form
    {
        public string selimgpath { get; set; }
        public string mcverstring { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verbox.DropDownStyle = ComboBoxStyle.DropDownList;
            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/.minecraft/versions"))
            {
                MessageBox.Show("Failed to find %appdata%/.minecraft/versions! please check that you have minecraft: java edition installed!", "Failed to find version folder", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }

            var versionfolders = Directory.EnumerateDirectories($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/.minecraft/versions").ToList();
            foreach (var versionfolder in versionfolders.ToList())
            {
                if (!versionfolder.Contains("-") && versionfolder.Split('.').Length - 1 >= 2)
                {
                    string verstring = versionfolder.Replace($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/.minecraft/versions\\", "");
                    if (File.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/.minecraft/versions\\{verstring}\\{verstring}.jar"))
                    {
                        verbox.Items.Add(verstring);
                    }
                }
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.imagepreview.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void chim_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog filediolog = new OpenFileDialog())
            {
                filediolog.Filter = "png files (*.png)|*.png";
                if(filediolog.ShowDialog() == DialogResult.OK)
                {
                    if ((Image.FromFile(filediolog.FileName).Width % 4) != 0 || (Image.FromFile(filediolog.FileName).Height % 4) != 0 || Image.FromFile(filediolog.FileName).Width != Image.FromFile(filediolog.FileName).Height)
                    {
                        MessageBox.Show("Image dimentions are not a multiple of 4 or are not a square shape.", "Invalid image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        selimgpath = filediolog.FileName;
                        imagelabel.Text = $"Selected Image: {selimgpath.Split("\\")[selimgpath.Split("\\").Length - 1]}";
                        imagepreview.Image = Image.FromFile(selimgpath);
                        if(mcverstring != null)
                        {
                            startbutton.Enabled = true;

                        }
                    }

                }
            }
        }

        private void verbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mcverstring = verbox.Items[verbox.SelectedIndex].ToString();
            if(selimgpath != null)
            {
                startbutton.Enabled = true;
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            DateTimeOffset curtime = DateTimeOffset.Now;
            startbutton.Enabled = false;
            dirtreecheck.Checked = false;
            Imgfilecheck.Checked = false;
            zipcheck.Checked = false;
            cleancheck.Checked = false;
            statustext.Text = "creating working path";
            string workingdir = $"{Path.GetTempPath()}mcpackcreator\\work\\";
            if (Directory.Exists(workingdir)) { Directory.Delete(workingdir, true);}
            Directory.CreateDirectory(workingdir);
            if(File.Exists($"{workingdir.Substring(0, workingdir.Length - 5)}{namebox.Text}.zip"))
            {
                File.Delete($"{workingdir.Substring(0, workingdir.Length - 5)}{namebox.Text}.zip");
            }
            statustext.Text = "Identifying resource pack version";
            int mcmajorver = int.Parse(mcverstring.Split(".")[1]);
            int mcminorver;
            try
            {
                mcminorver = int.Parse(mcverstring.Split(".")[2]);
            }
            catch
            {
                mcminorver = 0; 
            }
            List<string> invalidchar = new List<string> { "<", ">", ":", "\"", "/", "\\", "|", "?", "*" };
            if (invalidchar.Any(namebox.Text.Contains))
            {
                MessageBox.Show("Invalid Characters in resource pack name. cannot continue. windows disallows the characters <>:\"/\\|?* from file names", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startbutton.Enabled = true;
                statustext.Text = "idle";
                return;
            }
            if(namebox.Text == "")
            {
                MessageBox.Show("Resource pack name cannot be null. cannot continue", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startbutton.Enabled = true;
                statustext.Text = "idle";
                return;
            }
            if (desbox.Text == "")
            {
                MessageBox.Show("Resource pack description cannot be null. cannot continue", "Invalid description", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startbutton.Enabled = true;
                statustext.Text = "idle";
                return;
            }
            int resourcepackversion = 0;
            //IF CHAINS! yes I know gross.
            if (mcmajorver < 6)
            {
                MessageBox.Show("Resource packs are only supported as of 1.6.1. this tool has no support for texture packs.", "Invalid version", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startbutton.Enabled = true;
                statustext.Text = "idle";
                return;
            }
            else if (mcmajorver >= 6 && mcmajorver < 9) 
            {
                resourcepackversion = 1;
            }
            else if(mcmajorver >= 9 && mcmajorver < 11)
            {
                resourcepackversion = 2;
            }
            else if(mcmajorver >= 11 && mcmajorver < 13)
            {
                resourcepackversion = 3;
            }
            else if(mcmajorver >= 13 && mcmajorver < 15)
            {
                resourcepackversion=4;
            }
            else if(mcmajorver >= 15 && mcmajorver < 17 && mcminorver < 2)
            {
                resourcepackversion = 5;
            }
            else if(mcmajorver >= 16 && mcmajorver < 17 && mcminorver > 2)
            {
                resourcepackversion = 6;
            }
            else if(mcmajorver >= 17 && mcmajorver < 18)
            {
                resourcepackversion = 7;
            }
            else if(mcmajorver >= 18 && mcmajorver < 19)
            {
                resourcepackversion = 8;
            }
            else if(mcmajorver >= 19)
            {
                resourcepackversion = 9;
            }
            else
            {
                MessageBox.Show("Unreconized MC version detected. cannot continue.");
                startbutton.Enabled = true;
                statustext.Text = "idle";
                return;
            }


            statustext.Text = "parsing description";
            bool jsondes = true;
            try
            {
                JObject.Parse(desbox.Text);
            }
            catch
            {
                jsondes = false;
            }

            string safedes = "";
            if (jsondes)
            {
                safedes = desbox.Text;
            }
            else
            {
                safedes = $"\"{desbox.Text}\"";
            }

            statustext.Text = "writing pack.mcmeta";
            File.WriteAllText($"{workingdir}pack.mcmeta", $"{{\"pack\": {{\"pack_format\": {resourcepackversion},\"description\": {safedes}}}}}");
            statustext.Text = "locating version files";
            string mcjarpath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/.minecraft/versions/{mcverstring}/{mcverstring}.jar";
            if (!File.Exists(mcjarpath))
            {
                MessageBox.Show("Unable to location version jar. please ensure that this version actually exists");
                startbutton.Enabled = true;
                statustext.Text = "idle";
                return;
            }
            statustext.Text = "Enumerating jar tree";
            List<string> pngfiles = new List<string>();
            using (ZipArchive jar = ZipFile.OpenRead(mcjarpath))
            {
                foreach(ZipArchiveEntry entry in jar.Entries)
                {
                    if (entry.Name.Contains(".png") && !entry.Name.Contains(".mcmeta"))
                    {
                        pngfiles.Add(entry.FullName);
                    }
                }

            }
            statustext.Text = "Enumerating directorys";
            List<string> alldirs = new List<string>();
            foreach(string path in pngfiles)
            {
                if(path.LastIndexOf("/") != -1)
                {
                    alldirs.Add(path.Substring(0, path.LastIndexOf("/")));
                }
            }
            statustext.Text = "Writing skeleton to disk";
            foreach(string dir in alldirs)
            {
                Directory.CreateDirectory($"{workingdir}\\{dir}");
            }
            dirtreecheck.Checked = true;
            statustext.Text = "Writing Images to disk";
            foreach(string path in pngfiles)
            {
                File.Copy(selimgpath, $"{workingdir}\\{path}");
            }

            if (!fonttoggle.Checked)
            {
                Directory.Delete($"{workingdir}\\assets\\minecraft\\textures\\font", true);
            }

            Imgfilecheck.Checked = true;
            statustext.Text = "Compressing";
            ZipFile.CreateFromDirectory(workingdir,$"{workingdir.Substring(0,workingdir.Length - 5)}{namebox.Text}.zip",CompressionLevel.Optimal,false);
            zipcheck.Checked = true;
            statustext.Text = "Exporting";
            using(SaveFileDialog savedialog = new SaveFileDialog())
            {
                savedialog.Filter = "zip file (*.zip)|*.zip";
                savedialog.FileName = namebox.Text;
                bool dialogcontinue = true;

                while (dialogcontinue)
                {
                    var dialog = savedialog.ShowDialog();
                    dialogcontinue = false;
                    if ( dialog == DialogResult.OK)
                    {
                        if (File.Exists(savedialog.FileName)) { File.Delete(savedialog.FileName); }
                        File.Copy($"{workingdir.Substring(0, workingdir.Length - 5)}{namebox.Text}.zip", savedialog.FileName);
                    }
                    else if (dialog == DialogResult.Cancel)
                    {
                        if(MessageBox.Show("You have not specified a location to save the resource pack to. Do you wish to discard the resource pack?","No save location selected",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
                        {
                            dialogcontinue = true;
                        }
                    }
                }
            }
            statustext.Text = "Cleaning up";
            Directory.Delete(workingdir, true);
            File.Delete($"{workingdir.Substring(0, workingdir.Length - 5)}{namebox.Text}.zip");
            cleancheck.Checked = true;
            statustext.Text = "idle";
            startbutton.Enabled = true;
            MessageBox.Show("Resource pack creation complete.", $"Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}