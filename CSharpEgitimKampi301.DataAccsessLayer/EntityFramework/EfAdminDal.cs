using CSharpEgitimKampi.EntityLayer.Concrete;
using CSharpEgitimKampi301.DataAccsessLayer.Abstract;
using CSharpEgitimKampi301.DataAccsessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccsessLayer.EntityFramework
{
	public class EfAdminDal:GenericRepository<Admin>,IAdminDal
	{
	}
}
