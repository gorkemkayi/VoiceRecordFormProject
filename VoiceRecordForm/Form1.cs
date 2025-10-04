using NAudio.Wave;

namespace VoiceRecordForm
{
    public partial class Form1 : Form
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string outputFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SesKayitlari");
                Directory.CreateDirectory(folder);

                outputFilePath = Path.Combine(folder, $"kayit_{DateTime.Now:yyyyMMdd_HHmmss}.wav");

                waveIn = new WaveInEvent();
                waveIn.WaveFormat = new WaveFormat(44100, 1);
                writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);

                waveIn.DataAvailable += (s, a) =>
                {
                    writer.Write(a.Buffer, 0, a.BytesRecorded);
                };
                waveIn.RecordingStopped += (s, a) =>
                {
                    writer?.Dispose();
                    waveIn?.Dispose();
                };

                waveIn.StartRecording();
                lblPath.Text = "Kayýt baþladý...";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btnStopRecord_Click(object sender, EventArgs e)
        {
            try
            {
                waveIn?.StopRecording();
                lblPath.Text = $"Kayýt durduruldu. Dosya: {outputFilePath}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
