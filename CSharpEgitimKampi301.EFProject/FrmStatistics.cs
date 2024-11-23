﻿using System;
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
	public partial class FrmStatistics : Form
	{
		public FrmStatistics()
		{
			InitializeComponent();
		}
		EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
		private void FrmStatistics_Load(object sender, EventArgs e)
		{
			/*Toplam Lokasyon Sayısı*/
			lblLocationCount.Text = db.Location.Count().ToString();
			lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
			lblGuideCount.Text = db.Location.Count().ToString();
			lblAvgCapacity.Text = db.Location.Average(x => x.Capacity).ToString();
			lblAvgLocationPrice.Text = db.Location.Average(x => x.Price).Value.ToString("F2") + " ₺";

			int lastCountryId = db.Location.Max(x => x.LocationId);
			lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

			lblCapadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

			lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

			var romeGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
			lblRomeGuideName.Text = db.Guide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname)
			    .FirstOrDefault().ToString();

			var maxCapacity=db.Location.Max(x => x.Capacity);/*kodun ıcındekı en yuksek sayı kısmını verecektır*/
			lblMaxCapacityTour.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

			var maxPrice = db.Location.Max(x => x.Price);/*en yuksek fiyatlı turu verecektır*/
			lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

			var guideIdByNameMetinDuran=db.Guide.Where(x=>x.GuideName=="Metin"&&x.GuideSurname=="Duran").Select(y=>y.GuideId)
				.FirstOrDefault();
			lblMetinDuranLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameMetinDuran).Count().ToString();
		}
	}
}
