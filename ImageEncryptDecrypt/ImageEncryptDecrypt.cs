using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Computer Graphics
 * Midterm Project
 ****************
 * This program makes encrypted images with self alogrithm
 * Images can encrypt with a key or default key
 * Images can be RGB, grayscale etc.
 * ----
 * There are 2 modes available easy/fast mode (default) and hard/slow mode
 * Easy/fast mode uses lockBits and unlockBits 
 * Hard/slow mode uses getPixel and setPixel
 * Choose hard/slow mode for more complex encryption algorithm
 ****************
 * Author : myoluk
 * Date : 12.06.2020 (6 December 2020)
 */

namespace ImageEncryptDecrypt
{
    public partial class ImageEncryptDecrypt : Form
    {
        public ImageEncryptDecrypt()
        {
            InitializeComponent();
        }

        // There 2 modes: hard/slow and easy/fast
        // Default mode is easy/fast (_mode = false)
        // hard/slow mode use getPixel & setPixel
        // easy/fast mode use lockBits & unlockBits
        bool _mode = false;

        // Default key if radiobutton "Set password for me" is set
        string _defaultPassword = "D2@@v!X5WZ_D9muU7um96?3s_fpU_-Q*";

        // keyAscii variables get every password character's ASCII codes
        // keyAscii refers full password characters
        // keyAsciiR refers red colors from RGB
        // keyAsciiG refers green colors from RGB
        // keyAsciiB refers blue colors from RGB
        int[] _keyAscii, _keyAsciiR, _keyAsciiG, _keyAsciiB;

        // keyAsciiIndex variables get every password character's index number to assign new values
        // keyAsciiR refers red colors's index
        // keyAsciiG refers green colors's index
        // keyAsciiB refers blue colors's index
        int _keyAsciiIndexR = 0, _keyAsciiIndexG = 0, _keyAsciiIndexB = 0;

        private void MST_ImageEncryptorDecryptor_Load(object sender, EventArgs e)
        {
            // When form load

        }

        // Open image
        void OpenImage()
        {
            // Open an image to encryption
            // Open an image to decryption
            FileDialog imgChooser = new OpenFileDialog();
            imgChooser.Filter = "Image Files (*.jpg) | *.jpg";
            if (imgChooser.ShowDialog() == DialogResult.OK)
            {
                pbxImage.ImageLocation = imgChooser.FileName;
            }
        }

