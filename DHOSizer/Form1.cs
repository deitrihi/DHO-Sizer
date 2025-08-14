using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DHOSizer
{
	public partial class Form1 : Form
	{
		public class SizerData
		{
			public int X { get; set; }
			public int Y { get; set; }
			public int Width { get; set; }
			public int Height { get; set; }

			public void SetValue(string value)
			{
				string[] values = value.Split(',');
				if (values.Count() == 6)
				{
					X = int.Parse(values[0]);
					Y = int.Parse(values[1]);
					Width = int.Parse(values[2]);
					Height = int.Parse(values[3]);
				}
			}

			public string GetValue()
			{
				return $"{X},{Y},{Width},{Height},22,1";
			}
		}

		private List<SizerData> SizerDatas = new List<SizerData>();
        private Configuration config;

        public Form1()
		{
			InitializeComponent();
			ReadFile();
		}

        private void ReadFile()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            TopMost = Boolean.Parse(config.AppSettings.Settings["TopMost"]?.Value ?? "True");
            chkMostTop.Checked = TopMost;
            int count = int.Parse(config.AppSettings.Settings[$"Client_Count"]?.Value ?? "1");
            for (int i = 0; i < count; i++)
            {
                SizerData sizer = new SizerData();
                sizer.SetValue(config.AppSettings.Settings[$"Client_{i}"]?.Value ?? "0,0,800,600,22,1");
                SizerDatas.Add(sizer);
                SetControllerValue(i, sizer);
            }
        }

		private void SaveFile()
		{
            config.AppSettings.Settings["TopMost"].Value = TopMost.ToString();
            for (int i = 0; i < SizerDatas.Count; i++)
            {
                config.AppSettings.Settings[$"Client_{i}"].Value = SizerDatas[i].GetValue();
            }

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
		}

        private void SetControllerValue(int index, SizerData sizer)
        {
            switch (index)
            {
                case 0:
                    tbX1.Text = sizer.X.ToString();
                    tbY1.Text = sizer.Y.ToString();
                    tbWidth1.Text = sizer.Width.ToString();
                    tbHeight1.Text = sizer.Height.ToString();
                    break;
                case 1:
                    tbX2.Text = sizer.X.ToString();
                    tbY2.Text = sizer.Y.ToString();
                    tbWidth2.Text = sizer.Width.ToString();
                    tbHeight2.Text = sizer.Height.ToString();
                    break;
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
			RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\KOEI\GV Online Kr\window", true);
			if (reg != null)
			{
				string value = SizerDatas[0].GetValue();
				reg.SetValue("select_device", value);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\KOEI\GV Online Kr\window", true);
			if (reg != null)
			{
				//"1030,0,800,600,22,1"
				string value = SizerDatas[1].GetValue();
				reg.SetValue("select_device", value);
			}
		}

		private void tbX1_TextChanged(object sender, EventArgs e)
		{
			SizerDatas[0].X = int.Parse(tbX1.Text);
			SaveFile();
		}

		private void tbY1_TextChanged(object sender, EventArgs e)
		{
			SizerDatas[0].Y = int.Parse(tbY1.Text);
			SaveFile();
		}

		private void tbWidth1_TextChanged(object sender, EventArgs e)
		{
			SizerDatas[0].Width = int.Parse(tbWidth1.Text);
			SaveFile();
		}

		private void tbHeight1_TextChanged(object sender, EventArgs e)
		{
			SizerDatas[0].Height = int.Parse(tbHeight1.Text);
			SaveFile();
		}

		private void tbX2_TextChanged(object sender, EventArgs e)
		{
			SizerDatas[1].X = int.Parse(tbX2.Text);
			SaveFile();
		}

		private void tbY2_TextChanged(object sender, EventArgs e)
		{
			SizerDatas[1].Y = int.Parse(tbY2.Text);
			SaveFile();
		}

		private void tbWidth2_TextChanged(object sender, EventArgs e)
		{
			SizerDatas[1].Width = int.Parse(tbWidth2.Text);
			SaveFile();
		}

		private void tbHeight2_TextChanged(object sender, EventArgs e)
		{
			SizerDatas[1].Height = int.Parse(tbHeight2.Text);
			SaveFile();
		}

		private void chkMostTop_CheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = chkMostTop.Checked;
            SaveFile();
        }

		private void tbnGet1_Click(object sender, EventArgs e)
		{
			RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\KOEI\GV Online Kr\window", true);
			SizerDatas[0].SetValue(reg.GetValue("select_device").ToString());
			tbX1.Text = SizerDatas[0].X.ToString();
			tbY1.Text = SizerDatas[0].Y.ToString();
			tbWidth1.Text = SizerDatas[0].Width.ToString();
			tbHeight1.Text = SizerDatas[0].Height.ToString();
			SaveFile();
		}

		private void btnGet2_Click(object sender, EventArgs e)
		{
			RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"Software\KOEI\GV Online Kr\window", true);
			SizerDatas[1].SetValue(reg.GetValue("select_device").ToString());
			tbX2.Text = SizerDatas[1].X.ToString();
			tbY2.Text = SizerDatas[1].Y.ToString();
			tbWidth2.Text = SizerDatas[1].Width.ToString();
			tbHeight2.Text = SizerDatas[1].Height.ToString();
			SaveFile();
		}
	}
}
