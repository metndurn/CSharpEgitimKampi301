using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
	public partial class FrmLocation : Form
	{
		public FrmLocation()
		{
			InitializeComponent();
		}
		/*veri tabanı baglantısı sagladık*/
		EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
		/*listele butonuna degisken degerlerini atayıp nerede listelenmesini istediysek oradan gosterdık*/
		private void btnList_Click(object sender, EventArgs e)
		{
			var values = db.Location.ToList();
			dataGridView1.DataSource = values;
		}

		private void FrmLocation_Load(object sender, EventArgs e)
		{
			var values = db.Guide.Select(x => new
			{
				FullName = x.GuideName + " " + x.GuideSurname,
				x.GuideId
			}).ToList();
			cmbGuide.DisplayMember = "FullName";
			cmbGuide.ValueMember = "GuideId";
			cmbGuide.DataSource = values;
		}
		/*ekleme islemi yapıldı once nesne turetıldı turetılen nesne uzerınden degerler ataması yapıldı
		 daha sonra o degerler form uzerındekı yapılar ıle eslestırılıp verıtabanına baglantısı saglandı*/
		private void btnAdd_Click(object sender, EventArgs e)
		{
			Location location = new Location();
			location.Capacity = byte.Parse(nudCapacity.Value.ToString());
			location.City = txtCity.Text;
			location.Country = txtCountry.Text;
			location.Price = decimal.Parse(txtPrice.Text);
			location.DayNight = txtDayNight.Text;
			location.GuideId=int.Parse(cmbGuide.SelectedValue.ToString());
			db.Location.Add(location);
			db.SaveChanges();
			MessageBox.Show("Ekleme işlemi başarılı");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var deletedValue = db.Location.Find(id);
			db.Location.Remove(deletedValue);
			db.SaveChanges();
			MessageBox.Show("Silme işlemi başarılı");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var updatedValue = db.Location.Find(id);
			updatedValue.Country = txtCountry.Text;
			updatedValue.City = txtCity.Text;
			updatedValue.DayNight = txtDayNight.Text;
			updatedValue.Capacity = byte.Parse(nudCapacity.Value.ToString());
			updatedValue.Price = decimal.Parse(txtPrice.Text);
			updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
			db.SaveChanges();
			MessageBox.Show("Güncelleme işlemi başarılı");
		}
	}
}
