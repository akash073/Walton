No mail client in here.

Make your own client in c#

```
var mailMessage = new MailMessage();
mailMessage.From = new MailAddress("waltoncrm@waltonbd.com");
mailMessage.To.Add("akash073@waltonbd.com");
mailMessage.CC.Add("akash073@gmail.com");
mailMessage.Subject = "Test";
mailMessage.Body = "Test";
var smtp = new SmtpClient();
smtp.Host = "YourHost";
smtp.Port = 25;
smtp.Credentials = new System.Net.NetworkCredential("username", "password");
smtp.Send(mailMessage);
```
