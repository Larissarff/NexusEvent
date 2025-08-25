using Moq;
using NexusEventBack.Controllers;
using NexusEventBack.Models;
using NexusEventBack.Services;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using NexusEventBack.Enums;


namespace NexusEventBack.Test.Controllers
{
    public class MeetingControllerTest
    {
        private readonly Mock<IMeetingService> _mockService;
        private readonly MeetingController _controller;

        public MeetingControllerTest()
        {
            _mockService = new Mock<IMeetingService>();
            _controller = new MeetingController(_mockService.Object);
        }

        private void SetUpControllerContext(int userId, string role, string accessStatus)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim(ClaimTypes.Role, role),
                new Claim("access_status", accessStatus)
            };
            var identity = new ClaimsIdentity(claims, "TestAuthType");
            var principal = new ClaimsPrincipal(identity);
            var httpContext = new DefaultHttpContext { User = principal };

            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = httpContext
            };
        }

        [Fact]
        public async Task GetAllOfMeetings_ReturnsAllMeetings
        {
            var mockService = new Mock<IMeetingService>();
            mockService.Setup(s => sbyte.GetAllMeetingsAsync())
            .ReturnsAsync(new List<MeetingModel>
            {
                new MeetingModel 
                {
                    Id = 1,
                    Title = "Meeting of Daily - Day 30/10/2025",
                    Date = new DateOnly(2025, 7, 15),
                    Location = "Remote"
                }
            })
        }
    }
}
    