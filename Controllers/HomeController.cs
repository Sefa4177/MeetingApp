using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        private int UserCount(int meetingId)
        {
            int UserCount = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == meetingId).Count();
            return UserCount;
        }
        public IActionResult Index()
        {
            List<MeetingInfo> meetingInfos = new();
            int saat = DateTime.Now.Hour;
            ViewBag.Selamlama = saat > 12 ?  " İyi Günler":"Günaydın";
            // ViewBag.UserName = "Sefa";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 21, 45, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 1).Count(),
            } ;
            meetingInfos.Add(meetingInfo);

            var meetingInfo2 = new MeetingInfo()
            {
                Id = 2,
                Location = "Ankara Kongre Merkezi",
                Date = new DateTime(2024, 02, 21, 18, 0, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 2).Count(),
            } ;
            meetingInfos.Add(meetingInfo2);

            var meetingInfo3 = new MeetingInfo()
            {
                Id = 3,
                Location = "İzmir Kongre Merkezi",
                Date = new DateTime(2024, 03, 15, 17, 15, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 3).Count(),
            } ;
            meetingInfos.Add(meetingInfo3);

            var meetingInfo4 = new MeetingInfo()
            {
                Id = 4,
                Location = "Trabzon Kongre Merkezi",
                Date = new DateTime(2023, 11, 15, 12, 45, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 4).Count(),
            } ;
            meetingInfos.Add(meetingInfo4);

            var meetingInfo5 = new MeetingInfo()
            {
                Id = 5,
                Location = "Konya Kongre Merkezi",
                Date = new DateTime(2023, 12, 11, 10, 30, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 5).Count(),
            } ;
            meetingInfos.Add(meetingInfo5);

            var meetingInfo6 = new MeetingInfo()
            {
                Id = 6,
                Location = "Antalya Kongre Merkezi",
                Date = new DateTime(2023, 12, 11, 23, 00, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 6).Count(),
            } ;
            meetingInfos.Add(meetingInfo6);

            var meetingInfo7 = new MeetingInfo()
            {
                Id = 7,
                Location = "Yalova Kongre Merkezi",
                Date = new DateTime(2023, 12, 30, 14, 30, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 7).Count(),
            } ;
            meetingInfos.Add(meetingInfo7);

            var meetingInfo8 = new MeetingInfo()
            {
                Id = 8,
                Location = "Sivas Kongre Merkezi",
                Date = new DateTime(2024, 06, 25, 11, 30, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 8).Count(),
            } ;
            meetingInfos.Add(meetingInfo8);

            var meetingInfo9 = new MeetingInfo()
            {
                Id = 9,
                Location = "Bursa Kongre Merkezi",
                Date = new DateTime(2024, 03, 30, 14, 30, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 9).Count(),
            } ;
            meetingInfos.Add(meetingInfo9);
            
            var meetingInfo10 = new MeetingInfo()
            {
                Id = 10,
                Location = "Kocaeli Kongre Merkezi",
                Date = new DateTime(2023, 10, 12, 15, 45, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 10).Count(),
            } ;
            meetingInfos.Add(meetingInfo10);

            var meetingInfo11 = new MeetingInfo()
            {
                Id = 11,
                Location = "Balıkesir Kongre Merkezi",
                Date = new DateTime(2023, 09, 30, 17, 30, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 11).Count(),
            } ;
            meetingInfos.Add(meetingInfo11);

            var meetingInfo12 = new MeetingInfo()
            {
                Id = 12,
                Location = "Eskişehir Kongre Merkezi",
                Date = new DateTime(2023, 09, 30, 17, 30, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 12).Count(),
            } ;
            meetingInfos.Add(meetingInfo12);

            var meetingInfo13 = new MeetingInfo()
            {
                Id = 13,
                Location = "Erzurum Kongre Merkezi",
                Date = new DateTime(2023, 09, 30, 17, 30, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 13).Count(),
            } ;
            meetingInfos.Add(meetingInfo13);

            var meetingInfo14 = new MeetingInfo()
            {
                Id = 14,
                Location = "Çanakkale Kongre Merkezi",
                Date = new DateTime(2023, 11, 14, 12, 30, 0),
                NumberOfPeople = Repository.Users.Where(i => i.WillAttend == true && i.MeetingId == 14).Count(),
            } ;
            meetingInfos.Add(meetingInfo14);

            return View(meetingInfos);
        }
    }
}