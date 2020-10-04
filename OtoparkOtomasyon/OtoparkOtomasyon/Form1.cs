using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class FrmOtoparkArac : Form
    {
        public FrmOtoparkArac()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac();
            arac.Plaka = tbPlaka.Text;
            arac.AracTip = (AracTip)lstbAracTip.SelectedItem;
            arac.Kontak = cbKontak.Checked;
            arac.Abone = cbAbone.Checked;
            lstbOtoparkArac.Items.Add(arac);
        }

        private void FrmOtoparkArac_Load(object sender, EventArgs e)
        {
            lstbAracTip.Items.Add(new AracTip { AracTipAd = "Otomobil(1TL)", AracTipFiyat = 1 });
            lstbAracTip.Items.Add(new AracTip { AracTipAd = "Minubüs(2TL)", AracTipFiyat = 2 });
            lstbAracTip.Items.Add(new AracTip { AracTipAd = "Otobüs(4TL)", AracTipFiyat = 4 });
            lstbAracTip.Items.Add(new AracTip { AracTipAd = "Kamyon(4TL)", AracTipFiyat=4});
        }

        private void lstbOtoparkArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbOtoparkArac.SelectedItem == null) return;

            Arac seciliArac = (Arac)lstbOtoparkArac.SelectedItem;

            seciliArac.AracCikisSaat = DateTime.Now;
            lblPlakaBilgi.Text = seciliArac.Plaka;
            lblSureBilgi.Text = seciliArac.Sure.ToString();
            lblUcretBilgi.Text = seciliArac.Ucret.ToString("C2");
        }

        List<Arac> CikisYapanlar = new List<Arac>();

        private void CikisYap_Click(object sender, EventArgs e)
        {
            if (lstbOtoparkArac.SelectedItem == null) return;

            Arac seciliArac = (Arac)lstbOtoparkArac.SelectedItem;

            CikisYapanlar.Add(seciliArac);
            lstbOtoparkArac.Items.Remove(seciliArac);
        }

        private void btnGunlukSatisRapor_Click(object sender, EventArgs e)
        {
            GunlukSatisRapor gunlukSatisRapor = new GunlukSatisRapor();
            decimal gunlukKazanc = 0;

            foreach (Arac item in CikisYapanlar)
            {
                ListViewItem li = new ListViewItem();

                li.Text = item.Plaka;
                li.SubItems.Add(item.AracTip.AracTipAd);
                li.SubItems.Add(item.Abone?"Abone":"Değil");
                li.SubItems.Add(item.Sure.ToString());
                li.SubItems.Add(item.Ucret.ToString("C2"));

                gunlukSatisRapor.listView1.Items.Add(li);
                gunlukKazanc = gunlukKazanc + item.Ucret;

                gunlukSatisRapor.lblToplamUcretBilgi.Text = gunlukKazanc.ToString("C2");
                gunlukSatisRapor.lblToplamAracBilgi.Text = CikisYapanlar.Count.ToString();
                gunlukSatisRapor.Show();
            }
        }

    }
}
