﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccsessLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		/*standart olarak buradakı metodlar kullanılacak*/
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		List<T> GetAll();
		T GetById(int id);
	}
}
