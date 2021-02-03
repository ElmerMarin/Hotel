using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Toools.Services
{
    public class EmailSender:IEmailSender
    {
        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

    }
}
