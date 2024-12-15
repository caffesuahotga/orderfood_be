using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Mvc;
namespace orderfood.Controllers
{
    [Route("api/")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpPost("send")]
        public async Task<IActionResult> SendNotification([FromBody] NotificationRequest request)
        {
            // Tạo danh sách các messages để gửi
            var messages = request.TargetTokens.Select(token => new Message()
            {
                Token = token,
                Notification = new Notification
                {
                    Title = request.Title,
                    Body = request.Body
                }
            }).ToList();

            var response = new List<string>();

            // Lặp qua từng message và gửi
            foreach (var message in messages)
            {
                string messageId = await FirebaseMessaging.DefaultInstance.SendAsync(message);
                response.Add(messageId);
            }

            return Ok(new { messageIds = response });
        }

        public class NotificationRequest
        {
            // Sử dụng danh sách các token thiết bị
            public List<string> TargetTokens { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }
    }
}
