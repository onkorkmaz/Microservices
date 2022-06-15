﻿using System;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }

        public int BookingNumber { get; set; }

        public DateTime CheckingDate { get; set; }

        public DateTime CheckoutDate { get; set; }

        public DateTime? BookingDate { get; set; }

        public double Amount { get; set; }
    }
}
