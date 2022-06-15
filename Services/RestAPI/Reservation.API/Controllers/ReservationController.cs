﻿using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;
        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet("{bookingNumber}")]
        public ReservationDTO GetReservationByBookingId(int bookingNumber)
        {
            return reservationService.GetResByBookingId(bookingNumber);
        }
    }
}
