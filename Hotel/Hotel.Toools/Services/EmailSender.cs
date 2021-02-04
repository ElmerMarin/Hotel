﻿using Hotel.ViewModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Toools.Services
{
    public class EmailSender:IEmailSender
    {
        private readonly EmailSettings _emailSettings;
        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                var credentials = new NetworkCredential(_emailSettings.Sender,_emailSettings.Password);

                var mail = new MailMessage()
                {
                    From = new MailAddress(_emailSettings.Sender, _emailSettings.SenderName),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true
                };

                mail.To.Add(new MailAddress(email));

                var client = new SmtpClient()
                {
                    Port=_emailSettings.MailPort,
                    DeliveryMethod=SmtpDeliveryMethod.Network,
                    UseDefaultCredentials=false,
                    Host=_emailSettings.MailServer,
                    EnableSsl=false,
                    Credentials=credentials

                };

                client.Send(mail);
            }
            catch (Exception ex)
            {

                throw new InvalidOperationException(ex.Message);
            }

            return Task.CompletedTask;
        }
    }
}
