﻿using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concrete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>,IBookingDal
    {
        public EfBookingDal(Context context) : base(context)
        { 
        
        }

        public void BookingStatusChangeApproved(Booking booking)
        {
           var context = new Context();
           var values = context.Bookings.Where(x=>x.BookingId == booking.BookingId).FirstOrDefault();
            values.Status = "Onayladı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Onayladı";
            context.SaveChanges();
        }

        public void BookingStatusChangeCancel(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "İptal Edildi";
            context.SaveChanges();
        }

        public void BookingStatusChangeWait(int id)
        {
            var context = new Context();
            var values = context.Bookings.Find(id);
            values.Status = "Müşteri Aranacak";
            context.SaveChanges();
        }

        public int GetBookingCount()
        {
            using var context = new Context();
            var value = context.Bookings.Count();
            return value;
        }

        public List<Booking> Last6Bookings()
        {
            using var context = new Context();
            var values = context.Bookings.OrderByDescending(x=>x.BookingId).Take(6).ToList();
            return values;
        }
    }
}
