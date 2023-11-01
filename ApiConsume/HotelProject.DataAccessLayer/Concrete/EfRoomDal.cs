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
    public class EfRoomDal : GenericRepostory<Room>, IRoomDal
    {
        public EfRoomDal(Context context) : base(context)
        {
        }
    }
}
