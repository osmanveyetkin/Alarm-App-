using System;
using System.Windows.Forms;
using WMPLib;

namespace alarm1
{
    public partial class Form1 : Form
    {
        //alarm zamanı ve süre kontrolü
        private DateTime alarmTime;
        private TimeSpan totalDuration;

        //Zamanlayıcı ve medya oynatıcı
        private Timer timer;
        private WindowsMediaPlayer player;

        public Form1()
        {
            InitializeComponent();

            //timer ayarları
            timer = new Timer();
            timer.Interval = 1000; //1 saniyede bir tetiklenmesi
            timer.Tick += Timer_Tick;

            //ses oynatıcı
            player = new WindowsMediaPlayer();

            //Labellerın başlgç. değerleri
            nowLabel.Text = "Now: --:--:--";
            timeLeftLabel.Text = "Time left: --:--:--";

            //saat , dakika c.boxları
            for (int i = 0; i < 24; i++)
                hourCombo.Items.Add(i.ToString("D2"));
            for (int i = 0; i < 60; i++)
                minuteCombo.Items.Add(i.ToString("D2"));
            //Stil

            hourCombo.ItemHeight = 30;
            minuteCombo.ItemHeight = 30;

            //Varsayılan alarm 

            hourCombo.SelectedIndex = 7;
            minuteCombo.SelectedIndex = 0;

        }

        // Alarmı konf. şeması
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (hourCombo.SelectedItem == null || minuteCombo.SelectedItem == null || string.IsNullOrEmpty(filePathBox.Text))
            {
                MessageBox.Show("Please select time and music file.");
                return;
            }
            int hour = int.Parse(hourCombo.SelectedItem.ToString());
            int minute = int.Parse(minuteCombo.SelectedItem.ToString());

            alarmTime = DateTime.Today.AddHours(hour).AddMinutes(minute);
            if (alarmTime < DateTime.Now)
                alarmTime = alarmTime.AddDays(1); // geçmişse yarına kur

            totalDuration = alarmTime - DateTime.Now;

            progressBar.Maximum = (int)totalDuration.TotalSeconds;
            progressBar.Value = 0;

            timer.Start();
            this.Text = $"Alarm set: {alarmNameBox.Text}";
            
        }

        // Her saniye çalışan kontolcü
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan remaning = alarmTime - now;

            nowLabel.Text = "Now: " + now.ToString("HH:mm:ss");

            if(remaning.TotalSeconds <=0)
            {
                //Alarm zamanı 
                timer.Stop();
                progressBar.Value = progressBar.Maximum;
                timeLeftLabel.Text = "Time left: 00:00:00";

                //medya çaldır

                player.URL = filePathBox.Text;
                player.controls.play();

                //Alarmı kapatma yada erteleme adımı
                DialogResult result = MessageBox.Show(
                   "Alarm time reached!\n\n Click Retry to snoze 10 minutes; \nClick Cancell to dismiss.",
                   $"Alarm:{alarmNameBox.Text}",
                   MessageBoxButtons.RetryCancel,
                   MessageBoxIcon.Information
                  );
                if ( result==DialogResult.Cancel)//Dismiss
                {
                    player.controls.stop();
                    ResetAlarm();
                }
                else if ( result == DialogResult.Retry) //Snooze
                {
                    player.controls.stop();

                    //10 dakika erteleme
                    alarmTime = DateTime.Now.AddMinutes(10);
                    totalDuration = alarmTime - DateTime.Now;
                    progressBar.Maximum = (int)totalDuration.TotalSeconds;
                    progressBar.Value = 0;

                    //saat ve dakika güncelleme

                    hourCombo.SelectedItem = alarmTime.Hour.ToString("D2");
                    minuteCombo.SelectedItem = alarmTime.Minute.ToString("D2");

                    timer.Start();


                }
            }
            else
            {
                //alarm süresi henüz gelmediğnde
                timeLeftLabel.Text = $"Time left: {remaning.ToString(@"hh\:mm\:ss")}";
                progressBar.Value = (int)(totalDuration.TotalSeconds - remaning.TotalSeconds);
            }
           
        }

        // Dosya seçicim butonu
        private void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Audio Files|*.mp3;*.mp4;*.wav";
                if (ofd.ShowDialog() == DialogResult.OK)
                    filePathBox.Text = ofd.FileName;
            }
           
        }

        // Alarmı iptal etme fonks. 
        private void cancelButton_Click(object sender, EventArgs e)
        {
            ResetAlarm();
        }

        // Ortak sıfırlama işlemi method
        private void ResetAlarm()
        {
            timer.Stop();
            player.controls.stop();
            progressBar.Value = 0;
            timeLeftLabel.Text= "Time left: --:--:--";
            nowLabel.Text = "Now: --:--:--";
            this.Text = "Modern Alarm";
            
        }
    }
}