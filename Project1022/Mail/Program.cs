using System;

using System.Net;

using System.Net.Mail;

namespace EmailSmtp

{

    class Program

    {

        static void Main(string[] args)

        {

            try

            {

                // Credentials

                var credentials = new NetworkCredential("seonhui613@gmail.com", "tjsgmltkfkd1104");



                // Mail message

                var mail = new MailMessage()

                {

                    From = new MailAddress("seonhui613@gmail.com"),

                    Subject = "Test email(메일 제목)",

                    Body = "Test email body(메일 내용)"

                };



                mail.To.Add(new MailAddress("h613@naver.com"));



                // Smtp client

                var client = new SmtpClient()

                {

                    Port = 587,

                    DeliveryMethod = SmtpDeliveryMethod.Network,

                    UseDefaultCredentials = false,

                    Host = "smtp.gmail.com",

                    EnableSsl = true,

                    Credentials = credentials

                };



                // Send it...         

                client.Send(mail);

            }

            catch (Exception ex)

            {

                Console.WriteLine("Error in sending email: " + ex.Message);

                Console.ReadKey();

                return;

            }



            Console.WriteLine("Email sccessfully sent");

            Console.ReadKey();

        }

    }

}

