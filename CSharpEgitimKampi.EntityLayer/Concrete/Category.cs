using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi.EntityLayer.Concrete
{
	public class Category
	{
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }/*bir kategorıde birden fazla urun olabılır*/

    }
	/* Field - Variable - Property 
	 3 tane baslik ve bu basliklar birbirinden farklidir

	1.ci field ornek olarak field nerede kullanılıyor sınıf icinde degisken atandıgı zaman bu field oluyor

	2.ci propety ornegi sınıf icin verilen degisken yapısını get ve set alarak kullanılır yani ornegi asagida var bakın
	public int y { get; set; } bu sekılde olursa property olur

	3.cu variable ornegi ve tanımlanması degisken bir deger method icinde tanımlanırsa bunun adı variable olur
	yani soyle olursa asagıda ornegi var

	void test()
	{
	   int z;
	}
	 */
}
