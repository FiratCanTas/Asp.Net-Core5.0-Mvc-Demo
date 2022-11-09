using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IWriterService
	{
        void WriterAdd(Writer writer);
        //void WriterDelete(Writer category);
        //void WriterUpdate(Writer category);
        //List<Writer> GetList();
        //Category GetById(int id);
    }
}
