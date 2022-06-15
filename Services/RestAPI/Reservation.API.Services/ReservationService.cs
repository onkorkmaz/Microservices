using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBookingId(int bookingNumber)
        {
            return new ReservationDTO()
            {
                Id = new Random().Next(1,100),
                BookingNumber = bookingNumber,
                Amount = new Random().Next(1, 10000),
                BookingDate = DateTime.Now,
                CheckingDate = DateTime.Today.AddDays(10),
                CheckoutDate = DateTime.Today.AddDays(15)
            };
        }
    }
}
