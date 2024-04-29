using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnalysis
{
    public static class TextBoxExtension
    {
        // int? is a nullable int
        public static dynamic Digit(this TextBox textBox)
        {
            int value;
            if (int.TryParse(textBox.Text, out value))
            {
                return value;
            }
            return null;
        }
    }

    public static class DataGridViewExtension
    {
        public static void SaveToCsv(this DataGridView dataGridView)
        {
            CsvExporter.ExportToCsv(dataGridView);
        }
    }

    public static class ButtonExtension
    {
        public static void FitImage(this Button button, string imagePath, Size size)
        {
            Bitmap bitmap;

            bitmap = new Bitmap(imagePath);

            var cam_ico_new = new Bitmap(bitmap, size);
            button.Image = cam_ico_new;
            button.ForeColor = button.BackColor;
        }
    }

    public static class ConsoleExtension
    {
        public static void WriteWithColor(dynamic dynamic, ConsoleColor consoleColor = ConsoleColor.Blue)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(dynamic);
            Console.ResetColor();
        }
    }

    public static class BitmapExtension
    {
        public static Bitmap DeepClone(this Bitmap bitmap, PixelFormat pixelFormat = PixelFormat.Format24bppRgb)
        {
            return bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), pixelFormat);
        }

    }


    public static class ComboBoxExtension
    {
        public static void LoadDirectoryNames(this ComboBox comboBox, string dirPath)
        {
            try
            {
                foreach (string dirName in Directory.GetDirectories(dirPath))
                {
                    comboBox.Items.Clear();
                    comboBox.Items.Add(Path.GetFileName(dirName));
                }
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
