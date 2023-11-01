using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repostories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class EfServiceDal : GenericRepostory<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {

        }
    }
}
