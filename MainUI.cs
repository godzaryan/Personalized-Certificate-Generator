using ImageMagick;
using ImageMagick.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devil;
using System.Timers;
using Timer = System.Timers.Timer;
using System.IO;
using static Auto_Certificate_Sender.Functions;
using System.Net.Http;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Auto_Certificate_Sender
{
    public partial class MainUI: Form
    {
        public MainUI()
        {
            InitializeComponent();
            UXWorker fm = new UXWorker();
            fm.CustomFormMover(__formMover, this);
        }

        private void __closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void __minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (autoSendEmailCb.Checked)
            {
                includeAttachmentCb.Enabled = true;
                subjectTb.Enabled = true;
                messageTb.Enabled = true;
                label4.Enabled = true;
                label5.Enabled = true;
            }
            else if (!autoSendEmailCb.Checked)
            {
                includeAttachmentCb.Enabled = false;
                subjectTb.Enabled = false;
                messageTb.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
            }
        }

        private void _statusLbl_TextChanged(object sender, EventArgs e)
        {
            if (_statusLbl.Text == "Idle")
            {
                _statusLbl.ForeColor = Color.Yellow;
            }
            else if (_statusLbl.Text == "Generating...")
            {
                _statusLbl.ForeColor = Color.DodgerBlue;
            }
            else if (_statusLbl.Text == "Success")
            {
                _statusLbl.ForeColor = Color.SpringGreen;

                Timer tmr = new Timer();
                tmr.Interval = 5000;
                tmr.Enabled = true;
                tmr.AutoReset = false;
                tmr.Elapsed += Tmr_Elapsed;
                tmr.Start();
            }
            else if (_statusLbl.Text == "Error")
            {
                _statusLbl.ForeColor = Color.Tomato;

                Timer tmr = new Timer();
                tmr.Interval = 5000;
                tmr.Enabled = true;
                tmr.AutoReset = false;
                tmr.Elapsed += Tmr_Elapsed;
                tmr.Start();
            }
        }

        private void Tmr_Elapsed(object sender, ElapsedEventArgs e)
        {
            _statusLbl.Invoke((MethodInvoker)(() => _statusLbl.Text = "Idle"));
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(emailInput.Text))
                {
                    var studData = File.ReadAllLines(emailInput.Text);
                    int counter = 1;
                    foreach (var cur in studData)
                    {
                        var name = cur.Split(',')[0];
                        var email = cur.Split(',')[1];

                        List<TextSpec> texts = new List<TextSpec>
                        {
                            new TextSpec
                            {
                                Text = name,
                                FontPath = "Urbanist.ttf",
                                FontSize = 165,
                                Color = MagickColor.FromRgb(37, 67, 217),
                                X = 520,
                                Y = 1422
                            }
                        };

                        SetStatus("Generating...");
                        SetStatus("Generating Image... (" + counter.ToString() + "/" + studData.Length.ToString() + ")");
                        Task.Run(() => Functions.AddTextsFlexible(imagePath: "template.jpg", texts: texts, xCenterMode: CenterMode.None, yCenterMode: CenterMode.None, outputImagePath: "Certificates\\" + name + ".jpg")).Wait();

                        if (autoSendEmailCb.Checked)
                        {
                            SetStatus("Sending Email... (" + counter.ToString() + "/" + studData.Length.ToString() + ")");

                            if (includeAttachmentCb.Checked)
                            {
                                Task.Run(() => Functions.SendMessage(subjectTb.Text, email, messageTb.Text.Replace("{name}", name), "Certificates\\" + name + ".jpg")).Wait();
                            }
                            else
                            {
                                Task.Run(() => Functions.SendMessage(subjectTb.Text, email, messageTb.Text.Replace("{name}", name))).Wait();
                            }
                                
                        }

                        counter++;
                    }

                    SetStatus("Success");
                }
                else
                {
                    SetStatus("Error");
                    ShowMessage("Error while generating : Cannot find the specified file !");
                }
            }
            catch(Exception ec)
            {
                SetStatus("Error");
                ShowMessage("Error while generating : " + ec.Message);
            }
        }

        public void SetStatus(string statusText)
        {
            _statusLbl.Text = statusText;
            this.Refresh();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    class Functions
    {

        private static readonly string EMAIL = "ENTER_YOUR_EMAIL_HERE";
        private static readonly string PASSWORD = "ENTER_YOUR_APP_PASSWORD_HERE";

        public static bool SendMessage(string subject, string recipientEmail, string messageBody, string attachmentPath = null)
        {
            try
            {
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(EMAIL, PASSWORD);
                    smtp.EnableSsl = true;

                    var mail = new MailMessage();
                    mail.From = new MailAddress(EMAIL);
                    mail.To.Add(recipientEmail);
                    mail.Subject = subject;
                    mail.Body = messageBody;
                    mail.IsBodyHtml = false;

                    if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath) && Path.GetExtension(attachmentPath).ToLower() == ".jpg")
                    {
                        var attachment = new Attachment(attachmentPath);
                        attachment.ContentType.MediaType = "image/jpeg";
                        mail.Attachments.Add(attachment);
                    }
                    else if (!string.IsNullOrEmpty(attachmentPath))
                    {
                        Debug.WriteLine($"⚠️ Attachment skipped: '{attachmentPath}' not found or not a .jpg file.");
                    }

                    smtp.Send(mail);
                    Debug.WriteLine("✅ Email sent to " + recipientEmail);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("❌ Error sending email: " + ex.Message);
                return false;
            }
        }

        public enum CenterMode
        {
            None,
            CenterTexts,
            CenterRegion
        }
        public class TextSpec
        {
            public string Text { get; set; } = "";
            public string FontPath { get; set; } = "";
            public double FontSize { get; set; } = 12.0;
            public MagickColor Color { get; set; } = MagickColors.Black;
            public int? X { get; set; } = null;
            public int? Y { get; set; } = null;
        }

        public static void AddTextsFlexible(
        string imagePath,
        List<TextSpec> texts,
        CenterMode xCenterMode = CenterMode.None,
        CenterMode yCenterMode = CenterMode.None,
        int? regionX1 = null,
        int? regionX2 = null,
        int? regionY1 = null,
        int? regionY2 = null,
        List<int> gaps = null,
        string outputImagePath = "output.png",
        MagickColor bgFill = null)
        {
            try
            {
                using (MagickImage image = new MagickImage(imagePath))
                {
                    if (bgFill != null)
                    {
                        image.BackgroundColor = bgFill;
                        image.Alpha(AlphaOption.Remove); // Use valid enum value
                    }

                    int imageWidth = (int)image.Width;
                    int imageHeight = (int)image.Height;

                    // Use full image region if region values not provided
                    int x1 = regionX1 ?? 0;
                    int x2 = regionX2 ?? imageWidth;
                    int y1 = regionY1 ?? 0;
                    int y2 = regionY2 ?? imageHeight;

                    // Initialize gaps if not provided
                    if (gaps == null)
                    {
                        gaps = new List<int>();
                        for (int i = 0; i < texts.Count - 1; i++)
                        {
                            gaps.Add(0); // No gap by default
                        }
                    }

                    // Step 1: Measure all text metrics
                    List<ITypeMetric> metricsList = new List<ITypeMetric>();
                    double totalTextWidth = 0;
                    double maxTextHeight = 0;

                    for (int i = 0; i < texts.Count; i++)
                    {
                        TextSpec ts = texts[i];
                        using (MagickImage tempImg = new MagickImage(MagickColors.Transparent, 1, 1))
                        {
                            tempImg.Settings.Font = ts.FontPath;
                            tempImg.Settings.FontPointsize = ts.FontSize;
                            ITypeMetric metrics = tempImg.FontTypeMetrics(ts.Text);
                            metricsList.Add(metrics);

                            totalTextWidth += metrics.TextWidth;
                            if (i < gaps.Count)
                                totalTextWidth += gaps[i];

                            if (metrics.TextHeight > maxTextHeight)
                                maxTextHeight = metrics.TextHeight;
                        }
                    }

                    // Step 2: Calculate starting X and Y position
                    double startX = 0;
                    if (xCenterMode == CenterMode.CenterTexts || xCenterMode == CenterMode.CenterRegion)
                    {
                        double centerX = (xCenterMode == CenterMode.CenterTexts)
                            ? imageWidth / 2.0
                            : (x1 + x2) / 2.0;

                        startX = centerX - totalTextWidth / 2.0;
                    }

                    double startY = 0;
                    if (yCenterMode == CenterMode.CenterTexts || yCenterMode == CenterMode.CenterRegion)
                    {
                        double centerY = (yCenterMode == CenterMode.CenterTexts)
                            ? imageHeight / 2.0
                            : (y1 + y2) / 2.0;

                        startY = centerY - maxTextHeight / 2.0;
                    }

                    // Step 3: Draw text one by one
                    Drawables drawables = new Drawables();
                    double currentX = startX;

                    for (int i = 0; i < texts.Count; i++)
                    {
                        TextSpec ts = texts[i];
                        ITypeMetric metrics = metricsList[i];

                        double posX = ts.X.HasValue ? ts.X.Value : currentX;
                        double posY = ts.Y.HasValue ? ts.Y.Value : (startY + metrics.Ascent);

                        drawables
                            .Font(ts.FontPath)
                            .FontPointSize(ts.FontSize)
                            .FillColor(ts.Color)
                            .Text(posX, posY, ts.Text);

                        if (!ts.X.HasValue)
                            currentX += metrics.TextWidth;

                        if (i < gaps.Count && !ts.X.HasValue)
                            currentX += gaps[i];
                    }

                    // Step 4: Render everything
                    image.Draw(drawables);
                    image.Write(outputImagePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddTextsFlexible: " + ex.Message);
            }
        }




        public static void MergeImagesToPng(string baseImagePath, string overlayImagePath, int x, int y, string outputImagePath)
        {
            try
            {
                using (MagickImage baseImage = new MagickImage(baseImagePath))
                using (MagickImage overlayImage = new MagickImage(overlayImagePath))
                {
                    baseImage.Composite(overlayImage, x, y, CompositeOperator.Over);

                    baseImage.Format = MagickFormat.Png;

                    baseImage.Write(outputImagePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void MergeImagesToJpegAndResizeBase(string baseImagePath, string overlayImagePath, string outputImagePath)
        {
            try
            {
                using (MagickImage baseImage = new MagickImage(baseImagePath))
                using (MagickImage overlayImage = new MagickImage(overlayImagePath))
                {
                    baseImage.Resize(overlayImage.Width, overlayImage.Height);

                    baseImage.Composite(overlayImage, 0, 0, CompositeOperator.Over);

                    baseImage.Format = MagickFormat.Jpeg;

                    baseImage.Quality = 100;

                    baseImage.Write(outputImagePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
