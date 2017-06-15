using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using MyStore.domainDB.Abstract;
using MyStore.domainDB.Entities;

namespace MyStore.domainDB.Concrete
{
    public class EmailOrderProcessor:IOrderProcessor
    {
        private EmailSettings _emailSettings;

        //constructor for dependency resolver
        public EmailOrderProcessor(EmailSettings settings)
        {
            _emailSettings = settings;
        }

        //order processing method
        public void ProcessOrder(Cart cart, ShippingDetails shippingDetails)
        {
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.EnableSsl = _emailSettings.UseSsl;
                smtpClient.Host = _emailSettings.ServerName;
                smtpClient.Port = _emailSettings.ServerPort;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(_emailSettings.Username, _emailSettings.Password);

                if (_emailSettings.WriteAsFile)
                {
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
                    smtpClient.PickupDirectoryLocation = _emailSettings.FileLocation;
                    smtpClient.EnableSsl = false;
                }

                StringBuilder body = new StringBuilder()
                    .AppendLine("A new order has been submitted")
                    .AppendLine("------")
                    .AppendLine("Items:");

                foreach (var line in cart.Lines)
                {
                    var subTotal = line.Product.Price * line.Quantity;
                    body.AppendFormat("{0}x{1}(subtotal:{2:c}", line.Quantity, line.Product.ProductName, subTotal);

                    body.AppendFormat("Total order value:{0:c}", cart.ComputeTotalValue())
                        .AppendLine("---")
                        .AppendLine("Ship to:")
                        .AppendLine(shippingDetails.Name)
                        .AppendLine(shippingDetails.Line1)
                        .AppendLine(shippingDetails.Line2 ?? "")
                        .AppendLine(shippingDetails.Line3 ?? "")
                        .AppendLine(shippingDetails.City)
                        .AppendLine(shippingDetails.State ?? "")
                        .AppendLine(shippingDetails.Country)
                        .AppendLine(shippingDetails.Postcode)
                        .AppendLine("---")
                        .AppendFormat("Gift wrap: {0}", shippingDetails.GiftWrap ? "Yes" : "No");


                    MailMessage mailMessage = new MailMessage(
                        _emailSettings.MailFromAddress, //from
                        _emailSettings.MailToAddress, //to
                        "New Order Submitted", //subject
                        body.ToString());//body

                    if (_emailSettings.WriteAsFile)
                    {
                        mailMessage.BodyEncoding = Encoding.ASCII;
                    }
                    smtpClient.Send(mailMessage);
                }
                


            }
            //throw new NotImplementedException();
        }
    }

    //email settings
    public class EmailSettings
    {
        public string MailToAddress = "order@baldevpatel.co.uk";
        public string MailFromAddress = "mail@baldevpatel.co.uk";
        public bool UseSsl = true;

        public string Username = "mail@baldevpatel.co.uk";
        public string Password = "Jignesh198!";
        public string ServerName = "send.baldevpatel.co.uk";
        public int ServerPort = 587;
        public bool WriteAsFile = false;
        public string FileLocation = @"c:\mystore_emails";



    }

}