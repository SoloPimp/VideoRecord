using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VideoRecordWin
{
    [Serializable]
    class Kayit
    {
        List<byte[]> dizi = new List<byte[]>();
        public int interval;
        public Bilgi Info;
        public void Resim_Ekle(byte[] bmp)
        {
            dizi.Add(bmp);
        }
        public int Kare_Adet()
        {
            return dizi.Count;
        }
        public List<byte[]> Dizi_Dondur()
        {
            return dizi;
        }
        public void Video_Kayit(string yol)
        {
            FileStream fs = new FileStream(yol, FileMode.CreateNew);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
    [Serializable]
    public class Bilgi
    {
        public DateTime Tarih;
        public int Kare_Sayisi;
        public string Kalite;
        public string sure;
        public Bilgi(DateTime tarih, int kare, string kalite)
        { Tarih = tarih; Kare_Sayisi = kare; Kalite = kalite; }
    }
}