        // Save image
        void SaveImage()
        {
            // Save the encrypted image
            // Check if any image opened
            if (pbxEncryptedDecrypted.Image == null)
            {
                MessageBox.Show("There is no encrypted/decrypted image.\nOpen an image after try encryption or decryption.",
                    "No Image Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save the encrypted image as .jpg
            FileDialog imgSaver = new SaveFileDialog();
            imgSaver.Filter = "Image Files (*.jpg) | *.jpg";
            if (imgSaver.ShowDialog() == DialogResult.OK)
            {
                pbxEncryptedDecrypted.Image.Save(imgSaver.FileName);
            }
        }

        private void menuMainItemFileOpen_Click(object sender, EventArgs e)
        {
            // Open image (jpg)
            OpenImage();
        }

        private void menuMainItemFileSave_Click(object sender, EventArgs e)
        {
            // Save image (jpg)
            SaveImage();
        }

        private void menuMainItemFileExit_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }

        private void menuMainItemHelpAbout_Click(object sender, EventArgs e)
        {
            // About
            MessageBox.Show("This program makes encrypted images with default key or optional set key.\n\n" +
                "There are 2 modes available. Easy/Fast mode which is default and Hard/Slow mode.\n" +
                "Easy/Fast method uses lockBits & unlockBits.\n" +
                "Hard/Slow method uses getPixel & setPixel.\n" +
                "___\n" +
                "Created by myoluk ©2020", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Hide/Show password
        private void cbxHide_CheckedChanged(object sender, EventArgs e)
        {
            // Hide password if checked
            if (cbxHide.Checked == true)
                tbxPassword.UseSystemPasswordChar = true;
            // Show password otherwise
            else
                tbxPassword.UseSystemPasswordChar = false;
        }

        // Encryption Mode
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Check mode (easy/fast or hard/slow)
            if (!_mode)
                EncryptEasyMode();
            else
                EncryptHardMode();
        }

        // Encryption (easy/fast method)
        // This method makes encrypted images with key
        // Uses lockBits & unlockBits
        // Dafult key defines with global variable
        // Optional key made 256 characters length with defines algorithm
        void EncryptEasyMode()
        {
            // Image Encryption
            // easy/fast mode (_mode = true)
            // Return if no image file opened
            if (pbxImage.Image == null)
            {
                MessageBox.Show("Open an image file.", "No Image Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get key's ASCII values
            // Set mode if password is defined by user or default
            if (rbtnDefault.Checked)
                UseUserPassword(false);
            else
                UseUserPassword(true);

            // img : Source image
            Bitmap img = new Bitmap(pbxImage.Image);
            int imgWidth = img.Width;
            int imgHeight = img.Height;

            // imgData : Source image data
            BitmapData imgData = img.LockBits(
                new Rectangle(0, 0, imgWidth, imgHeight),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb
                );

            // imgAdress : Source image address
            // byte_img : Byte array for copy source image as array
            IntPtr imgAddress = imgData.Scan0;
            byte[] byte_img = new byte[imgData.Stride * imgHeight];

            // Copy source image
            Marshal.Copy(
                imgAddress,
                byte_img,
                0,
                imgData.Stride * imgHeight
                );

            // img2 : Target (encrypted) image
            // img2Data : Target (encrypted) image data
            Bitmap img2 = new Bitmap(imgWidth, imgHeight);
            BitmapData img2Data = img2.LockBits(
                new Rectangle(0, 0, imgWidth, imgHeight),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb
                );

            // img2Address : Target (encrypted) image address
            // byte_img2 : Byte array for copy target image as array
            IntPtr img2Address = img2Data.Scan0;
            byte[] byte_img2 = new byte[img2Data.Stride * imgHeight];

            // Encryption Algorithm
            // Color changing
            for (int i = 0; i < img2Data.Stride * imgHeight; i += 3)
            {
                // red
                if ((i + 0) == img2Data.Stride * imgHeight) break;
                byte red = byte_img[i + 0];
                byte_img2[i + 0] = Convert.ToByte((red + _keyAsciiR[(_keyAsciiIndexR++) % _keyAsciiR.Length]) % 256);
                // green
                if ((i + 1) == img2Data.Stride * imgHeight) break;
                byte green = byte_img[i + 1];
                byte_img2[i + 1] = Convert.ToByte((green + _keyAsciiG[(_keyAsciiIndexG++) % _keyAsciiG.Length]) % 256);
                // blue
                if ((i + 2) == img2Data.Stride * imgHeight) break;
                byte blue = byte_img[i + 2];
                byte_img2[i + 2] = Convert.ToByte((blue + _keyAsciiB[(_keyAsciiIndexB++) % _keyAsciiB.Length]) % 256);
            }
            // Folding
            // Transfer first half of image to second half of image
            int j = (img2Data.Stride * imgHeight) / 2;
            for (int i = 0; i < (img2Data.Stride * imgHeight) / 2; i++)
            {
                byte temp = byte_img2[i];
                byte_img2[i] = byte_img2[j];
                byte_img2[j++] = temp;
            }

            // Copy target (encrypted) image
            Marshal.Copy(
                byte_img2,
                0,
                img2Address,
                img2Data.Stride * imgHeight
                );

            // UnlockBits to use
            img.UnlockBits(imgData);
            img2.UnlockBits(img2Data);

            // show target (encrypted/decrypted) image on picturebox
            pbxEncryptedDecrypted.Image = img2;
        }

        // Encryption (hard/slow method)
        // This method makes encrypted images with key
        // Uses getPixel & setPixel
        // Dafult key defines with global variable
        // Optional key made 256 characters length with defines algorithm
        void EncryptHardMode()
        {
            // Image Encryption
            // hard/slow mode (_mode = false)
            // Return if no image file opened
            if (pbxImage.Image == null)
            {
                MessageBox.Show("Open an image file.", "No Image Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get key's ASCII values
            // Set mode if password is defined by user or default
            if (rbtnDefault.Checked)
                UseUserPassword(false);
            else
                UseUserPassword(true);

            // img : Source image
            Bitmap img = new Bitmap(pbxImage.Image);
            int imgWidth = img.Width;
            int imgHeight = img.Height;

            // img2 : Target (encrypted) image
            Bitmap img2 = new Bitmap(imgWidth, imgHeight);

            // Encryption Algorithm
            for (int n = 0; n < 3; n++)
            {
                // Color changing
                // Get pixel by rows and columns
                for (int row = 0; row < imgHeight; row++)
                {
                    for (int column = 0; column < imgWidth; column++)
                    {
                        // Get color of pixel
                        Color imgColor = img.GetPixel(column, row);

                        // Assign color to variables
                        byte red = imgColor.R;
                        byte green = imgColor.G;
                        byte blue = imgColor.B;

                        // Change color
                        red = Convert.ToByte((red + _keyAsciiR[(_keyAsciiIndexR++) % _keyAsciiR.Length]) % 256);
                        green = Convert.ToByte((green + _keyAsciiG[(_keyAsciiIndexG++) % _keyAsciiG.Length]) % 256);
                        blue = Convert.ToByte((blue + _keyAsciiB[(_keyAsciiIndexB++) % _keyAsciiB.Length]) % 256);

                        // Assign new colors to img2 (encrypted) image
                        img2.SetPixel(column, row, Color.FromArgb(255, red, green, blue));
                    }
                }

                // Horizontal Folding
                // Jump 1 row every 2 rows
                for (int row = 0; row < imgHeight / 2; row += 2)
                {
                    for (int column = 0; column < imgWidth; column++)
                    {
                        Color img2Color = img2.GetPixel(column, row);
                        Color tempColor = img2.GetPixel(column, imgHeight / 2 + row);
                        img2.SetPixel(column, row, tempColor);
                        img2.SetPixel(column, imgHeight / 2 + row, img2Color);
                    }
                }

                // Vertical Folding
                // Jump 1 column every 2 columns
                for (int row = 0; row < imgHeight; row++)
                {
                    for (int column = 0; column < imgWidth / 2; column += 2)
                    {
                        Color img2Color = img2.GetPixel(column, row);
                        Color tempColor = img2.GetPixel(imgWidth / 2 + column, row);
                        img2.SetPixel(column, row, tempColor);
                        img2.SetPixel(imgWidth / 2 + column, row, img2Color);
                    }
                }
            }

            // Assign img2 (encrypted) image to picturebox
            pbxEncryptedDecrypted.Image = img2;
        }

        // Decryption Mode
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Check mode (easy/fast or hard/slow)
            if (!_mode)
                DecryptEasyMode();
            else
                DecryptHardMode();
        }

        // Decryption (easy/fast method)
        // This method makes decrypted images with key
        // Uses lockBits & unlockBits
        // Dafult key defines with global variable
        // Optional key made 256 characters length with defines algorithm
        void DecryptEasyMode()
        {
            // Image Decryption
            // easy/fast mode (_mode = true)
            // Return if no image file opened
            if (pbxImage.Image == null)
            {
                MessageBox.Show("Open an image file.", "No Image Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get key's ASCII values
            // Set mode if password is defined by user or default
            if (rbtnDefault.Checked)
                UseUserPassword(false);
            else
                UseUserPassword(true);

            // img : Source image
            Bitmap img = new Bitmap(pbxImage.Image);
            int imgWidth = img.Width;
            int imgHeight = img.Height;

            // imgData : Source image data
            BitmapData imgData = img.LockBits(
                new Rectangle(0, 0, imgWidth, imgHeight),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb
                );

            // imgAdress : Source image address
            // byte_img : Byte array for copy source image as array
            IntPtr imgAddress = imgData.Scan0;
            byte[] byte_img = new byte[imgData.Stride * imgHeight];

            // Copy source image
            Marshal.Copy(
                imgAddress,
                byte_img,
                0,
                imgData.Stride * imgHeight
                );

            // img2 : Target (encrypted/decrypted) image
            // img2Data : Target (encrypted/decrypted) image data
            Bitmap img2 = new Bitmap(imgWidth, imgHeight);
            BitmapData img2Data = img2.LockBits(
                new Rectangle(0, 0, imgWidth, imgHeight),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb
                );

            // img2Address : Target (encrypted/decrypted) image address
            // byte_img2 : Byte array for copy target image as array
            IntPtr img2Address = img2Data.Scan0;
            byte[] byte_img2 = new byte[img2Data.Stride * imgHeight];

            // Decryption Algoritm
            // Color changing
            for (int i = 0; i < img2Data.Stride * imgHeight; i += 3)
            {
                // red
                if ((i + 0) == img2Data.Stride * imgHeight) break;
                byte red = byte_img[i + 0];
                if (red - _keyAsciiR[(_keyAsciiIndexR) % _keyAscii.Length] < 0)
                    byte_img2[i + 0] = Convert.ToByte(256 - (_keyAsciiR[(_keyAsciiIndexR++) % _keyAsciiR.Length] - red));
                else
                    byte_img2[i + 0] = Convert.ToByte(red - _keyAscii[(_keyAsciiIndexR++) % _keyAsciiR.Length]);

                // green
                if ((i + 1) == img2Data.Stride * imgHeight) break;
                byte green = byte_img[i + 1];
                if (green - _keyAsciiG[(_keyAsciiIndexG) % _keyAscii.Length] < 0)
                    byte_img2[i + 1] = Convert.ToByte(256 - (_keyAsciiG[(_keyAsciiIndexG++) % _keyAsciiG.Length] - green));
                else
                    byte_img2[i + 1] = Convert.ToByte(green - _keyAscii[(_keyAsciiIndexG++) % _keyAsciiG.Length]);

                // blue
                if ((i + 2) == img2Data.Stride * imgHeight) break;
                byte blue = byte_img[i + 2];
                if (blue - _keyAsciiB[(_keyAsciiIndexB) % _keyAscii.Length] < 0)
                    byte_img2[i + 2] = Convert.ToByte(256 - (_keyAsciiB[(_keyAsciiIndexB++) % _keyAsciiB.Length] - blue));
                else
                    byte_img2[i + 2] = Convert.ToByte(blue - _keyAscii[(_keyAsciiIndexB++) % _keyAsciiB.Length]);
            }

            // Folding
            // Transfer first half of image to second half of image
            int j = (img2Data.Stride * imgHeight) / 2;
            for (int i = 0; i < (img2Data.Stride * imgHeight) / 2; i++)
            {
                byte temp = byte_img2[i];
                byte_img2[i] = byte_img2[j];
                byte_img2[j++] = temp;
            }

            // Copy target (encrypted/decrypted) image
            Marshal.Copy(
                byte_img2,
                0,
                img2Address,
                img2Data.Stride * imgHeight
                );

            // UnlockBits to use
            img.UnlockBits(imgData);
            img2.UnlockBits(img2Data);

            // show target (encrypted/decrypted) image on picturebox
            pbxEncryptedDecrypted.Image = img2;
        }

        // Decryption (hard/slow method)
        // This method makes decrypted images with key
        // Uses getPixel & setPixel
        // Dafult key defines with global variable
        // Optional key made 256 characters length with defines algorithm
        void DecryptHardMode()
        {
            // Image Decryption
            // hard/slow mode (_mode = false)
            // Return if no image file opened
            if (pbxImage.Image == null)
            {
                MessageBox.Show("Open an image file.", "No Image Found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get key's ASCII values
            // Set mode if password is defined by user or default
            if (rbtnDefault.Checked)
                UseUserPassword(false);
            else
                UseUserPassword(true);

            // img : Source image
            Bitmap img = new Bitmap(pbxImage.Image);
            int imgWidth = img.Width;
            int imgHeight = img.Height;

            // img2 : Target (decrypted) image
            Bitmap img2 = new Bitmap(imgWidth, imgHeight);

            // Decryption Algorithm
            for (int n = 0; n < 3; n++)
            {
                // Vertical Folding
                // Jump 1 column every 2 columns
                for (int row = 0; row < imgHeight; row++)
                {
                    for (int column = 0; column < imgWidth / 2; column += 2)
                    {
                        Color imgColor = img.GetPixel(column, row);
                        Color tempColor = img.GetPixel(imgWidth / 2 + column, row);
                        img.SetPixel(column, row, tempColor);
                        img.SetPixel(imgWidth / 2 + column, row, imgColor);
                    }
                }

                // Horizontal Folding
                // Jump 1 row every 2 rows
                for (int row = 0; row < imgHeight / 2; row += 2)
                {
                    for (int column = 0; column < imgWidth; column++)
                    {
                        Color imgColor = img.GetPixel(column, row);
                        Color tempColor = img.GetPixel(column, imgHeight / 2 + row);
                        img.SetPixel(column, row, tempColor);
                        img.SetPixel(column, imgHeight / 2 + row, imgColor);
                    }
                }

                // Color changing
                // Get pixel by rows and columns
                for (int row = 0; row < imgHeight; row++)
                {
                    for (int column = 0; column < imgWidth; column++)
                    {
                        // Get color of pixel
                        Color imgColor = img.GetPixel(column, row);

                        // Assign color to variables
                        byte red = imgColor.R;
                        byte green = imgColor.G;
                        byte blue = imgColor.B;

                        // Change color (original image's colors)
                        // red
                        if (red - _keyAsciiR[(_keyAsciiIndexR) % _keyAsciiR.Length] < 0)
                            red = Convert.ToByte(256 - (_keyAsciiR[(_keyAsciiIndexR++) % _keyAsciiR.Length] - red));
                        else
                            red = Convert.ToByte(red - _keyAsciiR[(_keyAsciiIndexR++) % _keyAsciiR.Length]);

                        // green
                        if (green - _keyAsciiG[(_keyAsciiIndexG) % _keyAsciiG.Length] < 0)
                            green = Convert.ToByte(256 - (_keyAsciiG[(_keyAsciiIndexG++) % _keyAsciiG.Length] - green));
                        else
                            green = Convert.ToByte(green - _keyAsciiG[(_keyAsciiIndexG++) % _keyAsciiG.Length]);

                        // blue
                        if (blue - _keyAsciiB[(_keyAsciiIndexB) % _keyAsciiB.Length] < 0)
                            blue = Convert.ToByte(256 - (_keyAsciiB[(_keyAsciiIndexB++) % _keyAsciiB.Length] - blue));
                        else
                            blue = Convert.ToByte(blue - _keyAsciiB[(_keyAsciiIndexB++) % _keyAsciiB.Length]);

                        // Assign new colors to img2 (decrypted) image
                        img2.SetPixel(column, row, Color.FromArgb(255, red, green, blue));
                    }
                }
            }

            // Assign img2 (decrypted) image to picturebox
            pbxEncryptedDecrypted.Image = img2;
        }

        private void menuMainItemHelpContact_Click(object sender, EventArgs e)
        {
            // Contact
            MessageBox.Show("github.com/myoluk", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void menuMainItemModeHard_Click(object sender, EventArgs e)
        {
            // hard/slow mode on
            _mode = true;
            this.Text = "Image Encrypt/Decrypt (Hard/Slow Mode)";
        }

        private void menuMainItemModeEasy_Click(object sender, EventArgs e)
        {
            // easy/fast mode on
            _mode = false;
            this.Text = "Image Encrypt/Decrypt";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Open image (jpg)
            OpenImage();
        }

        private void menuMainItemFileClear_Click(object sender, EventArgs e)
        {
            // Clear Form
            pbxImage.Image = null;
            pbxEncryptedDecrypted.Image = null;
            tbxPassword.Clear();
            rbxEncryptedPassword.Clear();
            rbtnDefault.Checked = true;
            cbxHide.Checked = false;
            gbxEncryptedPassword.Text = "Encrypted Password";
            // reset AsciiIndexes
            _keyAsciiIndexR = _keyAsciiIndexG = _keyAsciiIndexB = 0;
            // Open button focus
            btnOpen.Focus();
        }

        private void pbxImage_Click(object sender, EventArgs e)
        {
            // One left click on picturebox
            // Open image (jpg)
            OpenImage();
        }

        private void ctxmsSaveSave_Click(object sender, EventArgs e)
        {
            // Right click > Save
            // Save image (jpg)
            SaveImage();
        }

        private void ctxmsSaveDelete_Click(object sender, EventArgs e)
        {
            // Right click > Delete
            // Delete encrypted/decrypted image
            pbxEncryptedDecrypted.Image = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save image (jpg)
            SaveImage();
        }

        private void rbtnDefault_CheckedChanged(object sender, EventArgs e)
        {
            // Use default password
            // Disable password area
            gbxSetPassword.Enabled = false;
        }

        private void rbtnSetPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Use user password
            // Enable password area
            gbxSetPassword.Enabled = true;
            tbxPassword.Focus();    //focus password area
        }

        // If mode false then use default password
        // If mode true than use defined user password
        void UseUserPassword(bool mode)
        {
            if (!mode)  // use default password
                GetKeyAscii(_defaultPassword);
            else        // use user password
            {
                // Checking if no password entered
                if (tbxPassword.Text == "")
                {
                    MessageBox.Show("Password required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GetKeyAscii(tbxPassword.Text);
            }
        }

        // This method convert every password's character to Ascii codes
        // This is makes password 256 characters that less than 256
        void GetKeyAscii(string pass)
        {
            // reset AsciiIndexes
            _keyAsciiIndexR = _keyAsciiIndexG = _keyAsciiIndexB = 0;

            // if password entered continue
            // Make password 256 chracter
            byte j = 0;
            string orgKey = pass;
            string key = pass;
            while (key.Length < 256)
            {
                if (j == orgKey.Length)     // equals to % of orgKey
                    j = 0;
                key += orgKey[j++];         // add user's key again and again unless be 256 characters
            }

            // Changing gbxEncryptedPassword title and content
            rbxEncryptedPassword.Clear();
            gbxEncryptedPassword.Text = "Encrypted Password (" + key.Length + ")";
            rbxEncryptedPassword.Text = key;

            // Create keyAscii variables as int arrays to making mix algorithm
            _keyAscii = _keyAsciiR = _keyAsciiG = _keyAsciiB = new int[key.Length];
            // Taking % 256 make a loop for chracters that have high Ascii code than 256
            // Get key's ascii values for red colors. Start from first index to last
            for (int i = 0; i < key.Length; i++)
                _keyAsciiR[i] = ((int)key[i]) % 256;
            // Get key's ascii values for green colors. Start from last index to first
            for (int i = key.Length - 1; i <= 0; i--)
                _keyAsciiG[i] = ((int)key[i]) % 256;
            // Get key's ascii values for blue colors. Start from first index to last
            for (int i = 0; i < key.Length; i++)
                _keyAsciiB[i] = ((int)key[i] * i) % 256;

            // reset AsciiIndexes
            _keyAsciiIndexR = _keyAsciiIndexG = _keyAsciiIndexB = 0;
        }
    }
}
